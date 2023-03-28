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
    public partial class PrinterFrm : Form
    {
        Printers print = new Printers();

        public PrinterFrm()
        {
            InitializeComponent();
        }

        private void printSaveBttn_Click(object sender, EventArgs e)
        {
            print.Make = printerMakeTxtBx.Text;
            print.Model = printerModelTxtBx.Text;
            print.SerialNumber = printerSerNumTxtBx.Text;
            print.PrinterType = printerTypeTxtBx.Text;
            print.PrinterCartridgeNumber = printerCartNumTxtBx.Text;
            print.PrinterLocation = printerLocationTxtBx.Text;

            print.SaveToDB();
        }

        private void printClearBttn_Click(object sender, EventArgs e)
        {
            printerMakeTxtBx.Text = "";
            printerModelTxtBx.Text = "";
            printerSerNumTxtBx.Text = "";
            printerTypeTxtBx.Text = "";
            printerCartNumTxtBx.Text = "";
            printerLocationTxtBx.Text = "";
        }

        private void printExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
