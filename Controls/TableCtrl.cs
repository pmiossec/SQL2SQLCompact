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
using Microsoft.SqlServer.Management.Smo;

namespace GLT.SqlCopy.Controls
{
    public partial class TableCtrl : UserControl
    {
        public TableCtrl()
        {
            InitializeComponent();
        }

        public List<string> SelectedTableNames
        {
            get
            {
                List<string> selectedTables = new List<string>();
                for (int i = 0; i < clbTables.CheckedItems.Count; i++)
                { 
                    selectedTables.Add(clbTables.CheckedItems[i].ToString());
                }
                return selectedTables;
            }
        }

        public string SchemaName
        {
            get { return _Schema; }
        }

        private string _DbName = String.Empty;
        private string _Schema = String.Empty;

        public void ListTables(Database db)
        {
            if (db.Name == _DbName)
                return; //we have already loaded the tables for this database

            _DbName = db.Name;
            clbTables.Items.Clear();
            ddlSchema.Items.Clear();
            
            foreach (Schema schema in db.Schemas)
            {
                if(schema.Name.Substring(0,3) != "db_")
                    ddlSchema.Items.Add(schema.Name);
            }
            ddlSchema.SelectedIndex = 0;
            _Schema = ddlSchema.SelectedItem.ToString();

            foreach (Table tbl in db.Tables)
            {
                if(!tbl.IsSystemObject)
                    clbTables.Items.Add(tbl.Name);
            }
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTables.Items.Count; i++)
                clbTables.SetItemChecked(i, cbSelectAll.Checked);
        }

        private void ddlSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Schema = ddlSchema.SelectedItem.ToString();
        }
    }
}
