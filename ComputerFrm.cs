using System;
using System.Windows.Forms;

namespace InventoryDBWinFrm
{
    public partial class ComputerFrm : Form
    {
        Computers comp = new Computers();

        public ComputerFrm()
        {
            InitializeComponent();
        }

        private void compSaveBttn_Click(object sender, EventArgs e)
        {
            comp.Make = compMakeTxtBx.Text;
            comp.Model = compModelTxtBx.Text;
            comp.SerialNumber = compSerNumTxtBx.Text;
            comp.ComputerProcessor = compProcTxtBx.Text;
            comp.ComputerProcessorSpeed = compProcSpeedTxtBx.Text;
            comp.ComputerRAM = compRAMTxtBx.Text;
            comp.ComputerOperatingSystem = compOSTxtBx.Text;
            comp.ComputerOperatingSystemBitType = compOSBitTypeTxtBx.Text;
            comp.ComputerHardDriveSize = compHDDSizeTxtBx.Text;
            comp.ComputerLocation = compLocationTxtBx.Text;

            comp.SaveToDB();
        }

        private void compClearBttn_Click(object sender, EventArgs e)
        {
            compMakeTxtBx.Text = "";
            compModelTxtBx.Text = "";
            compSerNumTxtBx.Text = "";
            compProcTxtBx.Text = "";
            compProcSpeedTxtBx.Text = "";
            compRAMTxtBx.Text = "";
            compOSTxtBx.Text = "";
            compOSBitTypeTxtBx.Text = "";
            compHDDSizeTxtBx.Text = "";
            compLocationTxtBx.Text = "";
        }

        private void compExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             private void compRefreshBttn_Click(object sender, EventArgs e)
        {
            //this.computerTableAdapter.Fill(computerDBDataSet.Computer);
        }

        private void ComputerFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerDBDataSet.Computers' table. You can move, or remove it, as needed.
            this.computersTableAdapter.Fill(this.computerDBDataSet.Computers);

        }
    }
}
