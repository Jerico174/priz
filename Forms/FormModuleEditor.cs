﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormModuleEditor : Form
    {
        public FormModuleEditor()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
        }

        private void btnNewModule_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fNewModule);
            Program.fNewModule.Show();
            this.Hide();
        }

        private void btnEditModule_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fEditModule);
            Program.fEditModule.Show();
            this.Hide();
        }
    }
}
