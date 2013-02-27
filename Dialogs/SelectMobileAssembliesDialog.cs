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
using System.Diagnostics;

namespace GLT.SqlCopy.Dialogs
{
    public partial class SelectMobileAssembliesDialog : Form
    {
        public SelectMobileAssembliesDialog()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if(Check31version(openFileDialog1.FileName))
                    tb31Path.Text = openFileDialog1.FileName;
                else
                    MessageBox.Show(this, "This does not appear to be the correct version.", "Wrong Version of Assembly!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (Check35version(openFileDialog1.FileName))
                    tb35Path.Text = openFileDialog1.FileName;
                else
                    MessageBox.Show(this, "This does not appear to be the correct version.", "Wrong Version of Assembly!", MessageBoxButtons.OK);
            }
        }


        private bool Check31version(string path)
        { 
            if(String.IsNullOrEmpty(path))
                return false;

            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path);
            if (ver.FileVersion == "3.0.5300.0")
            {
                _Ver31Valid = true;
                return true;
            }
            else
            {
                _Ver31Valid = false;
                return false;
            }
        }

        private bool Check35version(string path)
        {
            if (String.IsNullOrEmpty(path))
                return false;

            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(path);
            if (ver.FileVersion == "3.5.5386.0")
            {
                _Ver35Valid = true;
                return true;
            }
            else
            {
                _Ver35Valid = false;
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Check31version(tb31Path.Text) && !Check35version(tb35Path.Text))
            {
                MessageBox.Show(this, "You must select at least one valid assembly version to continue.", "Wrong Version of Assembly!", MessageBoxButtons.OK);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public string Ver31Path
        {
            get { return tb31Path.Text; }
        }

        public string Ver35Path
        {
            get { return tb35Path.Text; }
        }

        private bool _Ver31Valid = false;
        public bool Ver31Valid
        {
            get { return _Ver31Valid; }
        }

        private bool _Ver35Valid = false;
        public bool Ver35Valid
        {
            get { return _Ver35Valid; }
        }
    }
}
