namespace GLT.SqlCopy
{
    partial class WizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLabels = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.finishCtrl1 = new GLT.SqlCopy.FinishCtrl();
            this.summaryCtrl1 = new GLT.SqlCopy.Controls.SummaryCtrl();
            this.optionsCtrl1 = new GLT.SqlCopy.Controls.OptionsCtrl();
            this.tableCtrl1 = new GLT.SqlCopy.Controls.TableCtrl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.overviewCtrl1 = new GLT.SqlCopy.Controls.OverviewCtrl();
            this.outputCtrl1 = new GLT.SqlCopy.Controls.OutputCtrl();
            this.sourceCtrl1 = new GLT.SqlCopy.Controls.SourceCtrl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLabels.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 1);
            this.panel5.TabIndex = 3;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Location = new System.Drawing.Point(38, 31);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(434, 38);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Hello and welcome to the Wizard! This wizard steps you through the process of con" +
                "verting a SQL Server Database to a SQL Server Compact Edition Database.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to the SQL Server to SQL Server Compact Edition Wizard!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GLT.SqlCopy.Properties.Resources.SQL_Relationships;
            this.pictureBox1.Location = new System.Drawing.Point(532, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLabels
            // 
            this.pnlLabels.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlLabels.Controls.Add(this.linkLabel1);
            this.pnlLabels.Controls.Add(this.label1);
            this.pnlLabels.Controls.Add(this.lblFinish);
            this.pnlLabels.Controls.Add(this.lblSummary);
            this.pnlLabels.Controls.Add(this.lblOptions);
            this.pnlLabels.Controls.Add(this.lblOutput);
            this.pnlLabels.Controls.Add(this.lblTables);
            this.pnlLabels.Controls.Add(this.lblSource);
            this.pnlLabels.Controls.Add(this.lblOverview);
            this.pnlLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLabels.Location = new System.Drawing.Point(0, 74);
            this.pnlLabels.Name = "pnlLabels";
            this.pnlLabels.Size = new System.Drawing.Size(200, 323);
            this.pnlLabels.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(25, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.JohnnyCantCode.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brought to you by:";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(22, 216);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(183, 23);
            this.lblFinish.TabIndex = 6;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblSummary.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.White;
            this.lblSummary.Location = new System.Drawing.Point(22, 183);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(183, 23);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Summary && Review";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblOptions.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.White;
            this.lblOptions.Location = new System.Drawing.Point(22, 150);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(183, 23);
            this.lblOptions.TabIndex = 4;
            this.lblOptions.Text = "Options";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(22, 117);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(183, 23);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Destination Database";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTables
            // 
            this.lblTables.BackColor = System.Drawing.Color.Transparent;
            this.lblTables.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.ForeColor = System.Drawing.Color.White;
            this.lblTables.Location = new System.Drawing.Point(22, 84);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(183, 23);
            this.lblTables.TabIndex = 2;
            this.lblTables.Text = "Select Tables";
            this.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSource
            // 
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(22, 51);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(183, 23);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source Database";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOverview
            // 
            this.lblOverview.BackColor = System.Drawing.SystemColors.Control;
            this.lblOverview.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.ForeColor = System.Drawing.Color.Black;
            this.lblOverview.Location = new System.Drawing.Point(22, 18);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(183, 23);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Overview";
            this.lblOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnHelp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 55);
            this.panel3.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(66, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(147, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(309, 17);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.finishCtrl1);
            this.pnlContent.Controls.Add(this.summaryCtrl1);
            this.pnlContent.Controls.Add(this.optionsCtrl1);
            this.pnlContent.Controls.Add(this.tableCtrl1);
            this.pnlContent.Controls.Add(this.panel6);
            this.pnlContent.Controls.Add(this.overviewCtrl1);
            this.pnlContent.Controls.Add(this.outputCtrl1);
            this.pnlContent.Controls.Add(this.sourceCtrl1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 74);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(392, 268);
            this.pnlContent.TabIndex = 3;
            // 
            // finishCtrl1
            // 
            this.finishCtrl1.Location = new System.Drawing.Point(11, 18);
            this.finishCtrl1.Name = "finishCtrl1";
            this.finishCtrl1.Size = new System.Drawing.Size(211, 140);
            this.finishCtrl1.TabIndex = 7;
            // 
            // summaryCtrl1
            // 
            this.summaryCtrl1.Location = new System.Drawing.Point(27, 25);
            this.summaryCtrl1.Name = "summaryCtrl1";
            this.summaryCtrl1.Size = new System.Drawing.Size(235, 183);
            this.summaryCtrl1.TabIndex = 6;
            // 
            // optionsCtrl1
            // 
            this.optionsCtrl1.Location = new System.Drawing.Point(39, 25);
            this.optionsCtrl1.Name = "optionsCtrl1";
            this.optionsCtrl1.Size = new System.Drawing.Size(264, 217);
            this.optionsCtrl1.TabIndex = 5;
            // 
            // tableCtrl1
            // 
            this.tableCtrl1.Location = new System.Drawing.Point(89, 11);
            this.tableCtrl1.Name = "tableCtrl1";
            this.tableCtrl1.Size = new System.Drawing.Size(222, 167);
            this.tableCtrl1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 1);
            this.panel6.TabIndex = 0;
            // 
            // overviewCtrl1
            // 
            this.overviewCtrl1.Location = new System.Drawing.Point(39, 11);
            this.overviewCtrl1.Name = "overviewCtrl1";
            this.overviewCtrl1.Size = new System.Drawing.Size(321, 219);
            this.overviewCtrl1.TabIndex = 1;
            // 
            // outputCtrl1
            // 
            this.outputCtrl1.EnableVer31 = true;
            this.outputCtrl1.EnableVer35 = true;
            this.outputCtrl1.Location = new System.Drawing.Point(124, 25);
            this.outputCtrl1.Name = "outputCtrl1";
            this.outputCtrl1.Size = new System.Drawing.Size(203, 193);
            this.outputCtrl1.TabIndex = 4;
            // 
            // sourceCtrl1
            // 
            this.sourceCtrl1.Location = new System.Drawing.Point(124, 25);
            this.sourceCtrl1.Name = "sourceCtrl1";
            this.sourceCtrl1.Size = new System.Drawing.Size(213, 183);
            this.sourceCtrl1.TabIndex = 2;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 397);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLabels);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WizardForm";
            this.Text = "SQL Server to SQL Compact Edition Database Copy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLabels;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOverview;
        private GLT.SqlCopy.Controls.OverviewCtrl overviewCtrl1;
        private GLT.SqlCopy.Controls.SourceCtrl sourceCtrl1;
        private System.Windows.Forms.Label lblSource;
        private GLT.SqlCopy.Controls.TableCtrl tableCtrl1;
        private System.Windows.Forms.Label lblTables;
        private GLT.SqlCopy.Controls.OutputCtrl outputCtrl1;
        private System.Windows.Forms.Label lblOutput;
        private GLT.SqlCopy.Controls.OptionsCtrl optionsCtrl1;
        private System.Windows.Forms.Label lblOptions;
        private GLT.SqlCopy.Controls.SummaryCtrl summaryCtrl1;
        private System.Windows.Forms.Label lblSummary;
        private FinishCtrl finishCtrl1;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}