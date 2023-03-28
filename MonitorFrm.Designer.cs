namespace InventoryDBWinFrm
{
    partial class MonitorFrm
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
            this.monHeadPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monHeadLbl = new System.Windows.Forms.Label();
            this.monGridView = new System.Windows.Forms.Panel();
            this.monTabCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monExitBttn = new System.Windows.Forms.Button();
            this.monClearBttn = new System.Windows.Forms.Button();
            this.monSaveBttn = new System.Windows.Forms.Button();
            this.monLocationTxtBx = new System.Windows.Forms.TextBox();
            this.monTypeTxtBx = new System.Windows.Forms.TextBox();
            this.monSizeTxtBx = new System.Windows.Forms.TextBox();
            this.monSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.monModelTxtBx = new System.Windows.Forms.TextBox();
            this.monMakeTxtBx = new System.Windows.Forms.TextBox();
            this.monLocationLbl = new System.Windows.Forms.Label();
            this.monTypeLbl = new System.Windows.Forms.Label();
            this.monSizeLbl = new System.Windows.Forms.Label();
            this.monSerNumLbl = new System.Windows.Forms.Label();
            this.monModelLbl = new System.Windows.Forms.Label();
            this.monMakeLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monRefreshBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monitorInvIDNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorSerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitorDBDataSet = new InventoryDBWinFrm.MonitorDBDataSet();
            this.monitorsTableAdapter = new InventoryDBWinFrm.MonitorDBDataSetTableAdapters.MonitorsTableAdapter();
            this.tableAdapterManager = new InventoryDBWinFrm.MonitorDBDataSetTableAdapters.TableAdapterManager();
            this.monHeadPnl.SuspendLayout();
            this.monGridView.SuspendLayout();
            this.monTabCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monHeadPnl
            // 
            this.monHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monHeadPnl.Controls.Add(this.label2);
            this.monHeadPnl.Controls.Add(this.monHeadLbl);
            this.monHeadPnl.Location = new System.Drawing.Point(13, 13);
            this.monHeadPnl.Name = "monHeadPnl";
            this.monHeadPnl.Size = new System.Drawing.Size(783, 100);
            this.monHeadPnl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monitor Page";
            // 
            // monHeadLbl
            // 
            this.monHeadLbl.AutoSize = true;
            this.monHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHeadLbl.Location = new System.Drawing.Point(34, 16);
            this.monHeadLbl.Name = "monHeadLbl";
            this.monHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.monHeadLbl.TabIndex = 0;
            this.monHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // monGridView
            // 
            this.monGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monGridView.Controls.Add(this.monTabCntrl);
            this.monGridView.Location = new System.Drawing.Point(12, 119);
            this.monGridView.Name = "monGridView";
            this.monGridView.Size = new System.Drawing.Size(784, 416);
            this.monGridView.TabIndex = 1;
            // 
            // monTabCntrl
            // 
            this.monTabCntrl.Controls.Add(this.tabPage1);
            this.monTabCntrl.Controls.Add(this.tabPage2);
            this.monTabCntrl.Location = new System.Drawing.Point(3, 3);
            this.monTabCntrl.Name = "monTabCntrl";
            this.monTabCntrl.SelectedIndex = 0;
            this.monTabCntrl.Size = new System.Drawing.Size(774, 406);
            this.monTabCntrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.monExitBttn);
            this.tabPage1.Controls.Add(this.monClearBttn);
            this.tabPage1.Controls.Add(this.monSaveBttn);
            this.tabPage1.Controls.Add(this.monLocationTxtBx);
            this.tabPage1.Controls.Add(this.monTypeTxtBx);
            this.tabPage1.Controls.Add(this.monSizeTxtBx);
            this.tabPage1.Controls.Add(this.monSerNumTxtBx);
            this.tabPage1.Controls.Add(this.monModelTxtBx);
            this.tabPage1.Controls.Add(this.monMakeTxtBx);
            this.tabPage1.Controls.Add(this.monLocationLbl);
            this.tabPage1.Controls.Add(this.monTypeLbl);
            this.tabPage1.Controls.Add(this.monSizeLbl);
            this.tabPage1.Controls.Add(this.monSerNumLbl);
            this.tabPage1.Controls.Add(this.monModelLbl);
            this.tabPage1.Controls.Add(this.monMakeLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monExitBttn
            // 
            this.monExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monExitBttn.Location = new System.Drawing.Point(685, 351);
            this.monExitBttn.Name = "monExitBttn";
            this.monExitBttn.Size = new System.Drawing.Size(75, 23);
            this.monExitBttn.TabIndex = 14;
            this.monExitBttn.Text = "Exit";
            this.monExitBttn.UseVisualStyleBackColor = true;
            this.monExitBttn.Click += new System.EventHandler(this.monExitBttn_Click);
            // 
            // monClearBttn
            // 
            this.monClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monClearBttn.Location = new System.Drawing.Point(583, 351);
            this.monClearBttn.Name = "monClearBttn";
            this.monClearBttn.Size = new System.Drawing.Size(75, 23);
            this.monClearBttn.TabIndex = 13;
            this.monClearBttn.Text = "Clear";
            this.monClearBttn.UseVisualStyleBackColor = true;
            this.monClearBttn.Click += new System.EventHandler(this.monClearBttn_Click);
            // 
            // monSaveBttn
            // 
            this.monSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSaveBttn.Location = new System.Drawing.Point(482, 351);
            this.monSaveBttn.Name = "monSaveBttn";
            this.monSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.monSaveBttn.TabIndex = 12;
            this.monSaveBttn.Text = "Save";
            this.monSaveBttn.UseVisualStyleBackColor = true;
            this.monSaveBttn.Click += new System.EventHandler(this.monSaveBttn_Click);
            // 
            // monLocationTxtBx
            // 
            this.monLocationTxtBx.Location = new System.Drawing.Point(385, 293);
            this.monLocationTxtBx.Name = "monLocationTxtBx";
            this.monLocationTxtBx.Size = new System.Drawing.Size(345, 20);
            this.monLocationTxtBx.TabIndex = 5;
            // 
            // monTypeTxtBx
            // 
            this.monTypeTxtBx.Location = new System.Drawing.Point(385, 242);
            this.monTypeTxtBx.Name = "monTypeTxtBx";
            this.monTypeTxtBx.Size = new System.Drawing.Size(121, 20);
            this.monTypeTxtBx.TabIndex = 4;
            // 
            // monSizeTxtBx
            // 
            this.monSizeTxtBx.Location = new System.Drawing.Point(385, 192);
            this.monSizeTxtBx.Name = "monSizeTxtBx";
            this.monSizeTxtBx.Size = new System.Drawing.Size(72, 20);
            this.monSizeTxtBx.TabIndex = 3;
            // 
            // monSerNumTxtBx
            // 
            this.monSerNumTxtBx.Location = new System.Drawing.Point(385, 140);
            this.monSerNumTxtBx.Name = "monSerNumTxtBx";
            this.monSerNumTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monSerNumTxtBx.TabIndex = 2;
            // 
            // monModelTxtBx
            // 
            this.monModelTxtBx.Location = new System.Drawing.Point(385, 90);
            this.monModelTxtBx.Name = "monModelTxtBx";
            this.monModelTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monModelTxtBx.TabIndex = 1;
            // 
            // monMakeTxtBx
            // 
            this.monMakeTxtBx.Location = new System.Drawing.Point(385, 38);
            this.monMakeTxtBx.Name = "monMakeTxtBx";
            this.monMakeTxtBx.Size = new System.Drawing.Size(214, 20);
            this.monMakeTxtBx.TabIndex = 0;
            // 
            // monLocationLbl
            // 
            this.monLocationLbl.AutoSize = true;
            this.monLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monLocationLbl.Location = new System.Drawing.Point(248, 292);
            this.monLocationLbl.Name = "monLocationLbl";
            this.monLocationLbl.Size = new System.Drawing.Size(131, 19);
            this.monLocationLbl.TabIndex = 15;
            this.monLocationLbl.Text = "Monitor Location:";
            // 
            // monTypeLbl
            // 
            this.monTypeLbl.AutoSize = true;
            this.monTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monTypeLbl.Location = new System.Drawing.Point(273, 241);
            this.monTypeLbl.Name = "monTypeLbl";
            this.monTypeLbl.Size = new System.Drawing.Size(106, 19);
            this.monTypeLbl.TabIndex = 14;
            this.monTypeLbl.Text = "Monitor Type:";
            // 
            // monSizeLbl
            // 
            this.monSizeLbl.AutoSize = true;
            this.monSizeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSizeLbl.Location = new System.Drawing.Point(279, 191);
            this.monSizeLbl.Name = "monSizeLbl";
            this.monSizeLbl.Size = new System.Drawing.Size(100, 19);
            this.monSizeLbl.TabIndex = 13;
            this.monSizeLbl.Text = "Monitor Size:";
            // 
            // monSerNumLbl
            // 
            this.monSerNumLbl.AutoSize = true;
            this.monSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monSerNumLbl.Location = new System.Drawing.Point(209, 139);
            this.monSerNumLbl.Name = "monSerNumLbl";
            this.monSerNumLbl.Size = new System.Drawing.Size(170, 19);
            this.monSerNumLbl.TabIndex = 12;
            this.monSerNumLbl.Text = "Monitor Serial Number:";
            // 
            // monModelLbl
            // 
            this.monModelLbl.AutoSize = true;
            this.monModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monModelLbl.Location = new System.Drawing.Point(262, 89);
            this.monModelLbl.Name = "monModelLbl";
            this.monModelLbl.Size = new System.Drawing.Size(117, 19);
            this.monModelLbl.TabIndex = 10;
            this.monModelLbl.Text = "Monitor Model:";
            // 
            // monMakeLbl
            // 
            this.monMakeLbl.AutoSize = true;
            this.monMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monMakeLbl.Location = new System.Drawing.Point(269, 37);
            this.monMakeLbl.Name = "monMakeLbl";
            this.monMakeLbl.Size = new System.Drawing.Size(114, 19);
            this.monMakeLbl.TabIndex = 9;
            this.monMakeLbl.Text = "Monitor Make:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.monRefreshBttn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monitor View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // monRefreshBttn
            // 
            this.monRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monRefreshBttn.Location = new System.Drawing.Point(685, 351);
            this.monRefreshBttn.Name = "monRefreshBttn";
            this.monRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.monRefreshBttn.TabIndex = 0;
            this.monRefreshBttn.Text = "Refresh";
            this.monRefreshBttn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monitorInvIDNumDataGridViewTextBoxColumn,
            this.monitorMakeDataGridViewTextBoxColumn,
            this.monitorModelDataGridViewTextBoxColumn,
            this.monitorSerNumDataGridViewTextBoxColumn,
            this.monitorSizeDataGridViewTextBoxColumn,
            this.monitorTypeDataGridViewTextBoxColumn,
            this.monitorLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monitorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // monitorInvIDNumDataGridViewTextBoxColumn
            // 
            this.monitorInvIDNumDataGridViewTextBoxColumn.DataPropertyName = "monitorInvIDNum";
            this.monitorInvIDNumDataGridViewTextBoxColumn.HeaderText = "monitorInvIDNum";
            this.monitorInvIDNumDataGridViewTextBoxColumn.Name = "monitorInvIDNumDataGridViewTextBoxColumn";
            this.monitorInvIDNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorMakeDataGridViewTextBoxColumn
            // 
            this.monitorMakeDataGridViewTextBoxColumn.DataPropertyName = "monitorMake";
            this.monitorMakeDataGridViewTextBoxColumn.HeaderText = "monitorMake";
            this.monitorMakeDataGridViewTextBoxColumn.Name = "monitorMakeDataGridViewTextBoxColumn";
            // 
            // monitorModelDataGridViewTextBoxColumn
            // 
            this.monitorModelDataGridViewTextBoxColumn.DataPropertyName = "monitorModel";
            this.monitorModelDataGridViewTextBoxColumn.HeaderText = "monitorModel";
            this.monitorModelDataGridViewTextBoxColumn.Name = "monitorModelDataGridViewTextBoxColumn";
            // 
            // monitorSerNumDataGridViewTextBoxColumn
            // 
            this.monitorSerNumDataGridViewTextBoxColumn.DataPropertyName = "monitorSerNum";
            this.monitorSerNumDataGridViewTextBoxColumn.HeaderText = "monitorSerNum";
            this.monitorSerNumDataGridViewTextBoxColumn.Name = "monitorSerNumDataGridViewTextBoxColumn";
            // 
            // monitorSizeDataGridViewTextBoxColumn
            // 
            this.monitorSizeDataGridViewTextBoxColumn.DataPropertyName = "monitorSize";
            this.monitorSizeDataGridViewTextBoxColumn.HeaderText = "monitorSize";
            this.monitorSizeDataGridViewTextBoxColumn.Name = "monitorSizeDataGridViewTextBoxColumn";
            // 
            // monitorTypeDataGridViewTextBoxColumn
            // 
            this.monitorTypeDataGridViewTextBoxColumn.DataPropertyName = "monitorType";
            this.monitorTypeDataGridViewTextBoxColumn.HeaderText = "monitorType";
            this.monitorTypeDataGridViewTextBoxColumn.Name = "monitorTypeDataGridViewTextBoxColumn";
            // 
            // monitorLocationDataGridViewTextBoxColumn
            // 
            this.monitorLocationDataGridViewTextBoxColumn.DataPropertyName = "monitorLocation";
            this.monitorLocationDataGridViewTextBoxColumn.HeaderText = "monitorLocation";
            this.monitorLocationDataGridViewTextBoxColumn.Name = "monitorLocationDataGridViewTextBoxColumn";
            // 
            // monitorsBindingSource
            // 
            this.monitorsBindingSource.DataMember = "Monitors";
            this.monitorsBindingSource.DataSource = this.monitorDBDataSet;
            // 
            // monitorDBDataSet
            // 
            this.monitorDBDataSet.DataSetName = "MonitorDBDataSet";
            this.monitorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monitorsTableAdapter
            // 
            this.monitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = InventoryDBWinFrm.MonitorDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MonitorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.monGridView);
            this.Controls.Add(this.monHeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MonitorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Database Screen";
            this.monHeadPnl.ResumeLayout(false);
            this.monHeadPnl.PerformLayout();
            this.monGridView.ResumeLayout(false);
            this.monTabCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel monHeadPnl;
        private System.Windows.Forms.Panel monGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monHeadLbl;
        private System.Windows.Forms.TabControl monTabCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button monExitBttn;
        private System.Windows.Forms.Button monClearBttn;
        private System.Windows.Forms.Button monSaveBttn;
        private System.Windows.Forms.TextBox monLocationTxtBx;
        private System.Windows.Forms.TextBox monTypeTxtBx;
        private System.Windows.Forms.TextBox monSizeTxtBx;
        private System.Windows.Forms.TextBox monSerNumTxtBx;
        private System.Windows.Forms.TextBox monModelTxtBx;
        private System.Windows.Forms.TextBox monMakeTxtBx;
        private System.Windows.Forms.Label monLocationLbl;
        private System.Windows.Forms.Label monTypeLbl;
        private System.Windows.Forms.Label monSizeLbl;
        private System.Windows.Forms.Label monSerNumLbl;
        private System.Windows.Forms.Label monModelLbl;
        private System.Windows.Forms.Label monMakeLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button monRefreshBttn;
        private MonitorDBDataSet monitorDBDataSet;
        private System.Windows.Forms.BindingSource monitorsBindingSource;
        private MonitorDBDataSetTableAdapters.MonitorsTableAdapter monitorsTableAdapter;
        private MonitorDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorInvIDNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorSerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorLocationDataGridViewTextBoxColumn;
    }
}