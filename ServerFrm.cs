using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{  
    public partial class ServerFrm : Form
    {
        Servers serv = new Servers();

        public ServerFrm()
        {
            InitializeComponent();
        }

        private void servSaveBttn_Click(object sender, EventArgs e)
        {
            serv.Make = servMakeTxtBx.Text;
            serv.Model = servModelTxtBx.Text;
            serv.SerialNumber = servSerNumTxtBx.Text;
            serv.ServerProcessor = servProcTxtBx.Text;
            serv.ServerProcessorSpeed = servProcSpeedTxtBx.Text;
            serv.ServerRAM = servRAMTxtBx.Text;
            serv.ServerOperatingSystem = servOSTxtBx.Text;
            serv.ServerOperatingSystemBitType = servOSBitTypeTxtBx.Text;
            serv.ServerHDD = servHDDTxtBx.Text;
            serv.ServerHDDRaidType = servHDDRaidTypeTxtBx.Text;
            serv.ServerHDDCapacity = servHDDCapTxtBx.Text;
            serv.ServerVirtual = servVirtTxtBx.Text;
            serv.ServerLocation = servLocationTxtBx.Text;

            serv.SaveToDB();
        }

        private void servClearBttn_Click(object sender, EventArgs e)
        {
            servMakeTxtBx.Text = "";
            servModelTxtBx.Text = "";
            servSerNumTxtBx.Text = "";
            servProcTxtBx.Text = "";
            servProcSpeedTxtBx.Text = "";
            servRAMTxtBx.Text = "";
            servOSTxtBx.Text = "";
            servOSBitTypeTxtBx.Text = "";
            servHDDTxtBx.Text = "";
            servHDDRaidTypeTxtBx.Text = "";
            servHDDCapTxtBx.Text = "";
            servVirtTxtBx.Text = "";
            servLocationTxtBx.Text = "";
        }

        private void servExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
