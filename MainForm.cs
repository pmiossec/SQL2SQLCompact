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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using System.Reflection;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace GLT.SqlCopy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ddlAuthType.SelectedItem = "Windows Authentication";

             
        }

        private void ddlAuthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAuthType.Text == "Windows Authentication")
            {
                tbLogin.Enabled = false;
                tbPassword.Enabled = false;

                lblLogin.Enabled = false;
                lblPassword.Enabled = false;
            }
            else
            {
                tbLogin.Enabled = true;
                tbPassword.Enabled = true;

                lblLogin.Enabled = true;
                lblPassword.Enabled = true;

                tbLogin.Focus();
                tbLogin.SelectAll();
            }
        }

        private Server SourceServer = null;
        
        private void ddlCatalog_DropDown(object sender, EventArgs e)
        {
            

            if (ddlAuthType.Text == "SQL Server Authentication")
            {
                ServerConnection svrConn = new ServerConnection(tbServerName.Text);
                svrConn.LoginSecure = false;
                svrConn.Login = tbLogin.Text;
                svrConn.Password = tbPassword.Text;
                SourceServer = new Server(svrConn);
            }
            else
                SourceServer = new Server(tbServerName.Text);

            ddlCatalog.Items.Clear();

            try
            {
                foreach (Database db in SourceServer.Databases)
                {
                    ddlCatalog.Items.Add(db.Name);
                }
            }
            catch (ConnectionFailureException ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbDestPath.Text = saveFileDialog1.FileName;
            }
        }

        private bool IsSourceReady()
        {
            if (String.IsNullOrEmpty(tbServerName.Text))
                return false; //no server has been selected

            if (ddlAuthType.Text == "SQL Server Authentication" && String.IsNullOrEmpty(tbLogin.Text))
                return false; //Auth type is Sql server but no login has been provided

            if (SourceServer != null && SourceServer.Name.ToLower() == tbServerName.Text.ToLower())
                return false; //already connected and retrieve this servers databases


            return true;
        }

        private bool IsDestinationReady()
        {
            if (String.IsNullOrEmpty(tbDestPath.Text))
                return false; //no destination path for the file


            return true;

        }

        private void btnBeginCopy_Click(object sender, EventArgs e)
        {
            SetStatus("Checking paths to System.Data.SqlServerCe.dll..."); 
            if (!CheckSQLMobileAssemblyPaths())
            {
                MessageBox.Show(this, "Please update the SQL Mobile paths in the App.Config file. The paths must point to the 3.0 version and the 3.5 version of the System.Data.SqlServerCe.dll", "System.Data.SqlServerCe.dll versions not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            rbVer3.Enabled = false;
            rbVer35.Enabled = false;
            DoMobileCopy();
        }

        private void SetStatus(string txt)
        {
            lblStatus.Text = txt;
            Application.DoEvents();
            //Thread.Sleep(300);
        }

        private bool CheckSQLMobileAssemblyPaths()
        {
            string path30 = GLT.SqlCopy.Properties.Settings.Default.SQLMobile30;
            string path35 = GLT.SqlCopy.Properties.Settings.Default.SQLMobile35;

            bool retVal = true;
            if (File.Exists(path30))
            {
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path30);
                if (ver.FileVersion != "3.0.5300.0")
                    retVal = false;
            }
            else
                retVal = false;

            if (File.Exists(path35))
            {
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path35);
                if (ver.FileVersion != "3.5.5386.0")
                    retVal = false;
            }
            else
                retVal = false;


            return retVal;

        }

        private void DoMobileCopy()
        { 
            this.Cursor = Cursors.WaitCursor;
            //Get ref to the source database being copied
            Database sourceDb = SourceServer.Databases[ddlCatalog.Text];

            bool doCopy = true;
            //Create the Output SDF file
            SetStatus("Checking output path...");
            if (File.Exists(tbDestPath.Text))
            {
                if (MessageBox.Show(this, "A file with that name already exist! Are you sure you want to overwrite this file?", "File already exist!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(tbDestPath.Text);
                }
                else
                    doCopy = false;
            }

            if (doCopy)
            {
                bool copiedFailed = false;

                string mobileConnStr = "Data Source='{0}';LCID={1};Password={2};Encrypt={3};";
                mobileConnStr = String.Format(mobileConnStr, tbDestPath.Text, tbMobileDestLogin.Text, tbMobileDestPassword.Text, cbEncryptDb.Checked.ToString().ToUpper());

               
                string assemblyPath = "";
                if(rbVer3.Checked)
                    assemblyPath = GLT.SqlCopy.Properties.Settings.Default.SQLMobile30;
                else
                    assemblyPath = GLT.SqlCopy.Properties.Settings.Default.SQLMobile35;


                //Test Assembly version
                SetStatus("Loading correct version of System.Data.SqlServerCe.dll...");
                Assembly asm = Assembly.LoadFrom(assemblyPath);
                AssemblyName asmName = asm.GetName();
                Version ver = asmName.Version;

                Type type = asm.GetType("System.Data.SqlServerCe.SqlCeEngine");
                object[] objArray = new object[1];
                objArray[0] = mobileConnStr;
                object engine = Activator.CreateInstance(type, objArray);

                MethodInfo mi = type.GetMethod("CreateDatabase");
                SetStatus("Creating the SQL Server Compact Edition Database...");
                mi.Invoke(engine, null);

                SetStatus("Connecting to the SQL Server Compact Edition Database...");
                Type connType = asm.GetType("System.Data.SqlServerCe.SqlCeConnection");
                System.Data.IDbConnection conn = (System.Data.IDbConnection)Activator.CreateInstance(connType);
                conn.ConnectionString = mobileConnStr;
                conn.Open();
                
                //create all the tables
                foreach (Table tbl in sourceDb.Tables)
                {
                    if (tbl.IsSystemObject)
                        continue;

                    SetStatus("Scripting table: " + tbl.Name);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("CREATE TABLE ").Append(tbl.Name).Append("(");
                    int colIdx = 0;
                    List<string> pKeys = new List<string>();
                    foreach (Column col in tbl.Columns)
                    {
                        if (colIdx > 0)
                            sb.Append(", ");

                        sb.Append("[").Append(col.Name).Append("]").Append(" ");
                        string dtName = col.DataType.Name.ToLower();
                        if (dtName == "varchar" || dtName == "char")
                        {
                            int max = col.DataType.MaximumLength;
                            col.DataType = new DataType(SqlDataType.NVarChar);
                            col.DataType.MaximumLength = max;
                        }
                        else if (dtName == "text")
                        {
                            col.DataType = new DataType(SqlDataType.NVarChar);
                            col.DataType.MaximumLength = 4000;
                        }
                        else if (dtName == "decimal")
                        {
                            col.DataType = new DataType(SqlDataType.Numeric);
                        }
                        sb.Append(col.DataType.SqlDataType.ToString());
                       
                        string datatype = col.DataType.SqlDataType.ToString().ToLower();
                        if(datatype == "nvarchar" || datatype == "char" || datatype == "varchar" || datatype == "nchar")
                            sb.Append(" (").Append(col.DataType.MaximumLength.ToString()).Append(") ");

                        if (col.InPrimaryKey)
                            pKeys.Add(col.Name);

                        //if (col.InPrimaryKey)
                        //    sb.Append(" CONSTRAINT PK").Append(col.Name);

                        if (!col.Nullable)
                            sb.Append(" NOT NULL");

                        if (col.DefaultConstraint!=null && !String.IsNullOrEmpty(col.DefaultConstraint.Text))
                        {
                            string def = col.DefaultConstraint.Text.Replace("((","(").Replace("))",")");
                            
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

                    Type cmdType = asm.GetType("System.Data.SqlServerCe.SqlCeCommand");
                    System.Data.IDbCommand cmd = (System.Data.IDbCommand)Activator.CreateInstance(cmdType);
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
                        sb.Append("ALTER TABLE ").Append(tbl.Name).Append(" ADD CONSTRAINT PK_");
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
                    }
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

                    //copy the indexes
                    SetStatus("Scripting the indexes for table: " + tbl.Name);
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

                        sb.Append(" INDEX ").Append(idx.Name).Append(" ON ").Append(tbl.Name).Append("(");
                        for (int i = 0; i < idx.IndexedColumns.Count;i++ )
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
                }
                SetStatus("Closing the connection to the SQL Server Compact Edition Database...");
                conn.Close();
                conn.Dispose();
                SetStatus("Ready...");
                if(!copiedFailed)
                    MessageBox.Show(this, "Copy Complete.", "Complete");
            }
            else
                SetStatus("Ready...");

            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutSQLToSqlMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
