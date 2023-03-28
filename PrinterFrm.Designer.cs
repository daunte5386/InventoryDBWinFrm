namespace InventoryDBWinFrm
{
    partial class PrinterFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printerHeadTitleLbl = new System.Windows.Forms.Label();
            this.printerHeadLbl = new System.Windows.Forms.Label();
            this.printerBodyPnl = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.printInputTab = new System.Windows.Forms.TabPage();
            this.printExitBttn = new System.Windows.Forms.Button();
            this.printClearBttn = new System.Windows.Forms.Button();
            this.printSaveBttn = new System.Windows.Forms.Button();
            this.printerLocationTxtBx = new System.Windows.Forms.TextBox();
            this.printerCartNumTxtBx = new System.Windows.Forms.TextBox();
            this.printerTypeTxtBx = new System.Windows.Forms.TextBox();
            this.printerSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.printerModelTxtBx = new System.Windows.Forms.TextBox();
            this.printerMakeTxtBx = new System.Windows.Forms.TextBox();
            this.printLocationLbl = new System.Windows.Forms.Label();
            this.printCartNumLbl = new System.Windows.Forms.Label();
            this.printTypeLbl = new System.Windows.Forms.Label();
            this.printSerNumLbl = new System.Windows.Forms.Label();
            this.printModelLbl = new System.Windows.Forms.Label();
            this.printMakeLbl = new System.Windows.Forms.Label();
            this.printViewTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printRefreshBttn = new System.Windows.Forms.Button();
            this.printerDBDataSet = new InventoryDBWinFrm.PrinterDBDataSet();
            this.printersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printersTableAdapter = new InventoryDBWinFrm.PrinterDBDataSetTableAdapters.PrintersTableAdapter();
            this.tableAdapterManager = new InventoryDBWinFrm.PrinterDBDataSetTableAdapters.TableAdapterManager();
            this.printerInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerCartNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.printerBodyPnl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.printInputTab.SuspendLayout();
            this.printViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.printerHeadTitleLbl);
            this.panel1.Controls.Add(this.printerHeadLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 100);
            this.panel1.TabIndex = 0;
            // 
            // printerHeadTitleLbl
            // 
            this.printerHeadTitleLbl.AutoSize = true;
            this.printerHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerHeadTitleLbl.Location = new System.Drawing.Point(313, 56);
            this.printerHeadTitleLbl.Name = "printerHeadTitleLbl";
            this.printerHeadTitleLbl.Size = new System.Drawing.Size(144, 26);
            this.printerHeadTitleLbl.TabIndex = 1;
            this.printerHeadTitleLbl.Text = "Printer Page";
            // 
            // printerHeadLbl
            // 
            this.printerHeadLbl.AutoSize = true;
            this.printerHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerHeadLbl.Location = new System.Drawing.Point(34, 11);
            this.printerHeadLbl.Name = "printerHeadLbl";
            this.printerHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.printerHeadLbl.TabIndex = 0;
            this.printerHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // printerBodyPnl
            // 
            this.printerBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printerBodyPnl.Controls.Add(this.tabControl1);
            this.printerBodyPnl.Location = new System.Drawing.Point(13, 119);
            this.printerBodyPnl.Name = "printerBodyPnl";
            this.printerBodyPnl.Size = new System.Drawing.Size(787, 425);
            this.printerBodyPnl.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.printInputTab);
            this.tabControl1.Controls.Add(this.printViewTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // printInputTab
            // 
            this.printInputTab.Controls.Add(this.printExitBttn);
            this.printInputTab.Controls.Add(this.printClearBttn);
            this.printInputTab.Controls.Add(this.printSaveBttn);
            this.printInputTab.Controls.Add(this.printerLocationTxtBx);
            this.printInputTab.Controls.Add(this.printerCartNumTxtBx);
            this.printInputTab.Controls.Add(this.printerTypeTxtBx);
            this.printInputTab.Controls.Add(this.printerSerNumTxtBx);
            this.printInputTab.Controls.Add(this.printerModelTxtBx);
            this.printInputTab.Controls.Add(this.printerMakeTxtBx);
            this.printInputTab.Controls.Add(this.printLocationLbl);
            this.printInputTab.Controls.Add(this.printCartNumLbl);
            this.printInputTab.Controls.Add(this.printTypeLbl);
            this.printInputTab.Controls.Add(this.printSerNumLbl);
            this.printInputTab.Controls.Add(this.printModelLbl);
            this.printInputTab.Controls.Add(this.printMakeLbl);
            this.printInputTab.Location = new System.Drawing.Point(4, 22);
            this.printInputTab.Name = "printInputTab";
            this.printInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.printInputTab.Size = new System.Drawing.Size(769, 389);
            this.printInputTab.TabIndex = 0;
            this.printInputTab.Text = "Printer Input";
            this.printInputTab.UseVisualStyleBackColor = true;
            // 
            // printExitBttn
            // 
            this.printExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printExitBttn.Location = new System.Drawing.Point(670, 359);
            this.printExitBttn.Name = "printExitBttn";
            this.printExitBttn.Size = new System.Drawing.Size(75, 23);
            this.printExitBttn.TabIndex = 8;
            this.printExitBttn.Text = "Exit";
            this.printExitBttn.UseVisualStyleBackColor = true;
            this.printExitBttn.Click += new System.EventHandler(this.printExitBttn_Click);
            // 
            // printClearBttn
            // 
            this.printClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printClearBttn.Location = new System.Drawing.Point(561, 359);
            this.printClearBttn.Name = "printClearBttn";
            this.printClearBttn.Size = new System.Drawing.Size(75, 23);
            this.printClearBttn.TabIndex = 7;
            this.printClearBttn.Text = "Clear";
            this.printClearBttn.UseVisualStyleBackColor = true;
            this.printClearBttn.Click += new System.EventHandler(this.printClearBttn_Click);
            // 
            // printSaveBttn
            // 
            this.printSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSaveBttn.Location = new System.Drawing.Point(453, 359);
            this.printSaveBttn.Name = "printSaveBttn";
            this.printSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.printSaveBttn.TabIndex = 6;
            this.printSaveBttn.Text = "Save";
            this.printSaveBttn.UseVisualStyleBackColor = true;
            this.printSaveBttn.Click += new System.EventHandler(this.printSaveBttn_Click);
            // 
            // printerLocationTxtBx
            // 
            this.printerLocationTxtBx.Location = new System.Drawing.Point(394, 309);
            this.printerLocationTxtBx.Name = "printerLocationTxtBx";
            this.printerLocationTxtBx.Size = new System.Drawing.Size(351, 20);
            this.printerLocationTxtBx.TabIndex = 5;
            // 
            // printerCartNumTxtBx
            // 
            this.printerCartNumTxtBx.Location = new System.Drawing.Point(394, 258);
            this.printerCartNumTxtBx.Name = "printerCartNumTxtBx";
            this.printerCartNumTxtBx.Size = new System.Drawing.Size(172, 20);
            this.printerCartNumTxtBx.TabIndex = 4;
            // 
            // printerTypeTxtBx
            // 
            this.printerTypeTxtBx.Location = new System.Drawing.Point(394, 205);
            this.printerTypeTxtBx.Name = "printerTypeTxtBx";
            this.printerTypeTxtBx.Size = new System.Drawing.Size(172, 20);
            this.printerTypeTxtBx.TabIndex = 3;
            // 
            // printerSerNumTxtBx
            // 
            this.printerSerNumTxtBx.Location = new System.Drawing.Point(394, 149);
            this.printerSerNumTxtBx.Name = "printerSerNumTxtBx";
            this.printerSerNumTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerSerNumTxtBx.TabIndex = 2;
            // 
            // printerModelTxtBx
            // 
            this.printerModelTxtBx.Location = new System.Drawing.Point(394, 95);
            this.printerModelTxtBx.Name = "printerModelTxtBx";
            this.printerModelTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerModelTxtBx.TabIndex = 1;
            // 
            // printerMakeTxtBx
            // 
            this.printerMakeTxtBx.Location = new System.Drawing.Point(394, 41);
            this.printerMakeTxtBx.Name = "printerMakeTxtBx";
            this.printerMakeTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.printerMakeTxtBx.Size = new System.Drawing.Size(217, 20);
            this.printerMakeTxtBx.TabIndex = 0;
            // 
            // printLocationLbl
            // 
            this.printLocationLbl.AutoSize = true;
            this.printLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLocationLbl.Location = new System.Drawing.Point(266, 308);
            this.printLocationLbl.Name = "printLocationLbl";
            this.printLocationLbl.Size = new System.Drawing.Size(122, 19);
            this.printLocationLbl.TabIndex = 15;
            this.printLocationLbl.Text = "Printer Location:";
            // 
            // printCartNumLbl
            // 
            this.printCartNumLbl.AutoSize = true;
            this.printCartNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCartNumLbl.Location = new System.Drawing.Point(202, 257);
            this.printCartNumLbl.Name = "printCartNumLbl";
            this.printCartNumLbl.Size = new System.Drawing.Size(186, 19);
            this.printCartNumLbl.TabIndex = 14;
            this.printCartNumLbl.Text = "Printer Cartridge Number:";
            // 
            // printTypeLbl
            // 
            this.printTypeLbl.AutoSize = true;
            this.printTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTypeLbl.Location = new System.Drawing.Point(291, 204);
            this.printTypeLbl.Name = "printTypeLbl";
            this.printTypeLbl.Size = new System.Drawing.Size(97, 19);
            this.printTypeLbl.TabIndex = 13;
            this.printTypeLbl.Text = "Printer Type:";
            // 
            // printSerNumLbl
            // 
            this.printSerNumLbl.AutoSize = true;
            this.printSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSerNumLbl.Location = new System.Drawing.Point(227, 148);
            this.printSerNumLbl.Name = "printSerNumLbl";
            this.printSerNumLbl.Size = new System.Drawing.Size(161, 19);
            this.printSerNumLbl.TabIndex = 12;
            this.printSerNumLbl.Text = "Printer Serial Number:";
            // 
            // printModelLbl
            // 
            this.printModelLbl.AutoSize = true;
            this.printModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printModelLbl.Location = new System.Drawing.Point(280, 94);
            this.printModelLbl.Name = "printModelLbl";
            this.printModelLbl.Size = new System.Drawing.Size(108, 19);
            this.printModelLbl.TabIndex = 11;
            this.printModelLbl.Text = "Printer Model:";
            // 
            // printMakeLbl
            // 
            this.printMakeLbl.AutoSize = true;
            this.printMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printMakeLbl.Location = new System.Drawing.Point(283, 40);
            this.printMakeLbl.Name = "printMakeLbl";
            this.printMakeLbl.Size = new System.Drawing.Size(105, 19);
            this.printMakeLbl.TabIndex = 10;
            this.printMakeLbl.Text = "Printer Make:";
            // 
            // printViewTab
            // 
            this.printViewTab.Controls.Add(this.printRefreshBttn);
            this.printViewTab.Controls.Add(this.dataGridView1);
            this.printViewTab.Location = new System.Drawing.Point(4, 22);
            this.printViewTab.Name = "printViewTab";
            this.printViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.printViewTab.Size = new System.Drawing.Size(769, 389);
            this.printViewTab.TabIndex = 1;
            this.printViewTab.Text = "Printer View";
            this.printViewTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printerInvIDNumDataGridViewTextBoxColumn,
            this.printerMakeDataGridViewTextBoxColumn,
            this.printerModelDataGridViewTextBoxColumn,
            this.printerSerNumDataGridViewTextBoxColumn,
            this.printerTypeDataGridViewTextBoxColumn,
            this.printerCartNumDataGridViewTextBoxColumn,
            this.printerLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.printersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // printRefreshBttn
            // 
            this.printRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printRefreshBttn.Location = new System.Drawing.Point(688, 359);
            this.printRefreshBttn.Name = "printRefreshBttn";
            this.printRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.printRefreshBttn.TabIndex = 1;
            this.printRefreshBttn.Text = "Refresh";
            this.printRefreshBttn.UseVisualStyleBackColor = true;
            // 
            // printerDBDataSet
            // 
            this.printerDBDataSet.DataSetName = "PrinterDBDataSet";
            this.printerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printersBindingSource
            // 
            this.printersBindingSource.DataMember = "Printers";
            this.printersBindingSource.DataSource = this.printerDBDataSet;
            // 
            // printersTableAdapter
            // 
            this.printersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = InventoryDBWinFrm.PrinterDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printerInvIDNumDataGridViewTextBoxColumn
            // 
            this.printerInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "printerInvIDNum";
            this.printerInvIDNumDataGridViewTextBoxColumn.HeaderText = "printerInvIDNum";
            this.printerInvIDNumDataGridViewTextBoxColumn.Name = "printerInvIDNumDataGridViewTextBoxColumn";
            this.printerInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printerMakeDataGridViewTextBoxColumn
            // 
            this.printerMakeDataGridViewTextBoxColumn.DataPropertyName = "printerMake";
            this.printerMakeDataGridViewTextBoxColumn.HeaderText = "printerMake";
            this.printerMakeDataGridViewTextBoxColumn.Name = "printerMakeDataGridViewTextBoxColumn";
            // 
            // printerModelDataGridViewTextBoxColumn
            // 
            this.printerModelDataGridViewTextBoxColumn.DataPropertyName = "printerModel";
            this.printerModelDataGridViewTextBoxColumn.HeaderText = "printerModel";
            this.printerModelDataGridViewTextBoxColumn.Name = "printerModelDataGridViewTextBoxColumn";
            // 
            // printerSerNumDataGridViewTextBoxColumn
            // 
            this.printerSerNumDataGridViewTextBoxColumn.DataPropertyName = "printerSerNum";
            this.printerSerNumDataGridViewTextBoxColumn.HeaderText = "printerSerNum";
            this.printerSerNumDataGridViewTextBoxColumn.Name = "printerSerNumDataGridViewTextBoxColumn";
            // 
            // printerTypeDataGridViewTextBoxColumn
            // 
            this.printerTypeDataGridViewTextBoxColumn.DataPropertyName = "printerType";
            this.printerTypeDataGridViewTextBoxColumn.HeaderText = "printerType";
            this.printerTypeDataGridViewTextBoxColumn.Name = "printerTypeDataGridViewTextBoxColumn";
            // 
            // printerCartNumDataGridViewTextBoxColumn
            // 
            this.printerCartNumDataGridViewTextBoxColumn.DataPropertyName = "printerCartNum";
            this.printerCartNumDataGridViewTextBoxColumn.HeaderText = "printerCartNum";
            this.printerCartNumDataGridViewTextBoxColumn.Name = "printerCartNumDataGridViewTextBoxColumn";
            // 
            // printerLocationDataGridViewTextBoxColumn
            // 
            this.printerLocationDataGridViewTextBoxColumn.DataPropertyName = "printerLocation";
            this.printerLocationDataGridViewTextBoxColumn.HeaderText = "printerLocation";
            this.printerLocationDataGridViewTextBoxColumn.Name = "printerLocationDataGridViewTextBoxColumn";
            // 
            // PrinterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 556);
            this.Controls.Add(this.printerBodyPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrinterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer Database Form";
            this.Load += new System.EventHandler(this.PrinterFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.printerBodyPnl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.printInputTab.ResumeLayout(false);
            this.printInputTab.PerformLayout();
            this.printViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label printerHeadTitleLbl;
        private System.Windows.Forms.Label printerHeadLbl;
        private System.Windows.Forms.Panel printerBodyPnl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage printInputTab;
        private System.Windows.Forms.TabPage printViewTab;
        private System.Windows.Forms.Label printLocationLbl;
        private System.Windows.Forms.Label printCartNumLbl;
        private System.Windows.Forms.Label printTypeLbl;
        private System.Windows.Forms.Label printSerNumLbl;
        private System.Windows.Forms.Label printModelLbl;
        private System.Windows.Forms.Label printMakeLbl;
        private System.Windows.Forms.TextBox printerLocationTxtBx;
        private System.Windows.Forms.TextBox printerCartNumTxtBx;
        private System.Windows.Forms.TextBox printerTypeTxtBx;
        private System.Windows.Forms.TextBox printerSerNumTxtBx;
        private System.Windows.Forms.TextBox printerModelTxtBx;
        private System.Windows.Forms.TextBox printerMakeTxtBx;
        private System.Windows.Forms.Button printExitBttn;
        private System.Windows.Forms.Button printClearBttn;
        private System.Windows.Forms.Button printSaveBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printRefreshBttn;
        private PrinterDBDataSet printerDBDataSet;
        private System.Windows.Forms.BindingSource printersBindingSource;
        private PrinterDBDataSetTableAdapters.PrintersTableAdapter printersTableAdapter;
        private PrinterDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerCartNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerLocationDataGridViewTextBoxColumn;
    }
}