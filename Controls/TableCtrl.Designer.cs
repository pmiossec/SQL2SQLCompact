namespace GLT.SqlCopy.Controls
{
    partial class TableCtrl
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
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.ddlSchema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select tables to copy";
            // 
            // clbTables
            // 
            this.clbTables.CheckOnClick = true;
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(14, 107);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(362, 154);
            this.clbTables.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click the ckeckbox next to each table you could like copied.";
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(17, 84);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbSelectAll.TabIndex = 4;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // ddlSchema
            // 
            this.ddlSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSchema.FormattingEnabled = true;
            this.ddlSchema.Location = new System.Drawing.Point(245, 84);
            this.ddlSchema.Name = "ddlSchema";
            this.ddlSchema.Size = new System.Drawing.Size(131, 21);
            this.ddlSchema.TabIndex = 5;
            this.ddlSchema.SelectedIndexChanged += new System.EventHandler(this.ddlSchema_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Schema";
            // 
            // TableCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSchema);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbTables);
            this.Controls.Add(this.label1);
            this.Name = "TableCtrl";
            this.Size = new System.Drawing.Size(392, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.ComboBox ddlSchema;
        private System.Windows.Forms.Label label3;
    }
}
