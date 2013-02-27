namespace GLT.SqlCopy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlCatalog = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.ddlAuthType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.rbVer35 = new System.Windows.Forms.RadioButton();
            this.rbVer3 = new System.Windows.Forms.RadioButton();
            this.cbEncryptDb = new System.Windows.Forms.CheckBox();
            this.tbMobileDestPassword = new System.Windows.Forms.TextBox();
            this.tbMobileDestLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.tbDestPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDestPassword = new System.Windows.Forms.TextBox();
            this.tbDestLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlDestAuthType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDestServerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBeginCopy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSQLToSqlMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ServerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlCatalog);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.ddlAuthType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // ddlCatalog
            // 
            this.ddlCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCatalog.FormattingEnabled = true;
            this.ddlCatalog.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlCatalog.Location = new System.Drawing.Point(155, 164);
            this.ddlCatalog.Name = "ddlCatalog";
            this.ddlCatalog.Size = new System.Drawing.Size(247, 21);
            this.ddlCatalog.TabIndex = 9;
            this.ddlCatalog.DropDown += new System.EventHandler(this.ddlCatalog_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Catalog/Database:";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(256, 117);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(146, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.Enabled = false;
            this.tbLogin.Location = new System.Drawing.Point(256, 91);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(146, 20);
            this.tbLogin.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Location = new System.Drawing.Point(152, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Enabled = false;
            this.lblLogin.Location = new System.Drawing.Point(152, 91);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // ddlAuthType
            // 
            this.ddlAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAuthType.FormattingEnabled = true;
            this.ddlAuthType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlAuthType.Location = new System.Drawing.Point(155, 56);
            this.ddlAuthType.Name = "ddlAuthType";
            this.ddlAuthType.Size = new System.Drawing.Size(247, 21);
            this.ddlAuthType.TabIndex = 3;
            this.ddlAuthType.SelectedIndexChanged += new System.EventHandler(this.ddlAuthType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authentication Type:";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(155, 20);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(247, 20);
            this.tbServerName.TabIndex = 1;
            this.tbServerName.Text = "pch0517\\sqlexpress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.ServerPanel);
            this.groupBox2.Location = new System.Drawing.Point(429, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.rbVer35);
            this.panel1.Controls.Add(this.rbVer3);
            this.panel1.Controls.Add(this.cbEncryptDb);
            this.panel1.Controls.Add(this.tbMobileDestPassword);
            this.panel1.Controls.Add(this.tbMobileDestLogin);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Controls.Add(this.tbDestPath);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(7, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 173);
            this.panel1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(121, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Output Version:";
            // 
            // rbVer35
            // 
            this.rbVer35.AutoSize = true;
            this.rbVer35.Location = new System.Drawing.Point(248, 140);
            this.rbVer35.Name = "rbVer35";
            this.rbVer35.Size = new System.Drawing.Size(98, 17);
            this.rbVer35.TabIndex = 24;
            this.rbVer35.Text = "SQL Mobile 3.5";
            this.rbVer35.UseVisualStyleBackColor = true;
            // 
            // rbVer3
            // 
            this.rbVer3.AutoSize = true;
            this.rbVer3.Checked = true;
            this.rbVer3.Location = new System.Drawing.Point(124, 140);
            this.rbVer3.Name = "rbVer3";
            this.rbVer3.Size = new System.Drawing.Size(98, 17);
            this.rbVer3.TabIndex = 23;
            this.rbVer3.TabStop = true;
            this.rbVer3.Text = "SQL Mobile 3.0";
            this.rbVer3.UseVisualStyleBackColor = true;
            // 
            // cbEncryptDb
            // 
            this.cbEncryptDb.AutoSize = true;
            this.cbEncryptDb.Location = new System.Drawing.Point(124, 102);
            this.cbEncryptDb.Name = "cbEncryptDb";
            this.cbEncryptDb.Size = new System.Drawing.Size(117, 17);
            this.cbEncryptDb.TabIndex = 22;
            this.cbEncryptDb.Text = "Encrypt Database?";
            this.cbEncryptDb.UseVisualStyleBackColor = true;
            // 
            // tbMobileDestPassword
            // 
            this.tbMobileDestPassword.Location = new System.Drawing.Point(225, 65);
            this.tbMobileDestPassword.Name = "tbMobileDestPassword";
            this.tbMobileDestPassword.PasswordChar = '*';
            this.tbMobileDestPassword.Size = new System.Drawing.Size(146, 20);
            this.tbMobileDestPassword.TabIndex = 21;
            // 
            // tbMobileDestLogin
            // 
            this.tbMobileDestLogin.Location = new System.Drawing.Point(225, 39);
            this.tbMobileDestLogin.Name = "tbMobileDestLogin";
            this.tbMobileDestLogin.Size = new System.Drawing.Size(146, 20);
            this.tbMobileDestLogin.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Login:";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(372, 2);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(24, 23);
            this.btnSelectPath.TabIndex = 14;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // tbDestPath
            // 
            this.tbDestPath.Location = new System.Drawing.Point(124, 3);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(247, 20);
            this.tbDestPath.TabIndex = 13;
            this.tbDestPath.Text = "C:\\Documents and Settings\\e14276\\My Documents\\test.sdf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Database Path:";
            // 
            // ServerPanel
            // 
            this.ServerPanel.Controls.Add(this.comboBox1);
            this.ServerPanel.Controls.Add(this.label3);
            this.ServerPanel.Controls.Add(this.tbDestPassword);
            this.ServerPanel.Controls.Add(this.tbDestLogin);
            this.ServerPanel.Controls.Add(this.label4);
            this.ServerPanel.Controls.Add(this.label6);
            this.ServerPanel.Controls.Add(this.ddlDestAuthType);
            this.ServerPanel.Controls.Add(this.label7);
            this.ServerPanel.Controls.Add(this.tbDestServerName);
            this.ServerPanel.Controls.Add(this.label8);
            this.ServerPanel.Location = new System.Drawing.Point(7, 19);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(399, 173);
            this.ServerPanel.TabIndex = 10;
            this.ServerPanel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBox1.Location = new System.Drawing.Point(150, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Catalog/Database:";
            // 
            // tbDestPassword
            // 
            this.tbDestPassword.Enabled = false;
            this.tbDestPassword.Location = new System.Drawing.Point(251, 100);
            this.tbDestPassword.Name = "tbDestPassword";
            this.tbDestPassword.PasswordChar = '*';
            this.tbDestPassword.Size = new System.Drawing.Size(146, 20);
            this.tbDestPassword.TabIndex = 17;
            // 
            // tbDestLogin
            // 
            this.tbDestLogin.Enabled = false;
            this.tbDestLogin.Location = new System.Drawing.Point(251, 74);
            this.tbDestLogin.Name = "tbDestLogin";
            this.tbDestLogin.Size = new System.Drawing.Size(146, 20);
            this.tbDestLogin.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(147, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(147, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Login:";
            // 
            // ddlDestAuthType
            // 
            this.ddlDestAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDestAuthType.FormattingEnabled = true;
            this.ddlDestAuthType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlDestAuthType.Location = new System.Drawing.Point(150, 39);
            this.ddlDestAuthType.Name = "ddlDestAuthType";
            this.ddlDestAuthType.Size = new System.Drawing.Size(247, 21);
            this.ddlDestAuthType.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Authentication Type:";
            // 
            // tbDestServerName
            // 
            this.tbDestServerName.Location = new System.Drawing.Point(150, 3);
            this.tbDestServerName.Name = "tbDestServerName";
            this.tbDestServerName.Size = new System.Drawing.Size(247, 20);
            this.tbDestServerName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Server Name:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "sdf";
            this.saveFileDialog1.Filter = "Mobile SQL Database |*.sdf|All files|*.*";
            // 
            // btnBeginCopy
            // 
            this.btnBeginCopy.Location = new System.Drawing.Point(684, 250);
            this.btnBeginCopy.Name = "btnBeginCopy";
            this.btnBeginCopy.Size = new System.Drawing.Size(75, 23);
            this.btnBeginCopy.TabIndex = 2;
            this.btnBeginCopy.Text = "Begin Copy";
            this.btnBeginCopy.UseVisualStyleBackColor = true;
            this.btnBeginCopy.Click += new System.EventHandler(this.btnBeginCopy_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSQLToSqlMobileToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSQLToSqlMobileToolStripMenuItem
            // 
            this.aboutSQLToSqlMobileToolStripMenuItem.Name = "aboutSQLToSqlMobileToolStripMenuItem";
            this.aboutSQLToSqlMobileToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.aboutSQLToSqlMobileToolStripMenuItem.Text = "About SQL Server to SQL Server Compact Edition";
            this.aboutSQLToSqlMobileToolStripMenuItem.Click += new System.EventHandler(this.aboutSQLToSqlMobileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 314);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBeginCopy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SQL Server to SQL Server Compact Edition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ServerPanel.ResumeLayout(false);
            this.ServerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlAuthType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox ddlCatalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDestPassword;
        private System.Windows.Forms.TextBox tbDestLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlDestAuthType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDestServerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox tbDestPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbEncryptDb;
        private System.Windows.Forms.TextBox tbMobileDestPassword;
        private System.Windows.Forms.TextBox tbMobileDestLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBeginCopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbVer35;
        private System.Windows.Forms.RadioButton rbVer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSQLToSqlMobileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

