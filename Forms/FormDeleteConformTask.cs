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
    public partial class FormDeleteConformTask : Form
    {
        public FormDeleteConformTask()
        {
            InitializeComponent();
            lReallyTask.Text = lReallyTask.Text + "\r\n «" + Program.p.currentTask._name + "» из модуля «" + Program.p.currentModule._filename + "»?";
        }
    }
}
