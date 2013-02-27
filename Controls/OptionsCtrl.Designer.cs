namespace GLT.SqlCopy.Controls
{
    partial class OptionsCtrl
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCopyTableData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the options below:";
            // 
            // cbCopyTableData
            // 
            this.cbCopyTableData.AutoSize = true;
            this.cbCopyTableData.Checked = true;
            this.cbCopyTableData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyTableData.Location = new System.Drawing.Point(17, 98);
            this.cbCopyTableData.Name = "cbCopyTableData";
            this.cbCopyTableData.Size = new System.Drawing.Size(100, 17);
            this.cbCopyTableData.TabIndex = 4;
            this.cbCopyTableData.Text = "Copy table data";
            this.cbCopyTableData.UseVisualStyleBackColor = true;
            // 
            // OptionsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCopyTableData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsCtrl";
            this.Size = new System.Drawing.Size(392, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCopyTableData;
    }
}
