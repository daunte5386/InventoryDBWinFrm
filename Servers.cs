using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{
    class Servers : Inventory
    {
        private string serverProcessor, serverProcessorSpeed, serverRAM,
                       serverOperatingSystem, serverOperatingSystemBitType,
                       serverHDD, serverHDDRaidType, serverHDDCapacity,
                       serverVirtual, serverLocation;

        public Servers() { }

        public Servers(string ma, string mo, string serNum, string serProc, string serProcSp,
                       string serRa, string serOS, string serOSBit, string serHDD, string SerHDDRaiTy,
                       string serHDDCap, string serVirt, string serLoc)
                       :base(ma, mo, serNum)
        {
            serverProcessor = serProc;
            serverProcessorSpeed = serProcSp;
            serverRAM = serRa;
            serverOperatingSystem = serOS;
            serverOperatingSystemBitType = serOSBit;
            serverHDD = serHDD;
            serverHDDRaidType = SerHDDRaiTy;
            serverHDDCapacity = serHDDCap;
            serverVirtual = serVirt;
            serverLocation = serLoc;
        }

        public string ServerProcessor { get { return serverProcessor; } set { serverProcessor = value; } }

        public string ServerProcessorSpeed { get { return serverProcessorSpeed; } set { serverProcessorSpeed = value; } }

        public string ServerRAM { get { return serverRAM; } set { serverRAM = value; } }

        public string ServerOperatingSystem { get { return serverOperatingSystem; } set { serverOperatingSystem = value; } }

        public string ServerOperatingSystemBitType { get { return serverOperatingSystemBitType; } set { serverOperatingSystemBitType = value; } }

        public string ServerHDD { get { return serverHDD; } set { serverHDD = value; } }

        public string ServerHDDRaidType { get { return serverHDDRaidType; }set { serverHDDRaidType = value; } }

        public string ServerHDDCapacity { get { return serverHDDCapacity; } set { serverHDDCapacity = value; } }

        public string ServerVirtual { get { return serverVirtual; }set { serverVirtual = value; } }

        public string ServerLocation { get { return serverLocation; } set { serverLocation = value; } }

        public void SaveToDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection();

                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                         "AttachDbFilename=|DataDirectory|\\InventoryDB.mdf;" +
                                         "Integrated Security=True");

                string qry = "INSERT INTO Servers(serverMake, serverModel, serverSerNum, serverProc, serverProcSpeed, serverRAM, serverOS, " +
                                                  "serverOSBitType, serverHDD, serverHDDRaidType, serverHDDCap, serverVirtual, serverLocation) " +
                                                  "VALUES ('" + Make + "', '" + Model + "', '" + SerialNumber + "', '" + serverProcessor +
                                                           "', '" + serverProcessorSpeed + "', '" + serverRAM + "', '" + serverOperatingSystem +
                                                           "', '" + serverOperatingSystemBitType + "', '" + serverHDD + "', '" + serverHDDRaidType +
                                                           "', '" + serverHDDCapacity + "', '" + ServerVirtual + "', '" + serverLocation + "'" + ")";

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
