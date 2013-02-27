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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GLT.SqlCopy.Controls
{
    public partial class OutputCtrl : UserControl
    {
        public OutputCtrl()
        {
            InitializeComponent();
        }

        public string OutPutConnectionString
        {
            get 
            {
                string mobileConnStr = "Data Source='{0}';LCID={1};Password={2};Encrypt={3};SSCE:Max Database Size=4091;";
                mobileConnStr = String.Format(mobileConnStr, tbDestPath.Text, tbMobileDestLogin.Text, tbMobileDestPassword.Text, cbEncryptDb.Checked.ToString().ToUpper());
                return mobileConnStr;
            }
        }

        private string _TempOutputPath;
        public string TempOutputPath
        {
            get 
            {
                if (String.IsNullOrEmpty(_TempOutputPath))
                    _TempOutputPath = Path.GetTempFileName();

                return _TempOutputPath;
            }
        }

        public string DestinationPath
        {
            get { return tbDestPath.Text; }
        }

        public SqlServerCompactVersion SelectedVersion
        {
            get 
            {
                if (rbVer3.Checked)
                    return SqlServerCompactVersion.ver31;
                else
                    return SqlServerCompactVersion.ver35;
            }
        }

        public bool EnableVer31
        {
            get { return rbVer3.Enabled; }
            set { rbVer3.Enabled = value; }
        }

        public bool EnableVer35
        {
            get { return rbVer35.Enabled; }
            set 
            {
                if (value)
                    rbVer35.Checked = true;
                else
                    rbVer3.Checked = true;
                rbVer35.Enabled = value; 
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbDestPath.Text = saveFileDialog1.FileName;
            }
        }

        
    }
}
