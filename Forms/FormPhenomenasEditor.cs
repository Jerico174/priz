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
    public partial class FormPhenomenasEditor : Form
    {
        bool changed=false;
        string _lastWindow;
        Task currentTask = Program.p.currentTask;
        int counter = 5;
        string oldPhenomenaName;
        DirectoryInfo dir = new DirectoryInfo(@"content\phenomenas");
        public string LastWindow
        {
            get { return _lastWindow; }
            set { _lastWindow = value; }
        }
        string _earlierText;
        string _earlierText2;
        OpenFileDialog ofd = new OpenFileDialog();
        public FormPhenomenasEditor()
        {
            InitializeComponent();
            if (Program.p.AdminMode)
            {
                lbUserName.Visible = false;
                label3.Visible = false;
            }
            lbUserName.Text = Program.p.CurrentFullName;
            this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            UpdateList();
        }

        private void UpdateList()
        {
            counter = 0;
            try
            {
                pnlPhenomenas.Controls.Clear();
                foreach (var item in dir.GetFiles())
                {
                    string tempName = item.Name;
                    PhenomenaItem phitem = new PhenomenaItem();
                    phitem.Location = new Point(0, counter);
                    phitem.Size = new System.Drawing.Size(250, phitem.Size.Height);
                    phitem.lPhenomena.Visible = false;
                    phitem.btnDelete.Click += btnDelete2_Click;
                    phitem.btnEdit.Click+=btnEdit2_Click;
                    phitem.lblPhenomena.Text = tempName.Remove(tempName.LastIndexOf(@"."));
                    phitem.lblPhenomena.Visible = true;
                    if (tempName.IndexOf(".rtf") > -1)
                    {
                        counter += 40;
                        pnlPhenomenas.Controls.Add(phitem);
                    }
                }
            }
            catch { }
        }

        void RedrawImages()
        {
            int counter = 0;
            foreach (PhenomenaImage pimg in panel2.Controls)
            {
                pimg.Location = new Point(0, counter);
                counter += 155;
            }
            if (panel2.Controls.Count == 0)
            {
                tbPhenomenaContent.Location = new Point(0, 0);
                tbPhenomenaContent.Size = new Size(603, 420);
            }
            else
            {
                tbPhenomenaContent.Location = new Point(173, 0);
                tbPhenomenaContent.Size = new Size(430, 420);
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            var t = ofd.ShowDialog();
            if (t == DialogResult.OK)
            {
                PhenomenaImage pimg = new PhenomenaImage();
                pimg.pbImage.Image = Image.FromFile(ofd.FileName);
                pimg.btnDelete.Click += btnDelete_Click;
                pimg.btnEdit.Click += btnEdit_Click;
                panel2.Controls.Add(pimg);
                PhenomenaImageLocation();
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            var elem = (sender as Button).Parent;
            var t = ofd.ShowDialog();
            if (t == DialogResult.OK)
            {
                (elem as PhenomenaImage).pbImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        void btnEdit2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            tbPhenomenaName.Text = ((sender as Button).Parent as PhenomenaItem).lblPhenomena.Text;
            tbPhenomenaContent.LoadFile(@"content/phenomenas/" + ((sender as Button).Parent as PhenomenaItem).lblPhenomena.Text + ".rtf", RichTextBoxStreamType.RichText);
            oldPhenomenaName = ((sender as Button).Parent as PhenomenaItem).lblPhenomena.Text; // записываем имя, чтобы использовать его при удалении старого файла
            for (int i = 1; i < 11; i++)
            {
                tbPhenomenaContent.Location = new Point(173, 0);
                tbPhenomenaContent.Size = new Size(430, 420);
                PhenomenaImage pimg = new PhenomenaImage();
                pimg.Location = new Point(0, 0);
                //counter += 155;
                string path = "content\\phenomenas\\" + ((sender as Button).Parent as PhenomenaItem).lblPhenomena.Text + "-" + i + ".gif";
                if (System.IO.File.Exists(path))
                {
                    pimg.pbImage.ImageLocation = path;
                    panel2.Controls.Add(pimg);
                    pimg.btnDelete.Click+=btnDelete_Click;
                    pimg.btnEdit.Click+=btnEdit_Click;
                    pimg.pbImage.Paint += pbImage_Paint;
                    pimg.pbImage.Visible = true;
                }
                RedrawImages();
            }
        }

        void pbImage_Paint(object sender, PaintEventArgs e)
        {
            if ((sender as PictureBox).Image == (sender as PictureBox).ErrorImage)
            {
                panel2.Controls.Remove((sender as PictureBox).Parent);
            }
        }
        void btnDelete2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить явление '" + (((sender as Button).Parent) as PhenomenaItem).lblPhenomena.Text + "'?" + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                File.Delete(@"content\phenomenas\" + (((sender as Button).Parent) as PhenomenaItem).lblPhenomena.Text + ".rtf");
                for (int i = 1; i < 11; i++)
                {
                    try
                    {
                        File.Delete("content\\phenomenas\\" + ((sender as Button).Parent as PhenomenaItem).lblPhenomena.Text + "-" + i + ".gif");
                    }
                    catch (FileNotFoundException)
                    {
                        throw;
                    }
                }
                pnlPhenomenas.Controls.Remove((sender as Button).Parent);
                UpdateList();
            }
        }
        void btnDelete_Click(object sender, EventArgs e)
        {
            panel2.Controls.Remove((sender as Button).Parent);
            PhenomenaImageLocation();
        }
        private void PhenomenaImageLocation()
        {
            int counter = 0;
            if (panel2.Controls.Count>0)
            {
                tbPhenomenaContent.Location = new Point(173, 0);
                tbPhenomenaContent.Size = new Size(430, 420);
            }
            else
            {
                tbPhenomenaContent.Location = new Point(0, 0);
                tbPhenomenaContent.Size = new Size(603, 420);
            }
            foreach (PhenomenaImage pimg in panel2.Controls)
            {
                pimg.Location = new Point(0, counter);
                counter += 155;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            changed = false;
            tbPhenomenaName.Text.Trim();
            tbPhenomenaName.Text = Program.p.ReplaceMultispaces(tbPhenomenaName.Text);
            if (tbPhenomenaName.Text == " " || tbPhenomenaName.Text == "" || tbPhenomenaName.Text == "Название явления" || tbPhenomenaContent.Text == "" || tbPhenomenaContent.Text == "Описание явления")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else { 
                int counter=1;
                File.Delete(@"content\phenomenas\" + oldPhenomenaName + ".rtf");
                for (int i = 1; i < 11; i++)
                {
                    try
                    {
                        File.Delete("content\\phenomenas\\" + oldPhenomenaName + "-" + i + ".gif");
                    }
                    catch (FileNotFoundException)
                    {
                        throw;
                    }
                }
                foreach (PhenomenaImage img in panel2.Controls)
                {
                    img.pbImage.Image.Save("content\\phenomenas\\"+tbPhenomenaName.Text+"-"+counter+".gif", System.Drawing.Imaging.ImageFormat.Gif);
                    counter++;
                }
                tbPhenomenaContent.SaveFile("content\\phenomenas\\" + tbPhenomenaName.Text + ".rtf");
                pnlAdded.Visible = true;
                timer1.Enabled = true;
                panel2.Controls.Clear();
                tbPhenomenaContent.Text="Описание явления";
                tbPhenomenaContent.ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                tbPhenomenaName.Text="Название явления";
                tbPhenomenaName.ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                tbPhenomenaContent.Location = new Point(0, 0);
                tbPhenomenaContent.Size = new Size(856, 420);
                UpdateList();
            }
        }

        private void tbPhenomenaName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            if (s.Text == "Название явления")
            {
                _earlierText = (sender as TextBox).Text;
                s.ForeColor = Color.Black;
                s.Text = "";
            }
        }

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }
        }

        private void tbPhenomenaContent_Enter(object sender, EventArgs e)
        {
            if ((sender as RichTextBox).Text == "Описание явления")
            {
                _earlierText2 = (sender as RichTextBox).Text;
                (sender as RichTextBox).Text = "";
                (sender as RichTextBox).ForeColor = Color.Black;
            }
        }

        private void tbPhenomenaContent_Leave(object sender, EventArgs e)
        {
            if ((sender as RichTextBox).Text == "")
            {
                (sender as RichTextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as RichTextBox).Text = _earlierText2;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (tbPhenomenaContent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = tbPhenomenaContent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (tbPhenomenaContent.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                tbPhenomenaContent.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (tbPhenomenaContent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = tbPhenomenaContent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (tbPhenomenaContent.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                tbPhenomenaContent.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (tbPhenomenaContent.SelectionFont != null)
            {
                System.Drawing.Font currentFont = tbPhenomenaContent.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (tbPhenomenaContent.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                tbPhenomenaContent.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (LastWindow == "NewTask")
                    {
                        Program.InitWindow(Forms.fNewTask);
                        Program.fNewTask.Show();
                        this.Hide();
                    }
                    else if (LastWindow == "EditTaskEntity")
                    {
                        Program.InitWindow(Forms.fEditTaskEntity);
                        Program.fEditTaskEntity.Show();
                        this.Hide();
                    }
                    else
                    {
                        Program.InitWindow(Forms.fModules);
                        Program.fModules.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                if (LastWindow == "NewTask")
                {
                    Program.InitWindow(Forms.fNewTask);
                    Program.fNewTask.Show();
                    this.Hide();
                }
                else if (LastWindow == "EditTaskEntity")
                {
                    Program.InitWindow(Forms.fEditTaskEntity);
                    Program.fEditTaskEntity.Show();
                    this.Hide();
                }
                else
                {
                    Program.InitWindow(Forms.fModules);
                    Program.fModules.Show();
                    this.Hide();
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlAdded.Visible = false;
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
        /* private void btnMyTasks_MouseDown(object sender, MouseEventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks03;
         }
         private void btnMyTasks_MouseEnter(object sender, EventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks02;
         }
         private void btnMyTasks_MouseLeave(object sender, EventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks01;
         }
         private void btnMyTasks_MouseUp(object sender, MouseEventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks02;
         }
         */
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
        private void Form_VisibleChangedOrLoad(object sender, EventArgs e)
        {
            this.Location = Program.currentLocation;
            this.Size = Program.currentSize;
        }

        private void Form_LocationChanged(object sender, EventArgs e)
        {
            Program.currentLocation = this.Location;
        }

        private void FormPhenomenasEditor_SizeChanged(object sender, EventArgs e)
        {
            //tbHypo.Size = new Size(tbHypo.Size.Width, this.Size.Height - 430);
            Program.currentSize=this.Size;
        }

        private void tbPhenomenaContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            changed = true;
        }


    }
}
