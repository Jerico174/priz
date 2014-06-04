using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class PhenomenaItem : UserControl
    {
        public PhenomenaItem()
        {
            InitializeComponent();
        }

        private void lPhenomena_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                this.BackColor = Color.FromArgb(255, 214, 231, 188);
            else
                this.BackColor = Color.WhiteSmoke;
        }
    }
}
