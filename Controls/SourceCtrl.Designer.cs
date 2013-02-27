namespace GLT.SqlCopy.Controls
{
    partial class SourceCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlCatalog
            // 
            this.ddlCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCatalog.FormattingEnabled = true;
            this.ddlCatalog.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlCatalog.Location = new System.Drawing.Point(129, 206);
            this.ddlCatalog.Name = "ddlCatalog";
            this.ddlCatalog.Size = new System.Drawing.Size(247, 21);
            this.ddlCatalog.TabIndex = 19;
            this.ddlCatalog.DropDown += new System.EventHandler(this.ddlCatalog_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Catalog/Database:";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(230, 159);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(146, 20);
            this.tbPassword.TabIndex = 17;
            // 
            // tbLogin
            // 
            this.tbLogin.Enabled = false;
            this.tbLogin.Location = new System.Drawing.Point(230, 133);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(146, 20);
            this.tbLogin.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Location = new System.Drawing.Point(126, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Enabled = false;
            this.lblLogin.Location = new System.Drawing.Point(126, 133);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Login:";
            // 
            // ddlAuthType
            // 
            this.ddlAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAuthType.FormattingEnabled = true;
            this.ddlAuthType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.ddlAuthType.Location = new System.Drawing.Point(129, 98);
            this.ddlAuthType.Name = "ddlAuthType";
            this.ddlAuthType.Size = new System.Drawing.Size(247, 21);
            this.ddlAuthType.TabIndex = 13;
            this.ddlAuthType.SelectedIndexChanged += new System.EventHandler(this.ddlAuthType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Authentication Type:";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(129, 62);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(247, 20);
            this.tbServerName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select Source Database";
            // 
            // SourceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlCatalog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.ddlAuthType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.label1);
            this.Name = "SourceCtrl";
            this.Size = new System.Drawing.Size(392, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCatalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox ddlAuthType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
