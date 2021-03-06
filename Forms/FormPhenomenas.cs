﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PRIZ
{
    public partial class FormPhenomenas : Form
    {
        Answer answer = Program.p.answer;
        PictureBox tempPB;
        List<Label> phenomenaLabels;
        private Trestan.TRichTextBox richTextBox1;
        public FormPhenomenas()
        {
            InitializeComponent();
            if (Program.p.AdminMode)
            {
                lbUserName.Visible = false;
                label3.Visible = false;
            }
            this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.richTextBox1 = new Trestan.TRichTextBox();
            this.Location = Program.currentLocation;
            lbUserName.Text = Program.p.CurrentFullName;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);

            DirectoryInfo dir = new DirectoryInfo(@"content\phenomenas");
            int counter = 5;
            foreach (var item in dir.GetFiles())
            {
                string tempName = item.Name;
                Label phitem = new Label();
                phitem.Location = new Point(0, counter);
                phitem.AutoSize = true;
                phitem.Cursor = Cursors.Hand;
                phitem.BackColor = Color.Transparent;
                phitem.Text = tempName.Remove(tempName.LastIndexOf(@"."));
                phitem.Size = new Size(100, 20);
                phitem.Click += phitem_Click;
                if (Program.p.currentTask._phenomenas.IndexOf(phitem.Text)>-1 && tempName.IndexOf(@".rtf")>-1)
                {
                    pnlPhenomenas.Controls.Add(phitem);
                    if (counter == 5)
                    {
                        phitem.Font = new Font("Segoue UI", 11F, FontStyle.Bold);
                        phitem.ForeColor = Color.FromArgb(255, 40, 179, 151);
                        tbHypo.LoadFile(@"content/phenomenas/" + phitem.Text + ".rtf", RichTextBoxStreamType.RichText);
                        try
                        {
                            for (int i = 1; i < 11; i++)
                            {
                                tbHypo.Location = new Point(515, 155);
                                tbHypo.Size = new Size(429, 327);
                                PhenomenaImage pimg = new PhenomenaImage();
                                pimg.Location = new Point(0, 0);
                                pimg.btnDelete.Visible = false;
                                pimg.btnEdit.Visible = false;
                                pimg.Cursor = Cursors.Hand;
                                //counter += 155;
                                string path = "content\\phenomenas\\" + phitem.Text + "-" + i + ".gif";
                                if (System.IO.File.Exists(path))
                                {
                                    pimg.pbImage.ImageLocation = path;
                                    pnlForHypo.Controls.Add(pimg);
                                    pimg.pbImage.Paint += pbImage_Paint;
                                    pimg.pbImage.Visible = true;
                                    pimg.pbImage.Click += pimg_Click;
                                }
                                RedrawImages();
                            }
                        }
                        catch (System.IO.FileNotFoundException)
                        {

                        }
                    }
                    else
                    {
                        phitem.Font = new Font("Segoue UI", 11F, FontStyle.Regular);
                        phitem.ForeColor = Color.FromArgb(255, 103, 103, 103);
                    }
                    counter += 25;
                }
            }
            if (Program.debug)
            {
                answer._hypothesises.Add("Одна из идей заключается в планомерном распределении всех параметров, что не может не являться очевидным при дальнейшем развитии событий");
                answer._hypothesises.Add("Возможно вероятность случайных событий сильно преувеличена, что влечет за собой потери смысла всех проведенных исследований");
                answer._hypothesises.Add("Не исключено, что у нас просто недостаточно данных для совершение каких либо умозаключений");
                lIdeas.Text = "Количество идей: " + answer._hypothesises.Count;
                lIdeas.Font = new Font("Segoue UI", 11F, FontStyle.Underline);
            }
        }

        void phitem_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlPhenomenas.Controls)
	        {
                (item as Label).ForeColor = Color.FromArgb(255, 103, 103, 103);
                (item as Label).Font = new Font("Segoue UI", 11F, FontStyle.Regular);
	        }
            (sender as Label).ForeColor = Color.FromArgb(255, 40, 179, 151);
            (sender as Label).Font = new Font("Segoue UI", 11F, FontStyle.Bold);
            pnlForHypo.Controls.Clear();
            try
            {
                for (int i = 1; i < 11; i++)
                {
                    tbHypo.Location = new Point(515, 155);
                    tbHypo.Size = new Size(429, 327);
                    PhenomenaImage pimg = new PhenomenaImage();
                    pimg.Location = new Point(0, 0);
                    pimg.btnDelete.Visible = false;
                    pimg.btnEdit.Visible = false;
                    pimg.Cursor = Cursors.Hand;
                    //counter += 155;
                    string path = "content\\phenomenas\\" + (sender as Label).Text + "-" + i + ".gif";
                    if (System.IO.File.Exists(path))
                    {
                        pimg.pbImage.ImageLocation = path;
                        pnlForHypo.Controls.Add(pimg);
                        pimg.pbImage.Paint += pbImage_Paint;
                        pimg.pbImage.Visible = true;
                        pimg.pbImage.Click += pimg_Click;
                    }
                    RedrawImages();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                
            }
            try
            {
                tbHypo.LoadFile(@"content/phenomenas/"+ (sender as Label).Text +".rtf", RichTextBoxStreamType.RichText);
            }
            catch (System.IO.FileNotFoundException)
            {
                tbHypo.Text = "Справочный файл удален или поврежден";
            }
            
        }

        void pimg_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fFullImage);
            (sender as PictureBox).Visible = false;
            Program.fFullImage.pictureBox1.Image = (sender as PictureBox).Image;
            tempPB = (sender as PictureBox);
            Program.fFullImage.Show();
            Program.fFullImage.FormClosed += fFullImage_FormClosed;
        }
        void RedrawImages()
        {
            int counter=0;
            foreach (PhenomenaImage pimg in pnlForHypo.Controls)
            {
                pimg.Location = new Point(0, counter);
                counter += 155;
            }
            if (pnlForHypo.Controls.Count==0)
            {
                tbHypo.Location = new Point(0, 0);
                tbHypo.Size = new Size(602, 327);
            }
            else
            {
                tbHypo.Location = new Point(173, 0);
                tbHypo.Size = new Size(429, 327);
            }
        }
        void pbImage_Paint(object sender, PaintEventArgs e)
        {
            if ((sender as PictureBox).Image == (sender as PictureBox).ErrorImage)
            {
                pnlForHypo.Controls.Remove((sender as PictureBox).Parent);
            }
        }

        string CleanFromSpaces(string t)
        {
            t = Regex.Replace(t, "[ \t]{2,}", " ");
            t = Regex.Replace(t, "[\\s]{2,}", Environment.NewLine);
            return t;
        }

        private void btnPlusIdea_Click(object sender, EventArgs e)
        {
            tbIdea.Focus();
            if (tbIdea.Text != "")
            {
                tbIdea.Text = CleanFromSpaces(tbIdea.Text);
                answer._hypothesises.Add(tbIdea.Text);
                tbIdea.Clear();
                lIdeas.Text = "Количество идей: " + answer._hypothesises.Count;
                lIdeas.Font = new Font("Segoue UI", 11F, FontStyle.Underline);
            }
        }
        private void tb_MouseWheel(object sender, EventArgs e)
        {
            pnlForHypo.Focus();
        }
        private void btnSendToTheNextForm_Click(object sender, EventArgs e)
        {
            if (tbIdea.Text != "" || answer._hypothesises.Count > 0)
            {
                if (tbIdea.Text != "")
                {
                    answer._hypothesises.Add(tbIdea.Text);
                    tbIdea.Clear();
                }
                Program.InitWindow(Forms.fAllIdeas);
                Program.fAllIdeas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введите хотя бы одну идею, прежде чем продолжить.");
            }
            
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {

            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.Show();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Переход на другое окно", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fModules);
                Program.fModules.Show();
                this.Hide();
                answer._hypothesises.Clear();
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
        private void tbForText_SizeChanged(object sender, EventArgs e)
        {
            tbHypo.Size = new Size(tbHypo.Size.Width, this.Size.Height - 430);
            Program.currentSize=this.Size;
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

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            //this.Hide();
            Program.fAboutEducation.ShowDialog();
        }

        private void btnLogoCreativeThinker_Click_1(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void ClickToLabel(object sender, EventArgs e)
        {
            foreach (Label phenomenaLabel in phenomenaLabels)
            {
                phenomenaLabel.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular);
                phenomenaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            }
            Label lbl = sender as Label;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            try
            {
                switch (lbl.Name)
                {
                    case "lblSound":
                        tbHypo.LoadFile(@"content/textSound.rtf", RichTextBoxStreamType.RichText);
                        break;
                    case "lblMagnetic":
                        tbHypo.LoadFile(@"content/textMagnetic.rtf", RichTextBoxStreamType.RichText);
                        break;
                    case "lblElectrical":
                        tbHypo.LoadFile(@"content/textElectrical.rtf", RichTextBoxStreamType.RichText);
                        break;
                    case "lblThermal":
                        tbHypo.LoadFile(@"content/textThermal.rtf", RichTextBoxStreamType.RichText);
                        break;
                    case "lblMechanical":
                        tbHypo.LoadFile(@"content/textMechanical.rtf", RichTextBoxStreamType.RichText);
                        break;
                    case "lblLight":
                        tbHypo.LoadFile(@"content/textLight.rtf", RichTextBoxStreamType.RichText);
                        break;
                    default:
                        break;
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                tbHypo.Text = "Справочный файл удален или поврежден";
            }
            //tbHypo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
        }

        static string _elderText;
        private void LabelGotFokus(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            _elderText = lbl.Text;
            lbl.Text = lbl.Text + " >";
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(237)))), ((int)(((byte)(193)))));
        }
        private void LabelLostFokus(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Text = _elderText;
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
        }

        private void LabelGotFokus(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fLogin);
                answer._hypothesises.Clear();
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

        private void showTaskCond_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.p.currentTask._name  + "\r\n\r\n" + Program.p.currentTask._description, "Условие задачи");
        }

        private void lIdeas_Click(object sender, EventArgs e)
        {
            //вывод всех идей
            string h = "Гипотезы:\n\n";
            if (tbIdea.Text!="")
            {
                tbIdea.Text = CleanFromSpaces(tbIdea.Text);
                answer._hypothesises.Add(tbIdea.Text);
                tbIdea.Clear();
                lIdeas.Text = "Количество идей: " + answer._hypothesises.Count;
                lIdeas.Font = new Font("Segoue UI", 11F, FontStyle.Underline);
            }
            if (answer._hypothesises.Count>0)
            {
                for (int i = 0; i < answer._hypothesises.Count; i++)
                {
                    h +=answer._hypothesises[i];
                    h += "\n\n";
                }
                //MessageBox.Show(h, "Гипотезы");
                Program.InitWindow(Forms.fShowAllIdeas);
                Program.fShowAllIdeas.ShowDialog();
            }
        }
        public void RefreshlIdeas() 
        {
            lIdeas.Text = "Количество идей: " + answer._hypothesises.Count;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.fTask.WindowState = Program.fPhenomenas.WindowState;
            Program.fTask.Size = Program.fPhenomenas.Size;
            Program.fTask.Location = Program.fPhenomenas.Location;
            Program.fTask.Show();
            this.Hide();
            answer._hypothesises.Clear();
        }

        private void tbIdea_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                if (tbIdea.Text != "")
                {
                    e.Handled = true;
                    answer._hypothesises.Add(tbIdea.Text);
                    tbIdea.Clear();
                    lIdeas.Text = "Количество идей: " + answer._hypothesises.Count;
                    lIdeas.Font = new Font("Segoue UI", 11F, FontStyle.Underline);
                }
                return;
            }
        }

        private void tbIdea_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void tbIdea_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ' ':
                    if (tbIdea.Text.Length == 0)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (tbIdea.Text[tbIdea.Text.Length - 1] == ' ')
                            e.Handled = true;
                    }
                    break;
                case (char)13:
                    if (tbIdea.Text.Length == 0)
                    {
                        e.Handled = true;
                    }
                    else
                    if (tbIdea.Text[tbIdea.Text.Length - 1] == '\n')
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
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

        private void pbHypo_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                tbHypo.Location = new Point(3, 3);
                tbHypo.Size = new Size(599, 321);
            }
        }

        private void pbHypo_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fFullImage);
            (sender as PictureBox).Visible = false;
            Program.fFullImage.pictureBox1.Image = (sender as PictureBox).Image;
            tempPB = (sender as PictureBox);
            Program.fFullImage.Show();
            Program.fFullImage.FormClosed += fFullImage_FormClosed;
        }

        void fFullImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            tempPB.Visible = true;
        }
    }
}


