//* Copyright (c) 2008, Scott "Johnny" Smith (www.JohnnyCantCode.com)
//* All rights reserved.
//*
//* Redistribution and use in source and binary forms, with or without
//* modification, are permitted provided that the following conditions are met:
//*     * Redistributions of source code must retain the above copyright
//*       notice, this list of conditions and the following disclaimer.
//*     * Redistributions in binary form must reproduce the above copyright
//*       notice, this list of conditions and the following disclaimer in the
//*       documentation and/or other materials provided with the distribution.
//*     * Neither the name of the <organization> nor the
//*       names of its contributors may be used to endorse or promote products
//*       derived from this software without specific prior written permission.
//*
//* THIS SOFTWARE IS PROVIDED BY Scott "Johnny" Smith ``AS IS'' AND ANY
//* EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//* WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//* DISCLAIMED. IN NO EVENT SHALL <copyright holder> BE LIABLE FOR ANY
//* DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//* (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//* LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//* ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//* (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//* SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLT.SqlCopy.Controls;
using GLT.SqlCopy.Properties;
using System.IO;
using System.Diagnostics;
using Microsoft.SqlServer.Management.Smo;
using System.Reflection;
using System.Security.Policy;

namespace GLT.SqlCopy
{
    public partial class WizardForm : Form
    {
        public WizardForm()
        {
            InitializeComponent();
            _currentStep = overviewCtrl1;

            CheckSQLMobileAssemblyPaths();
            if (!SqlMobileVer31Good && !SqlMobileVer35Good)
            {
                //in this case we do not have a good path to the Compact Edition drivers
                Dialogs.SelectMobileAssembliesDialog dialog = new GLT.SqlCopy.Dialogs.SelectMobileAssembliesDialog();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (dialog.Ver31Valid)
                        GLT.SqlCopy.Properties.Settings.Default.SQLMobile30 = dialog.Ver31Path;

                    if (dialog.Ver35Valid)
                        GLT.SqlCopy.Properties.Settings.Default.SQLMobile35 = dialog.Ver35Path;

                    GLT.SqlCopy.Properties.Settings.Default.Save();
                }
            }

            //Verify that we have at least one good Compact Edition Driver
            bool validDriver = false;
            CheckSQLMobileAssemblyPaths();
            if (SqlMobileVer31Good)
            {
                outputCtrl1.EnableVer31 = true;
                validDriver = true;
            }
            else
                outputCtrl1.EnableVer31 = false;

            if (SqlMobileVer35Good)
            {
                outputCtrl1.EnableVer35 = true;
                validDriver = true;
            }
            else
                outputCtrl1.EnableVer35 = false;

            if (!validDriver)
            {
                MessageBox.Show(this, "Unable to locate valid SQL Server Compact Edition assemblies.", "Assemblies not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            UpdateWizard();
        }

        private void CheckSQLMobileAssemblyPaths()
        {
            string path30 = GLT.SqlCopy.Properties.Settings.Default.SQLMobile30;
            string path35 = GLT.SqlCopy.Properties.Settings.Default.SQLMobile35;

            if (File.Exists(path30))
            {
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path30);
                if (ver.FileVersion.Substring(0,3) == "3.0")
                    SqlMobileVer31Good = true;
                else
                    SqlMobileVer31Good = false;
            }
            else
                SqlMobileVer31Good = false;

            if (File.Exists(path35))
            {
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path35);
                if (ver.FileVersion.Substring(0,3) == "3.5")
                    SqlMobileVer35Good = true;
                else
                    SqlMobileVer35Good = false;
            }
            else
                SqlMobileVer35Good = false;

        }

        private bool SqlMobileVer31Good = false;
        private bool SqlMobileVer35Good = false;


        private Font _SelectStepFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font _NotSelectedStepFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private UserControl _currentStep = null;

        private void UpdateWizard()
        {
            pnlContent.SuspendLayout();

            if (_currentStep.GetType() == typeof(OverviewCtrl))
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
                btnCancel.Enabled = true;
                SetStepLabel(lblOverview);
            }

            if (_currentStep.GetType() == typeof(SourceCtrl))
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
                btnCancel.Enabled = true;
                SetStepLabel(lblSource);
            }

            if (_currentStep.GetType() == typeof(TableCtrl))
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
                btnCancel.Enabled = true;
                SetStepLabel(lblTables);
            }

            if (_currentStep.GetType() == typeof(OutputCtrl))
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
                btnCancel.Enabled = true;
                SetStepLabel(lblOutput);
            }

            if (_currentStep.GetType() == typeof(OptionsCtrl))
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
                btnCancel.Enabled = true;
                SetStepLabel(lblOptions);
            }

            if (_currentStep.GetType() == typeof(SummaryCtrl))
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Finish";
                btnCancel.Enabled = true;
                SetStepLabel(lblSummary);
            }

            if (_currentStep.GetType() == typeof(FinishCtrl))
            {
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                btnNext.Text = "Close";
                btnCancel.Enabled = false;
                btnHelp.Enabled = false;
                SetStepLabel(lblFinish);
            }

            _currentStep.BringToFront();

            _currentStep.Dock = DockStyle.Fill;
            pnlContent.ResumeLayout();

            if (_currentStep.GetType() == typeof(FinishCtrl))
            {
                DoCopy();
            }
        }

        private void SetStepLabel(Label lbl)
        {
            pnlLabels.SuspendLayout();
            foreach (Control ctrl in pnlLabels.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.BackColor = Color.Transparent;
                    ctrl.Font = _NotSelectedStepFont;
                    ctrl.ForeColor = Color.White;
                }
            }
            lbl.BackColor = this.BackColor;
            lbl.Font = _SelectStepFont;
            lbl.ForeColor = Color.Black;
            pnlLabels.ResumeLayout();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_currentStep.GetType() == typeof(SummaryCtrl))
            {
                _currentStep = optionsCtrl1;
            }
            else if (_currentStep.GetType() == typeof(OptionsCtrl))
            {
                _currentStep = outputCtrl1;
            }
            else if (_currentStep.GetType() == typeof(OutputCtrl))
            {
                _currentStep = tableCtrl1;
            }
            else if (_currentStep.GetType() == typeof(TableCtrl))
            {
                _currentStep = sourceCtrl1;
            }
            else if (_currentStep.GetType() == typeof(SourceCtrl))
            {
                _currentStep = overviewCtrl1;
            }

            UpdateWizard();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentStep.GetType() == typeof(OverviewCtrl))
            {
                _currentStep = sourceCtrl1;
            }
            else if (_currentStep.GetType() == typeof(SourceCtrl))
            {
                if (String.IsNullOrEmpty(sourceCtrl1.DatabaseName))
                {
                    MessageBox.Show(this, "Please select a database before you continue.", "Select database.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _currentStep = tableCtrl1;
                this.Cursor = Cursors.WaitCursor;
                tableCtrl1.ListTables(sourceCtrl1.SourceServer.Databases[sourceCtrl1.DatabaseName]);
                this.Cursor = Cursors.Default;
            }
            else if (_currentStep.GetType() == typeof(TableCtrl))
            {
                if (tableCtrl1.SelectedTableNames.Count < 1)
                {
                    MessageBox.Show(this, "You must select at least 1 table to copy before you continue.", "Select at least 1 table.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _currentStep = outputCtrl1;
            }
            else if (_currentStep.GetType() == typeof(OutputCtrl))
            {
                _currentStep = optionsCtrl1;
            }
            else if (_currentStep.GetType() == typeof(OptionsCtrl))
            {
                _currentStep = summaryCtrl1;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Source Server:").AppendLine(sourceCtrl1.SourceServer.Name).AppendLine(" ");

                sb.AppendLine("Tables to be copied:");
                for (int i = 0; i < tableCtrl1.SelectedTableNames.Count; i++)
                {
                    if (i > 0)
                        sb.Append(", ");

                    sb.Append(tableCtrl1.SelectedTableNames[i]);
                }

                sb.AppendLine(" ").AppendLine("").AppendLine("SQL Server Compact Edition Connection String:").AppendLine(outputCtrl1.OutPutConnectionString).AppendLine(" ");

                sb.AppendLine("Options:").Append("Copy table data?  ").Append(optionsCtrl1.CopyData.ToString());

                summaryCtrl1.SetSummaryText(sb.ToString());
            }
            else if (_currentStep.GetType() == typeof(SummaryCtrl))
            {
                _currentStep = finishCtrl1;
            }
            else if (_currentStep.GetType() == typeof(FinishCtrl))
            {
                Application.Exit();
                return;
            }

            UpdateWizard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoCopy()
        {
            this.Cursor = Cursors.WaitCursor;

            //Get ref to the source database being copied
            Database sourceDb = sourceCtrl1.SourceServer.Databases[sourceCtrl1.DatabaseName];


            bool doCopy = true;
            //Create the Output SDF file
            finishCtrl1.SetStageText("Creating Database");
            finishCtrl1.SetProgressText("Checking output path...");

            if (File.Exists(outputCtrl1.DestinationPath))
            {
                if (MessageBox.Show(this, "A file with that name already exist! Are you sure you want to overwrite this file?", "File already exist!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(outputCtrl1.DestinationPath);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(this, ex.Message, "Unable to continue!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _currentStep = outputCtrl1;
                        UpdateWizard();
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                    doCopy = false;
            }

            if (doCopy)
            {
                bool copiedFailed = false;

                string mobileConnStr = outputCtrl1.OutPutConnectionString;

                string assemblyPath = "";
                if (outputCtrl1.EnableVer31)
                    assemblyPath = GLT.SqlCopy.Properties.Settings.Default.SQLMobile30;
                else
                    assemblyPath = GLT.SqlCopy.Properties.Settings.Default.SQLMobile35;


                //Test Assembly version
                finishCtrl1.SetProgressText("Loading correct version of System.Data.SqlServerCe.dll...");
                Assembly asm = Assembly.LoadFrom(assemblyPath);
                AssemblyName asmName = asm.GetName();
                Version ver = asmName.Version;

                Type type = asm.GetType("System.Data.SqlServerCe.SqlCeEngine");
                object[] objArray = new object[1];
                objArray[0] = mobileConnStr;
                object engine = Activator.CreateInstance(type, objArray);

                //Create the database. 
                MethodInfo mi = type.GetMethod("CreateDatabase");
                finishCtrl1.SetProgressText("Creating the SQL Server Compact Edition Database...");
                try
                {
                    mi.Invoke(engine, null);
                }
                catch (TargetInvocationException ex)
                {
                    MessageBox.Show(this, "You do not have permissions to save the file to " + outputCtrl1.DestinationPath + ". Please select a different destination path and try again.", "Create database failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _currentStep = outputCtrl1;
                    UpdateWizard();
                    this.Cursor = Cursors.Default;
                    return;
                }
                finishCtrl1.SetProgressText("Connecting to the SQL Server Compact Edition Database...");
                Type connType = asm.GetType("System.Data.SqlServerCe.SqlCeConnection");
                System.Data.IDbConnection conn = (System.Data.IDbConnection)Activator.CreateInstance(connType);
                conn.ConnectionString = mobileConnStr;
                conn.Open();

                //create all the tables
                finishCtrl1.UpdateProgressBar(0, tableCtrl1.SelectedTableNames.Count);
                int tblCount = 0;

                Type cmdType = asm.GetType("System.Data.SqlServerCe.SqlCeCommand");
                System.Data.IDbCommand cmd = (System.Data.IDbCommand)Activator.CreateInstance(cmdType);
                foreach (string tblName in tableCtrl1.SelectedTableNames)
                {
                    Table tbl = sourceDb.Tables[tblName, tableCtrl1.SchemaName];
                    if(tbl==null)
                    {
                        MessageBox.Show(this, "Table '" + tblName + "' was not found in the selected schema.", "Create table failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        copiedFailed = true;
                        _currentStep = outputCtrl1;
                        break;
                    }
                    if (tbl.IsSystemObject)
                        continue;

                    
                    finishCtrl1.SetProgressText("Scripting table: " + tbl.Name);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("CREATE TABLE [").Append(tbl.Name).Append("](");
                    int colIdx = 0;
                    List<string> pKeys = new List<string>();
                    foreach (Column col in tbl.Columns)
                    {
                        if (colIdx > 0)
                            sb.Append(", ");

                        sb.Append("[").Append(col.Name).Append("]").Append(" ");
                        int max = 0;
                        switch (col.DataType.SqlDataType)
                        {
                            case SqlDataType.VarChar:
                                max = col.DataType.MaximumLength;
                                col.DataType = new DataType(SqlDataType.NVarChar);
                                col.DataType.MaximumLength = max;
                                break;

                            case SqlDataType.Char:
                                max = col.DataType.MaximumLength;
                                col.DataType = new DataType(SqlDataType.NChar);
                                col.DataType.MaximumLength = max;
                                break;

                            case SqlDataType.Text:
                                col.DataType = new DataType(SqlDataType.NText);
                                break;

                            case SqlDataType.Decimal:
                                int scale = col.DataType.NumericScale;
                                int precision = col.DataType.NumericPrecision;
                                col.DataType = new DataType(SqlDataType.Numeric);
                                col.DataType.NumericPrecision = precision;
                                col.DataType.NumericScale = scale;
                                break;


                        }

                        sb.Append(col.DataType.SqlDataType.ToString());

                        SqlDataType datatype = col.DataType.SqlDataType;
                        if (datatype == SqlDataType.NVarChar || datatype == SqlDataType.NChar)
                            sb.Append(" (").Append(col.DataType.MaximumLength.ToString()).Append(") ");
                        else if (datatype == SqlDataType.Numeric)
                            sb.Append(" (").Append(col.DataType.NumericPrecision).Append(",").Append(col.DataType.NumericScale).Append(")");


                        if (col.InPrimaryKey)
                            pKeys.Add(col.Name);

                        //if (col.InPrimaryKey)
                        //    sb.Append(" CONSTRAINT PK").Append(col.Name);

                        if (!col.Nullable)
                            sb.Append(" NOT NULL");

                        if (col.DefaultConstraint != null && !String.IsNullOrEmpty(col.DefaultConstraint.Text))
                        {
                            string def = col.DefaultConstraint.Text.Replace("((", "(").Replace("))", ")");

                            sb.Append(" DEFAULT ").Append(col.DefaultConstraint.Text);
                            //sb.Append(" DEFAULT (1) ");
                        }

                        if (col.Identity)
                        {
                            sb.Append(" IDENTITY (").Append(col.IdentitySeed.ToString()).Append(",").Append(col.IdentityIncrement.ToString()).Append(")");
                        }

                        //if (col.InPrimaryKey)
                        //    sb.Append(" PRIMARY KEY");

                        colIdx++;

                    }
                    sb.Append(")");


                    cmd.CommandText = sb.ToString();
                    cmd.Connection = conn;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Create table failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        copiedFailed = true;
                        break;
                    }

                    //add the PK constraints
                    if (pKeys.Count > 0)
                    {
                        sb = new StringBuilder();
                        sb.Append("ALTER TABLE [").Append(tbl.Name).Append("] ADD CONSTRAINT PK_");
                        //create the constraint name
                        for (int k = 0; k < pKeys.Count; k++)
                        {
                            if (k > 0)
                                sb.Append("_");

                            sb.Append(pKeys[k]);
                        }

                        sb.Append(" PRIMARY KEY(");
                        //add the constraint fields
                        for (int k = 0; k < pKeys.Count; k++)
                        {
                            if (k > 0)
                                sb.Append(", ");

                            sb.Append(pKeys[k]);
                        }
                        sb.Append(")");
                    
                        cmd.CommandText = sb.ToString();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Create table failed! Failed creating the Primary Key(s).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            copiedFailed = true;
                            break;
                        }
                    }

                    //copy the indexes
                    finishCtrl1.SetProgressText("Scripting the indexes for table: " + tbl.Name);
                    foreach (Index idx in tbl.Indexes)
                    {
                        if (idx.IndexKeyType == IndexKeyType.DriPrimaryKey)
                            continue;

                        sb = new StringBuilder();
                        sb.Append("CREATE");
                        if (idx.IsUnique)
                            sb.Append(" UNIQUE");

                        //if (!idx.IsClustered)
                        //    sb.Append(" CLUSTERED");
                        //else
                        //    sb.Append(" NONCLUSTERED");

                        sb.Append(" INDEX ").Append(idx.Name).Append(" ON [").Append(tbl.Name).Append("](");
                        for (int i = 0; i < idx.IndexedColumns.Count; i++)
                        {
                            if (i > 0)
                                sb.Append(", ");

                            sb.Append(idx.IndexedColumns[i].Name);
                        }
                        sb.Append(")");

                        cmd.CommandText = sb.ToString();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Create table failed! Failed creating the indexes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            copiedFailed = true;
                            break;
                        }

                    }
                    tblCount++;
                    finishCtrl1.UpdateProgressBar(tblCount, tableCtrl1.SelectedTableNames.Count);
                }

                if (!copiedFailed)
                {
                    //Now copy the data
                    if (optionsCtrl1.CopyData)
                    {
                        finishCtrl1.SetStageText("Copying database data.");

                        foreach (string tblName in tableCtrl1.SelectedTableNames)
                        {
                            Table tbl = sourceDb.Tables[tblName];
                            if (tbl.IsSystemObject)
                                continue;

                            finishCtrl1.SetProgressText("Copying " + tbl.RowCount.ToString() + " rows from " + tbl.Name);
                            finishCtrl1.UpdateProgressBar(0, (int)tbl.RowCount);
                            bool hasIdentity = false;
                            string alterSql = "ALTER TABLE [{0}] ALTER COLUMN [{1}] IDENTITY({2},{3})";
                            string IDColName = "";
                            long increment = 1;
                            //If the table has an Identity column then we need to re-set the seed and increment
                            //This is a hack since SQL Server Compact Edition does not support SET IDENTITY_INSERT <columnname> ON
                            foreach (Column col in tbl.Columns)
                            {
                                if (col.Identity)
                                {
                                    hasIdentity = true;
                                    IDColName = col.Name;
                                    alterSql = String.Format(alterSql, tbl.Name, col.Name, "{0}", "{1}");
                                }
                            }


                            //Select SQL
                            string sql = "SELECT * FROM [{0}]";

                            //Insert Sql
                            string insertSql = "INSERT INTO [{0}] ({1}) VALUES ({2})";
                            StringBuilder sbColums = new StringBuilder();
                            StringBuilder sbValues = new StringBuilder();
                            int idx1 = 0;
                            foreach (Column col in tbl.Columns)
                            {
                                if (col.Name != IDColName)
                                {
                                    if (idx1 > 0)
                                    {
                                        sbColums.Append(",");
                                        sbValues.Append(",");
                                    }

                                    sbColums.Append("[").Append(col.Name).Append("]");
                                    sbValues.Append("?");
                                    idx1++;
                                }
                            }

                            insertSql = String.Format(insertSql, tbl.Name, sbColums.ToString(), sbValues.ToString());

                            sql = String.Format(sql, tbl.Name);
                            DataSet ds = sourceDb.ExecuteWithResults(sql);
                            if (ds.Tables.Count > 0)
                            {
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    int rowCnt = 0;
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {
                                        rowCnt++;
                                        finishCtrl1.UpdateProgressBar(rowCnt, (int)tbl.RowCount);

                                        if (hasIdentity)
                                        {
                                            long seed = long.Parse(row[IDColName].ToString());
                                            seed--;
                                            string alterTableForIDColumn = String.Format(alterSql, seed.ToString(), increment.ToString());
                                            cmd.CommandText = alterTableForIDColumn;
                                            try
                                            {
                                                cmd.ExecuteNonQuery();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(this, ex.Message, "Failed altering the Table for IDENTITY insert.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                copiedFailed = true;
                                                break;
                                            }
                                        }

                                        sbValues = new StringBuilder();
                                        cmd.Parameters.Clear();
                                        cmd.CommandText = insertSql;
                                        for (int i = 0; i < tbl.Columns.Count; i++)
                                        {
                                            if (tbl.Columns[i].Name != IDColName)
                                            {
                                                Type type1 = asm.GetType("System.Data.SqlServerCe.SqlCeParameter");
                                                object[] objArray1 = new object[2];
                                                objArray1[0] = tbl.Columns[i].Name;
                                                objArray1[1] = row[tbl.Columns[i].Name];
                                                object p = Activator.CreateInstance(type1, objArray1);
                                                cmd.Parameters.Add(p);
                                            }
                                        }
                                        cmd.CommandText = String.Format(insertSql, sbValues.ToString());
                                        try
                                        {
                                            cmd.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(this, ex.Message, "Copy table data failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            copiedFailed = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }




                        //Now add the FK relationships
                        if (!copiedFailed)
                        {
                            finishCtrl1.SetStageText("Adding ForeignKeys.");
                            string fkSql = "ALTER TABLE [{0}] ADD CONSTRAINT [{1}] FOREIGN KEY([{2}]) REFERENCES [{3}] ([{4}])";
                            foreach (string tblName in tableCtrl1.SelectedTableNames)
                            {
                                Table tbl = sourceDb.Tables[tblName];
                                if (tbl.IsSystemObject)
                                    continue;

                                int fkCnt = tbl.ForeignKeys.Count;
                                int fxIdx = 0;
                                foreach(ForeignKey fk in tbl.ForeignKeys)
                                {
                                    if(!tableCtrl1.SelectedTableNames.Contains(fk.ReferencedTable))
                                        continue;

                                    fxIdx++;
                                    finishCtrl1.UpdateProgressBar(fxIdx, fkCnt);
                                    finishCtrl1.SetProgressText(tbl.Name + ": " + fk.Name);
                                    string createFKSql = String.Format(fkSql, tbl.Name, fk.Name, "{0}", fk.ReferencedTable, sourceDb.Tables[fk.ReferencedTable].Indexes[fk.ReferencedKey].IndexedColumns[0].Name);
                                    StringBuilder sbFk = new StringBuilder();
                                    foreach (ForeignKeyColumn col in fk.Columns)
                                    {
                                        if (sbFk.Length > 0)
                                            sbFk.Append(",");

                                        sbFk.Append(col.Name);
                                    }
                                    createFKSql = String.Format(createFKSql, sbFk.ToString());
                                    cmd.CommandText = createFKSql;
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(this, ex.Message, "Creating ForeignKeys failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        copiedFailed = true;
                                        break;
                                    }
                                }
                                
                            }
                            
                        }

                        finishCtrl1.SetProgressText("Closing the connection to the SQL Server Compact Edition Database...");
                        conn.Close();
                        conn.Dispose();

                        if (!copiedFailed)
                        {
                            finishCtrl1.SetStageText("");
                            finishCtrl1.SetProgressText("Complete!");
                            finishCtrl1.UpdateProgressBar(100, 100);
                        }
                        else
                        {
                            finishCtrl1.SetStageText("");
                            finishCtrl1.SetProgressText("Copy failed!");
                            finishCtrl1.UpdateProgressBar(0, 0);
                        }
                    }
                    else
                    {
                        finishCtrl1.SetStageText("");
                        finishCtrl1.SetProgressText("Finished!");
                        finishCtrl1.UpdateProgressBar(100, 100);
                    }
                }
                else
                {
                    finishCtrl1.SetStageText("");
                    finishCtrl1.SetProgressText("Copy failed!");
                    finishCtrl1.UpdateProgressBar(0, 0);
                    btnBack.Enabled = true;
                }
                btnNext.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.johnnycantcode.com");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog(this);
        }
    }
}