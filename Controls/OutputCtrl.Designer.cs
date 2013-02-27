namespace GLT.SqlCopy.Controls
{
    partial class OutputCtrl
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server Compact Database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Output Version:";
            // 
            // rbVer35
            // 
            this.rbVer35.AutoSize = true;
            this.rbVer35.Location = new System.Drawing.Point(113, 241);
            this.rbVer35.Name = "rbVer35";
            this.rbVer35.Size = new System.Drawing.Size(178, 17);
            this.rbVer35.TabIndex = 34;
            this.rbVer35.Text = "SQL Server Compact Edition 3.5";
            this.rbVer35.UseVisualStyleBackColor = true;
            // 
            // rbVer3
            // 
            this.rbVer3.AutoSize = true;
            this.rbVer3.Checked = true;
            this.rbVer3.Location = new System.Drawing.Point(113, 218);
            this.rbVer3.Name = "rbVer3";
            this.rbVer3.Size = new System.Drawing.Size(178, 17);
            this.rbVer3.TabIndex = 33;
            this.rbVer3.TabStop = true;
            this.rbVer3.Text = "SQL Server Compact Edition 3.1";
            this.rbVer3.UseVisualStyleBackColor = true;
            // 
            // cbEncryptDb
            // 
            this.cbEncryptDb.AutoSize = true;
            this.cbEncryptDb.Location = new System.Drawing.Point(214, 181);
            this.cbEncryptDb.Name = "cbEncryptDb";
            this.cbEncryptDb.Size = new System.Drawing.Size(117, 17);
            this.cbEncryptDb.TabIndex = 32;
            this.cbEncryptDb.Text = "Encrypt Database?";
            this.cbEncryptDb.UseVisualStyleBackColor = true;
            // 
            // tbMobileDestPassword
            // 
            this.tbMobileDestPassword.Location = new System.Drawing.Point(214, 155);
            this.tbMobileDestPassword.Name = "tbMobileDestPassword";
            this.tbMobileDestPassword.PasswordChar = '*';
            this.tbMobileDestPassword.Size = new System.Drawing.Size(146, 20);
            this.tbMobileDestPassword.TabIndex = 31;
            // 
            // tbMobileDestLogin
            // 
            this.tbMobileDestLogin.Location = new System.Drawing.Point(214, 129);
            this.tbMobileDestLogin.Name = "tbMobileDestLogin";
            this.tbMobileDestLogin.Size = new System.Drawing.Size(146, 20);
            this.tbMobileDestLogin.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Login:";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(361, 92);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(24, 23);
            this.btnSelectPath.TabIndex = 27;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // tbDestPath
            // 
            this.tbDestPath.Location = new System.Drawing.Point(113, 93);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(247, 20);
            this.tbDestPath.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Database Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter the following information for the destination database.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sdf";
            this.saveFileDialog1.Filter = "SQL Compact Database files|*.sdf|All Files|*.*";
            // 
            // OutputCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbVer35);
            this.Controls.Add(this.rbVer3);
            this.Controls.Add(this.cbEncryptDb);
            this.Controls.Add(this.tbMobileDestPassword);
            this.Controls.Add(this.tbMobileDestLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.tbDestPath);
            this.Controls.Add(this.label1);
            this.Name = "OutputCtrl";
            this.Size = new System.Drawing.Size(392, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbVer35;
        private System.Windows.Forms.RadioButton rbVer3;
        private System.Windows.Forms.CheckBox cbEncryptDb;
        private System.Windows.Forms.TextBox tbMobileDestPassword;
        private System.Windows.Forms.TextBox tbMobileDestLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox tbDestPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
