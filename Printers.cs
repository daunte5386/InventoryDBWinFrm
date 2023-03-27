using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{
    class Printers : Inventory
    {
        private string printerType, printerCartridgeNumber, printerLocation;

        public Printers() { }

        public Printers(string ma, string mo, string serNum, string priTyp, string priCartNum, string priLoc)
                        :base(ma, mo, serNum)
        {
            printerType = priTyp;
            printerCartridgeNumber = priCartNum;
            printerLocation = priLoc;
        }
        
        public string PrinterType { get { return printerType; } set { printerType = value; } }

        public string PrinterCartridgeNumber { get { return printerCartridgeNumber; } set { printerCartridgeNumber = value; } }

        public string PrinterLocation { get { return printerLocation; } set { printerLocation = value; } }

        public void SaveToDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection();

                conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                                         "AttachDbFilename=|DataDirectory|\\InventoryDB.mdf;" +
                                         "Integrated Security=True");

                string qry = "INSERT INTO Printers(printerMake, printerModel, printerSerNum, printerType, printerCartNum, printerLocation)" +
                                          "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + printerType +
                                                   "', '" + printerCartridgeNumber + "', '" + printerLocation + "'" + ")";

                SqlCommand sql1 = new SqlCommand(qry, conn);
                sql1.CommandType = System.Data.CommandType.Text;

                conn.Open();

                sql1.ExecuteNonQuery();

                MessageBox.Show("Database Updated");

                conn.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
