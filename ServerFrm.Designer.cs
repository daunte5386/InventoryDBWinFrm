namespace InventoryDBWinFrm
{
    partial class ServerFrm
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
            this.servHeadPnl = new System.Windows.Forms.Panel();
            this.servHeadLbl = new System.Windows.Forms.Label();
            this.servHeadTitleLbl = new System.Windows.Forms.Label();
            this.servBodyPnl = new System.Windows.Forms.Panel();
            this.servTabCntl = new System.Windows.Forms.TabControl();
            this.servInputTab = new System.Windows.Forms.TabPage();
            this.servViewTab = new System.Windows.Forms.TabPage();
            this.servMakeLbl = new System.Windows.Forms.Label();
            this.servMakeTxtBx = new System.Windows.Forms.TextBox();
            this.servModelLbl = new System.Windows.Forms.Label();
            this.servModelTxtBx = new System.Windows.Forms.TextBox();
            this.servSerNumLbl = new System.Windows.Forms.Label();
            this.servSerNumTxtBx = new System.Windows.Forms.TextBox();
            this.servProcLbl = new System.Windows.Forms.Label();
            this.servProcTxtBx = new System.Windows.Forms.TextBox();
            this.servProcSpeedLbl = new System.Windows.Forms.Label();
            this.servProcSpeedTxtBx = new System.Windows.Forms.TextBox();
            this.servRAMLbl = new System.Windows.Forms.Label();
            this.servRAMTxtBx = new System.Windows.Forms.TextBox();
            this.servOSLbl = new System.Windows.Forms.Label();
            this.servOSTxtBx = new System.Windows.Forms.TextBox();
            this.servOSBitTypeLbl = new System.Windows.Forms.Label();
            this.servOSBitTypeTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDLbl = new System.Windows.Forms.Label();
            this.servHDDTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDRaidTypeLbl = new System.Windows.Forms.Label();
            this.servHDDRaidTypeTxtBx = new System.Windows.Forms.TextBox();
            this.servHDDCapLbl = new System.Windows.Forms.Label();
            this.servHDDCapTxtBx = new System.Windows.Forms.TextBox();
            this.servVirtualLbl = new System.Windows.Forms.Label();
            this.servVirtTxtBx = new System.Windows.Forms.TextBox();
            this.servLocationLbl = new System.Windows.Forms.Label();
            this.servLocationTxtBx = new System.Windows.Forms.TextBox();
            this.servExitBttn = new System.Windows.Forms.Button();
            this.servClearBttn = new System.Windows.Forms.Button();
            this.servSaveBttn = new System.Windows.Forms.Button();
            this.servRefreshBttn = new System.Windows.Forms.Button();
            this.servHeadPnl.SuspendLayout();
            this.servBodyPnl.SuspendLayout();
            this.servTabCntl.SuspendLayout();
            this.servInputTab.SuspendLayout();
            this.servViewTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // servHeadPnl
            // 
            this.servHeadPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servHeadPnl.Controls.Add(this.servHeadTitleLbl);
            this.servHeadPnl.Controls.Add(this.servHeadLbl);
            this.servHeadPnl.Location = new System.Drawing.Point(12, 12);
            this.servHeadPnl.Name = "servHeadPnl";
            this.servHeadPnl.Size = new System.Drawing.Size(788, 100);
            this.servHeadPnl.TabIndex = 0;
            // 
            // servHeadLbl
            // 
            this.servHeadLbl.AutoSize = true;
            this.servHeadLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHeadLbl.Location = new System.Drawing.Point(31, 10);
            this.servHeadLbl.Name = "servHeadLbl";
            this.servHeadLbl.Size = new System.Drawing.Size(713, 36);
            this.servHeadLbl.TabIndex = 0;
            this.servHeadLbl.Text = "The Information Technology Inventory Application";
            // 
            // servHeadTitleLbl
            // 
            this.servHeadTitleLbl.AutoSize = true;
            this.servHeadTitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHeadTitleLbl.Location = new System.Drawing.Point(330, 55);
            this.servHeadTitleLbl.Name = "servHeadTitleLbl";
            this.servHeadTitleLbl.Size = new System.Drawing.Size(136, 26);
            this.servHeadTitleLbl.TabIndex = 1;
            this.servHeadTitleLbl.Text = "Server Page";
            // 
            // servBodyPnl
            // 
            this.servBodyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servBodyPnl.Controls.Add(this.servTabCntl);
            this.servBodyPnl.Location = new System.Drawing.Point(12, 118);
            this.servBodyPnl.Name = "servBodyPnl";
            this.servBodyPnl.Size = new System.Drawing.Size(788, 612);
            this.servBodyPnl.TabIndex = 1;
            // 
            // servTabCntl
            // 
            this.servTabCntl.Controls.Add(this.servInputTab);
            this.servTabCntl.Controls.Add(this.servViewTab);
            this.servTabCntl.Location = new System.Drawing.Point(3, 3);
            this.servTabCntl.Name = "servTabCntl";
            this.servTabCntl.SelectedIndex = 0;
            this.servTabCntl.Size = new System.Drawing.Size(778, 602);
            this.servTabCntl.TabIndex = 0;
            // 
            // servInputTab
            // 
            this.servInputTab.Controls.Add(this.servSaveBttn);
            this.servInputTab.Controls.Add(this.servClearBttn);
            this.servInputTab.Controls.Add(this.servExitBttn);
            this.servInputTab.Controls.Add(this.servLocationTxtBx);
            this.servInputTab.Controls.Add(this.servLocationLbl);
            this.servInputTab.Controls.Add(this.servVirtTxtBx);
            this.servInputTab.Controls.Add(this.servVirtualLbl);
            this.servInputTab.Controls.Add(this.servHDDCapTxtBx);
            this.servInputTab.Controls.Add(this.servHDDCapLbl);
            this.servInputTab.Controls.Add(this.servHDDRaidTypeTxtBx);
            this.servInputTab.Controls.Add(this.servHDDRaidTypeLbl);
            this.servInputTab.Controls.Add(this.servHDDTxtBx);
            this.servInputTab.Controls.Add(this.servHDDLbl);
            this.servInputTab.Controls.Add(this.servOSBitTypeTxtBx);
            this.servInputTab.Controls.Add(this.servOSBitTypeLbl);
            this.servInputTab.Controls.Add(this.servOSTxtBx);
            this.servInputTab.Controls.Add(this.servOSLbl);
            this.servInputTab.Controls.Add(this.servRAMTxtBx);
            this.servInputTab.Controls.Add(this.servRAMLbl);
            this.servInputTab.Controls.Add(this.servProcSpeedTxtBx);
            this.servInputTab.Controls.Add(this.servProcSpeedLbl);
            this.servInputTab.Controls.Add(this.servProcTxtBx);
            this.servInputTab.Controls.Add(this.servProcLbl);
            this.servInputTab.Controls.Add(this.servSerNumTxtBx);
            this.servInputTab.Controls.Add(this.servSerNumLbl);
            this.servInputTab.Controls.Add(this.servModelTxtBx);
            this.servInputTab.Controls.Add(this.servModelLbl);
            this.servInputTab.Controls.Add(this.servMakeTxtBx);
            this.servInputTab.Controls.Add(this.servMakeLbl);
            this.servInputTab.Location = new System.Drawing.Point(4, 22);
            this.servInputTab.Name = "servInputTab";
            this.servInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.servInputTab.Size = new System.Drawing.Size(770, 576);
            this.servInputTab.TabIndex = 0;
            this.servInputTab.Text = "Server Input";
            this.servInputTab.UseVisualStyleBackColor = true;
            // 
            // servViewTab
            // 
            this.servViewTab.Controls.Add(this.servRefreshBttn);
            this.servViewTab.Location = new System.Drawing.Point(4, 22);
            this.servViewTab.Name = "servViewTab";
            this.servViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.servViewTab.Size = new System.Drawing.Size(770, 576);
            this.servViewTab.TabIndex = 1;
            this.servViewTab.Text = "Server View";
            this.servViewTab.UseVisualStyleBackColor = true;
            // 
            // servMakeLbl
            // 
            this.servMakeLbl.AutoSize = true;
            this.servMakeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servMakeLbl.Location = new System.Drawing.Point(269, 31);
            this.servMakeLbl.Name = "servMakeLbl";
            this.servMakeLbl.Size = new System.Drawing.Size(104, 19);
            this.servMakeLbl.TabIndex = 16;
            this.servMakeLbl.Text = "Server Make:";
            // 
            // servMakeTxtBx
            // 
            this.servMakeTxtBx.Location = new System.Drawing.Point(379, 32);
            this.servMakeTxtBx.Name = "servMakeTxtBx";
            this.servMakeTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servMakeTxtBx.TabIndex = 0;
            // 
            // servModelLbl
            // 
            this.servModelLbl.AutoSize = true;
            this.servModelLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servModelLbl.Location = new System.Drawing.Point(266, 75);
            this.servModelLbl.Name = "servModelLbl";
            this.servModelLbl.Size = new System.Drawing.Size(107, 19);
            this.servModelLbl.TabIndex = 17;
            this.servModelLbl.Text = "Server Model:";
            // 
            // servModelTxtBx
            // 
            this.servModelTxtBx.Location = new System.Drawing.Point(379, 76);
            this.servModelTxtBx.Name = "servModelTxtBx";
            this.servModelTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servModelTxtBx.TabIndex = 1;
            // 
            // servSerNumLbl
            // 
            this.servSerNumLbl.AutoSize = true;
            this.servSerNumLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servSerNumLbl.Location = new System.Drawing.Point(213, 118);
            this.servSerNumLbl.Name = "servSerNumLbl";
            this.servSerNumLbl.Size = new System.Drawing.Size(160, 19);
            this.servSerNumLbl.TabIndex = 18;
            this.servSerNumLbl.Text = "Server Serial Number:";
            // 
            // servSerNumTxtBx
            // 
            this.servSerNumTxtBx.Location = new System.Drawing.Point(379, 119);
            this.servSerNumTxtBx.Name = "servSerNumTxtBx";
            this.servSerNumTxtBx.Size = new System.Drawing.Size(190, 20);
            this.servSerNumTxtBx.TabIndex = 2;
            // 
            // servProcLbl
            // 
            this.servProcLbl.AutoSize = true;
            this.servProcLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servProcLbl.Location = new System.Drawing.Point(244, 160);
            this.servProcLbl.Name = "servProcLbl";
            this.servProcLbl.Size = new System.Drawing.Size(129, 19);
            this.servProcLbl.TabIndex = 19;
            this.servProcLbl.Text = "Server Processor:";
            // 
            // servProcTxtBx
            // 
            this.servProcTxtBx.Location = new System.Drawing.Point(379, 161);
            this.servProcTxtBx.Name = "servProcTxtBx";
            this.servProcTxtBx.Size = new System.Drawing.Size(152, 20);
            this.servProcTxtBx.TabIndex = 3;
            // 
            // servProcSpeedLbl
            // 
            this.servProcSpeedLbl.AutoSize = true;
            this.servProcSpeedLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servProcSpeedLbl.Location = new System.Drawing.Point(199, 205);
            this.servProcSpeedLbl.Name = "servProcSpeedLbl";
            this.servProcSpeedLbl.Size = new System.Drawing.Size(174, 19);
            this.servProcSpeedLbl.TabIndex = 20;
            this.servProcSpeedLbl.Text = "Server Processor Speed:";
            // 
            // servProcSpeedTxtBx
            // 
            this.servProcSpeedTxtBx.Location = new System.Drawing.Point(379, 206);
            this.servProcSpeedTxtBx.Name = "servProcSpeedTxtBx";
            this.servProcSpeedTxtBx.Size = new System.Drawing.Size(152, 20);
            this.servProcSpeedTxtBx.TabIndex = 4;
            // 
            // servRAMLbl
            // 
            this.servRAMLbl.AutoSize = true;
            this.servRAMLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servRAMLbl.Location = new System.Drawing.Point(271, 242);
            this.servRAMLbl.Name = "servRAMLbl";
            this.servRAMLbl.Size = new System.Drawing.Size(102, 19);
            this.servRAMLbl.TabIndex = 21;
            this.servRAMLbl.Text = "Server RAM:";
            // 
            // servRAMTxtBx
            // 
            this.servRAMTxtBx.Location = new System.Drawing.Point(379, 243);
            this.servRAMTxtBx.Name = "servRAMTxtBx";
            this.servRAMTxtBx.Size = new System.Drawing.Size(70, 20);
            this.servRAMTxtBx.TabIndex = 5;
            // 
            // servOSLbl
            // 
            this.servOSLbl.AutoSize = true;
            this.servOSLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servOSLbl.Location = new System.Drawing.Point(190, 282);
            this.servOSLbl.Name = "servOSLbl";
            this.servOSLbl.Size = new System.Drawing.Size(183, 19);
            this.servOSLbl.TabIndex = 22;
            this.servOSLbl.Text = "Server Operating System:";
            // 
            // servOSTxtBx
            // 
            this.servOSTxtBx.Location = new System.Drawing.Point(379, 283);
            this.servOSTxtBx.Name = "servOSTxtBx";
            this.servOSTxtBx.Size = new System.Drawing.Size(70, 20);
            this.servOSTxtBx.TabIndex = 6;
            // 
            // servOSBitTypeLbl
            // 
            this.servOSBitTypeLbl.AutoSize = true;
            this.servOSBitTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servOSBitTypeLbl.Location = new System.Drawing.Point(129, 319);
            this.servOSBitTypeLbl.Name = "servOSBitTypeLbl";
            this.servOSBitTypeLbl.Size = new System.Drawing.Size(244, 19);
            this.servOSBitTypeLbl.TabIndex = 23;
            this.servOSBitTypeLbl.Text = "Server Operating System Bit Type:";
            // 
            // servOSBitTypeTxtBx
            // 
            this.servOSBitTypeTxtBx.Location = new System.Drawing.Point(379, 320);
            this.servOSBitTypeTxtBx.Name = "servOSBitTypeTxtBx";
            this.servOSBitTypeTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servOSBitTypeTxtBx.TabIndex = 7;
            // 
            // servHDDLbl
            // 
            this.servHDDLbl.AutoSize = true;
            this.servHDDLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHDDLbl.Location = new System.Drawing.Point(274, 360);
            this.servHDDLbl.Name = "servHDDLbl";
            this.servHDDLbl.Size = new System.Drawing.Size(99, 19);
            this.servHDDLbl.TabIndex = 24;
            this.servHDDLbl.Text = "Server HDD:";
            // 
            // servHDDTxtBx
            // 
            this.servHDDTxtBx.Location = new System.Drawing.Point(379, 361);
            this.servHDDTxtBx.Name = "servHDDTxtBx";
            this.servHDDTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servHDDTxtBx.TabIndex = 8;
            // 
            // servHDDRaidTypeLbl
            // 
            this.servHDDRaidTypeLbl.AutoSize = true;
            this.servHDDRaidTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHDDRaidTypeLbl.Location = new System.Drawing.Point(201, 400);
            this.servHDDRaidTypeLbl.Name = "servHDDRaidTypeLbl";
            this.servHDDRaidTypeLbl.Size = new System.Drawing.Size(172, 19);
            this.servHDDRaidTypeLbl.TabIndex = 25;
            this.servHDDRaidTypeLbl.Text = "Server HDD Raid Type:";
            // 
            // servHDDRaidTypeTxtBx
            // 
            this.servHDDRaidTypeTxtBx.Location = new System.Drawing.Point(379, 401);
            this.servHDDRaidTypeTxtBx.Name = "servHDDRaidTypeTxtBx";
            this.servHDDRaidTypeTxtBx.Size = new System.Drawing.Size(124, 20);
            this.servHDDRaidTypeTxtBx.TabIndex = 9;
            // 
            // servHDDCapLbl
            // 
            this.servHDDCapLbl.AutoSize = true;
            this.servHDDCapLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servHDDCapLbl.Location = new System.Drawing.Point(211, 442);
            this.servHDDCapLbl.Name = "servHDDCapLbl";
            this.servHDDCapLbl.Size = new System.Drawing.Size(162, 19);
            this.servHDDCapLbl.TabIndex = 26;
            this.servHDDCapLbl.Text = "Server HDD Capacity:";
            // 
            // servHDDCapTxtBx
            // 
            this.servHDDCapTxtBx.Location = new System.Drawing.Point(379, 443);
            this.servHDDCapTxtBx.Name = "servHDDCapTxtBx";
            this.servHDDCapTxtBx.Size = new System.Drawing.Size(100, 20);
            this.servHDDCapTxtBx.TabIndex = 10;
            // 
            // servVirtualLbl
            // 
            this.servVirtualLbl.AutoSize = true;
            this.servVirtualLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servVirtualLbl.Location = new System.Drawing.Point(265, 481);
            this.servVirtualLbl.Name = "servVirtualLbl";
            this.servVirtualLbl.Size = new System.Drawing.Size(108, 19);
            this.servVirtualLbl.TabIndex = 27;
            this.servVirtualLbl.Text = "Server Virtual:";
            // 
            // servVirtTxtBx
            // 
            this.servVirtTxtBx.Location = new System.Drawing.Point(379, 482);
            this.servVirtTxtBx.Name = "servVirtTxtBx";
            this.servVirtTxtBx.Size = new System.Drawing.Size(100, 20);
            this.servVirtTxtBx.TabIndex = 11;
            // 
            // servLocationLbl
            // 
            this.servLocationLbl.AutoSize = true;
            this.servLocationLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servLocationLbl.Location = new System.Drawing.Point(252, 522);
            this.servLocationLbl.Name = "servLocationLbl";
            this.servLocationLbl.Size = new System.Drawing.Size(121, 19);
            this.servLocationLbl.TabIndex = 28;
            this.servLocationLbl.Text = "Server Location:";
            // 
            // servLocationTxtBx
            // 
            this.servLocationTxtBx.Location = new System.Drawing.Point(379, 523);
            this.servLocationTxtBx.Name = "servLocationTxtBx";
            this.servLocationTxtBx.Size = new System.Drawing.Size(358, 20);
            this.servLocationTxtBx.TabIndex = 12;
            // 
            // servExitBttn
            // 
            this.servExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servExitBttn.Location = new System.Drawing.Point(685, 549);
            this.servExitBttn.Name = "servExitBttn";
            this.servExitBttn.Size = new System.Drawing.Size(75, 23);
            this.servExitBttn.TabIndex = 15;
            this.servExitBttn.Text = "Exit";
            this.servExitBttn.UseVisualStyleBackColor = true;
            this.servExitBttn.Click += new System.EventHandler(this.servExitBttn_Click);
            // 
            // servClearBttn
            // 
            this.servClearBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servClearBttn.Location = new System.Drawing.Point(581, 549);
            this.servClearBttn.Name = "servClearBttn";
            this.servClearBttn.Size = new System.Drawing.Size(75, 23);
            this.servClearBttn.TabIndex = 14;
            this.servClearBttn.Text = "Clear";
            this.servClearBttn.UseVisualStyleBackColor = true;
            this.servClearBttn.Click += new System.EventHandler(this.servClearBttn_Click);
            // 
            // servSaveBttn
            // 
            this.servSaveBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servSaveBttn.Location = new System.Drawing.Point(476, 549);
            this.servSaveBttn.Name = "servSaveBttn";
            this.servSaveBttn.Size = new System.Drawing.Size(75, 23);
            this.servSaveBttn.TabIndex = 13;
            this.servSaveBttn.Text = "Save";
            this.servSaveBttn.UseVisualStyleBackColor = true;
            this.servSaveBttn.Click += new System.EventHandler(this.servSaveBttn_Click);
            // 
            // servRefreshBttn
            // 
            this.servRefreshBttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servRefreshBttn.Location = new System.Drawing.Point(685, 549);
            this.servRefreshBttn.Name = "servRefreshBttn";
            this.servRefreshBttn.Size = new System.Drawing.Size(75, 23);
            this.servRefreshBttn.TabIndex = 0;
            this.servRefreshBttn.Text = "Refresh";
            this.servRefreshBttn.UseVisualStyleBackColor = true;
            // 
            // ServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 742);
            this.Controls.Add(this.servBodyPnl);
            this.Controls.Add(this.servHeadPnl);
            this.Name = "ServerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Database Form";
            this.servHeadPnl.ResumeLayout(false);
            this.servHeadPnl.PerformLayout();
            this.servBodyPnl.ResumeLayout(false);
            this.servTabCntl.ResumeLayout(false);
            this.servInputTab.ResumeLayout(false);
            this.servInputTab.PerformLayout();
            this.servViewTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel servHeadPnl;
        private System.Windows.Forms.Label servHeadTitleLbl;
        private System.Windows.Forms.Label servHeadLbl;
        private System.Windows.Forms.Panel servBodyPnl;
        private System.Windows.Forms.TabControl servTabCntl;
        private System.Windows.Forms.TabPage servInputTab;
        private System.Windows.Forms.TextBox servProcTxtBx;
        private System.Windows.Forms.Label servProcLbl;
        private System.Windows.Forms.TextBox servSerNumTxtBx;
        private System.Windows.Forms.Label servSerNumLbl;
        private System.Windows.Forms.TextBox servModelTxtBx;
        private System.Windows.Forms.Label servModelLbl;
        private System.Windows.Forms.TextBox servMakeTxtBx;
        private System.Windows.Forms.Label servMakeLbl;
        private System.Windows.Forms.TabPage servViewTab;
        private System.Windows.Forms.TextBox servProcSpeedTxtBx;
        private System.Windows.Forms.Label servProcSpeedLbl;
        private System.Windows.Forms.TextBox servRAMTxtBx;
        private System.Windows.Forms.Label servRAMLbl;
        private System.Windows.Forms.TextBox servHDDTxtBx;
        private System.Windows.Forms.Label servHDDLbl;
        private System.Windows.Forms.TextBox servOSBitTypeTxtBx;
        private System.Windows.Forms.Label servOSBitTypeLbl;
        private System.Windows.Forms.TextBox servOSTxtBx;
        private System.Windows.Forms.Label servOSLbl;
        private System.Windows.Forms.Label servHDDRaidTypeLbl;
        private System.Windows.Forms.TextBox servHDDRaidTypeTxtBx;
        private System.Windows.Forms.Button servSaveBttn;
        private System.Windows.Forms.Button servClearBttn;
        private System.Windows.Forms.Button servExitBttn;
        private System.Windows.Forms.TextBox servLocationTxtBx;
        private System.Windows.Forms.Label servLocationLbl;
        private System.Windows.Forms.TextBox servVirtTxtBx;
        private System.Windows.Forms.Label servVirtualLbl;
        private System.Windows.Forms.TextBox servHDDCapTxtBx;
        private System.Windows.Forms.Label servHDDCapLbl;
        private System.Windows.Forms.Button servRefreshBttn;
    }
}