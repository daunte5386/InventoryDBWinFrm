using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{
    class Monitors : Inventory
    {
        private string monitorSize, monitorType, monitorLocation;

        public Monitors() { }

        public Monitors(string ma, string mo, string serNum, string monSize, string monType, string monLoc)
                        :base(ma, mo, serNum)
        {
            monitorSize = monSize;
            monitorType = monType;
            monitorLocation = monLoc;
        }

        public string MonitorSize { get { return monitorSize; } set { monitorSize = value; } }
        
        public string MonitorType { get { return monitorType; } set { monitorType = value; } }

        public string MonitorLocation { get { return monitorLocation; } set { monitorLocation = value; } }

        public void SaveToDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection();

                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                         "AttachDbFilename=|DataDirectory|\\InventoryDB.mdf;" +
                                         "Integrated Security=True");

                string qry = "INSERT INTO Monitors(monitorMake, monitorModel, monitorSerNum, monitorSize, monitorType, monitorLocation)" +
                                          "VALUES('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + monitorSize +
                                                  "', '" + monitorType + "', '" + MonitorLocation + "'" + ")";

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
