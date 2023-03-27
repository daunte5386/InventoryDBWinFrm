using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{
    class Computers : Inventory
    {
        private string computerProcessor, computerProcessorSpeed, computerRAM,
                       computerOperatingSystem, computerOperatingSystemBitType,
                       computerHardDriveSize, computerLocation;

        public Computers() { }

        public Computers(string ma, string mo, string serNum, string compProc,
                         string compProcSp, string compR, string compOS,
                         string compOSBT, string compHDD, string compLoc)
                         :base (ma, mo, serNum)
        {
            computerProcessor = compProc;
            computerProcessorSpeed = compProcSp;
            computerRAM = compR;
            computerOperatingSystem = compOS;
            computerOperatingSystemBitType = compOSBT;
            computerHardDriveSize = compHDD;
            computerLocation = compLoc;
        }

        public string ComputerProcessor { get { return computerProcessor; } set { computerProcessor = value; } }

        public string ComputerProcessorSpeed { get { return computerProcessorSpeed; } set { computerProcessorSpeed = value; } }

        public string ComputerRAM { get { return computerRAM; }set { computerRAM = value; } }

        public string ComputerOperatingSystem { get { return computerOperatingSystem; } set { computerOperatingSystem = value; } }

        public string ComputerOperatingSystemBitType { get { return computerOperatingSystemBitType; } set { computerOperatingSystemBitType = value; } }

        public string ComputerHardDriveSize { get { return computerHardDriveSize; } set { computerHardDriveSize = value; } }

        public string ComputerLocation { get { return computerLocation; } set { computerLocation = value; } }

        public void SaveToDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection();

                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                         "AttachDbFilename=|DataDirectory|\\InventoryDB.mdf;" +
                                         "Integrated Security=True");

                string qry = "INSERT INTO Computer(computerMake, computerModel, computerSerNum, computerProc, computerProcSpeed, " +
                                                   "computerRAM, computerOS, computerOSBitType, computerHDDSize, computerLocation) " +
                                                   "Values ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + computerProcessor +
                                                   "', '" + computerProcessorSpeed + "', '" + computerRAM + "', '" + computerOperatingSystem +
                                                   "', '" + computerOperatingSystemBitType + "', '" + computerHardDriveSize + "', '" + computerLocation + "'" + ")";

                SqlCommand sql1 = new SqlCommand(qry, conn);
                sql1.CommandType = System.Data.CommandType.Text;

                conn.Open();

                sql1.ExecuteNonQuery();

                MessageBox.Show("Database Updated");

                conn.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
