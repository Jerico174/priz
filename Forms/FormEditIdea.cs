using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormEditOrAddIdea : Form
    {
        public string _textOnButton = "Редактировать";
        public string _text;
        Answer answer = Program.p.answer;
        public FormEditOrAddIdea()
        {
            InitializeComponent();
        }
        
        private void btnEditIdea_Click(object sender, EventArgs e)
        {
           // return tbToEdit.Text;
        }
        
        public string GetText()
        {
            _textOnButton = "Редактировать";
            return tbToEdit.Text.Trim();
        }

        private void FormEditIdea_Load(object sender, EventArgs e)
        {
            tbToEdit.Text = _text;
            btnEditIdea.Text = _textOnButton;
        }

        private void tbToEdit_TextChanged(object sender, EventArgs e)
        {
            string s = Program.p.ReplaceMultispaces((sender as TextBox).Text);
            if (s == "" || s == " ")
            {
                btnEditIdea.Enabled = false;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            }
            else
            {
                btnEditIdea.Enabled = true;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            }
        }
    }
}
