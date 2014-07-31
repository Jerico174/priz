using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PRIZ
{
    public partial class FormEditTaskEntity : Form
    {
        int counter = 5;
        bool changed = false;
        bool anyUnchecked = true;
        bool error = false;
        bool def = false;
        string oldTaskName = Program.p.currentTask._name;
        OpenFileDialog ofd = new OpenFileDialog();
        Task currentTask = Program.p.currentTask;
        public FormEditTaskEntity()
        {
            InitializeComponent();
            if (Program.p.AdminMode)
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
            label2.Text = Program.p.CurrentFullName;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.FormClosing += Program.ApplicationQuit;
            pbTask.ImageLocation = currentTask._path + "mainpic.png";
            pbTask.BackgroundImageLayout = ImageLayout.Stretch;
            lDescription.Text = currentTask._description;
            lName.Text = currentTask._name;
            DirectoryInfo dir = new DirectoryInfo(@"content\phenomenas");
            try
            {
                foreach (var item in dir.GetFiles())
                {
                    string tempName = item.Name;
                    PhenomenaItem phitem = new PhenomenaItem();
                    phitem.Location = new Point(0, counter);
                    phitem.btnDelete.Visible = false;
                    phitem.btnEdit.Visible = false;
                    phitem.lPhenomena.CheckedChanged += lPhenomena_CheckedChanged;
                    phitem.lPhenomena.Text = tempName.Remove(tempName.LastIndexOf(@"."));
                    if (currentTask._phenomenas.IndexOf(phitem.lPhenomena.Text) > -1)
                    {
                        phitem.lPhenomena.Checked = true;
                    }
                    if (tempName.IndexOf(@".rtf") > -1)
                    {
                        counter += 40;
                        pnlPhenomenas.Controls.Add(phitem);
                    }
                }
                if (pnlPhenomenas.Controls.Count==0)
                {
                    pnlAddPhenomenas.Visible = true;
                }
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"content\phenomenas");
            }
            btnSaveChanges.Enabled = false;
            btnSaveChanges.BackColor = Color.FromArgb(226, 226, 226);
        }

        void lPhenomena_CheckedChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            btnSaveChanges.BackColor = Color.FromArgb(103, 103, 103);
            anyUnchecked = false;
            foreach (PhenomenaItem pitem in pnlPhenomenas.Controls)
            {
                if (pitem.lPhenomena.Checked == false)
                {
                    anyUnchecked = true;
                }
            }
            if (anyUnchecked) bntCheckAll.BackColor = Color.WhiteSmoke;
            else bntCheckAll.BackColor = Color.FromArgb(255, 214, 231, 188);
        }
        
        private void pbTask_Click(object sender, EventArgs e)
        {
            var t = ofd.ShowDialog();
            if (t == DialogResult.OK)
            {
                pbTask.SizeMode = PictureBoxSizeMode.Zoom;
                pbTask.Image = Image.FromFile(ofd.FileName);
                def = false;
                btnSaveChanges.Enabled = true;
                btnSaveChanges.BackColor = Color.FromArgb(103, 103, 103);
            }
            else if (t == DialogResult.Cancel)
            {
                pbTask.Image = Properties.Resources.iconimage;
                def = true;
                btnSaveChanges.Enabled = true;
                btnSaveChanges.BackColor = Color.FromArgb(103, 103, 103);
            }
        }
        private void btnModules_MouseDown(object sender, MouseEventArgs e)
        {
            btnModules.Image = Properties.Resources.modules03;
        }
        private void btnModules_MouseEnter(object sender, EventArgs e)
        {
            btnModules.Image = Properties.Resources.modules02;
        }
        private void btnModules_MouseLeave(object sender, EventArgs e)
        {
            btnModules.Image = Properties.Resources.modules01;
        }
        private void btnModules_MouseUp(object sender, MouseEventArgs e)
        {
            btnModules.Image = Properties.Resources.modules02;
        }
        private void btnAbout_MouseDown(object sender, MouseEventArgs e)
        {
            btnAbout.Image = Properties.Resources.about03;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.Image = Properties.Resources.about02;
        }
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.Image = Properties.Resources.about01;
        }
        private void btnAbout_MouseUp(object sender, MouseEventArgs e)
        {
            btnAbout.Image = Properties.Resources.about02;
        }
        private void btnWriteToUs_MouseDown(object sender, MouseEventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus03;
        }
        private void btnWriteToUs_MouseEnter(object sender, EventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus02;
        }
        private void btnWriteToUs_MouseLeave(object sender, EventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus01;
        }
        private void btnWriteToUs_MouseUp(object sender, MouseEventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus02;
        }
        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            if (def)
            {
                pbTask.Image = Properties.Resources.iconimage_hover;
            }
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            if (def)
            {
                pbTask.Image = Properties.Resources.iconimage;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            changed = false;
            lName.Text.Trim();
            lName.Text = Program.p.ReplaceMultispaces(lName.Text);
            if (lDescription.Text == "" || lName.Text == "" || lName.Text == " " || lName.Text == "Название задания" || lDescription.Text == "Описание задания")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else if (!error)
            {
                string phenomenas = "";
                if (pnlPhenomenas.Controls.Count!=0)
                {
                    foreach (PhenomenaItem phenomena in pnlPhenomenas.Controls)
                    {
                        var p = phenomena.lPhenomena;
                        if (p.Checked) { 
                            phenomenas += p.Text + " - ";
                        }
                    }
                    if (phenomenas == "")
                    {
                        phenomenas = "No Phenomenas";
                    }
                    string currentModule = Program.p.currentModule._filename;
                    NewTask newTask = new NewTask(lName.Text, lDescription.Text, pbTask.RectangleToScreen(pbTask.ClientRectangle), oldTaskName, currentModule, phenomenas);
                    oldTaskName = lName.Text;
                    pnlEdited.Visible = true;
                    timer1.Enabled = true;
                    btnSaveChanges.Enabled = false;
                    btnSaveChanges.BackColor = Color.FromArgb(226, 226, 226);
                }
                else
                {
                    string currentModule = Program.p.currentModule._filename;
                    NewTask newTask = new NewTask(lName.Text, lDescription.Text, pbTask.RectangleToScreen(pbTask.ClientRectangle), oldTaskName, currentModule, phenomenas);
                    oldTaskName = lName.Text;
                    pnlEdited.Visible = true;
                    timer1.Enabled = true;
                    btnSaveChanges.Enabled = false;
                    btnSaveChanges.BackColor = Color.FromArgb(226, 226, 226);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlEdited.Visible = false;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == '\\' || l == '/' || l == ':' || l == '*' || l == '?' || l == '"' || l == '<' || l == '>' || l == '|')
            {
                e.Handled = true;
            }
            else
            {
                changed = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fLogin);
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Program.InitWindow(Forms.fEditTask);
                    Program.fEditTask.Show();
                    this.Hide();
                }
            }
            else
            {
                Program.InitWindow(Forms.fEditTask);
                Program.fEditTask.Show();
                this.Hide();
            }
        }
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Program.currentSize = this.Size;
        }
        private void Form_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != Program.currentWindowState)
            {
                Program.currentWindowState = this.WindowState;
            }
            Program.currentLocation = this.Location;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.WindowState = Program.currentWindowState;
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Program.InitWindow(Forms.fModules);
                    Program.fModules.Show();
                    this.Hide();
                }
            }
            else
            {
                Program.InitWindow(Forms.fModules);
                Program.fModules.Show();
                this.Hide();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutProgramm);
            //this.Hide();
            Program.fAboutProgramm.ShowDialog();
        }

        private void btnWriteToUs_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fMailSender);
            //this.Hide();
            Program.fMailSender.ShowDialog();
        }

        private void lName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            btnSaveChanges.BackColor = Color.FromArgb(103, 103, 103);
        }

        private void btnPhenomenaEditor_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fPhenomenasEditor);
            Program.fPhenomenasEditor.LastWindow = "EditTaskEntity";
            Program.fPhenomenasEditor.Show();
            this.Hide();
        }

        private void bntCheckAll_Click(object sender, EventArgs e)
        {

            foreach (PhenomenaItem pitem in pnlPhenomenas.Controls)
            {
                pitem.lPhenomena.Checked = true;
                pitem.BackColor = Color.FromArgb(255, 214, 231, 188);
            }
            (sender as Button).BackColor = Color.FromArgb(255, 214, 231, 188);
        }

        private void lDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            changed = true;
        }
    }
}
