﻿namespace PRIZ
{
    partial class FormPhenomenas
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhenomenas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbIdea = new System.Windows.Forms.TextBox();
            this.btnSendToTheNextForm = new System.Windows.Forms.Button();
            this.btnPlusIdea = new System.Windows.Forms.Button();
            this.lIdeas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnLogoCreativeThinker = new System.Windows.Forms.Button();
            this.btnLogoEducationEra = new System.Windows.Forms.Button();
            this.showTaskCond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlPhenomenas = new System.Windows.Forms.Panel();
            this.pnlForHypo = new System.Windows.Forms.Panel();
            this.tbHypo = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(147, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выдвижение гипотиз";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(150, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Явления";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.tbIdea);
            this.panel2.Controls.Add(this.btnSendToTheNextForm);
            this.panel2.Controls.Add(this.btnPlusIdea);
            this.panel2.Controls.Add(this.lIdeas);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 185);
            this.panel2.TabIndex = 0;
            // 
            // tbIdea
            // 
            this.tbIdea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbIdea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdea.Location = new System.Drawing.Point(158, 28);
            this.tbIdea.Multiline = true;
            this.tbIdea.Name = "tbIdea";
            this.tbIdea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIdea.Size = new System.Drawing.Size(475, 107);
            this.tbIdea.TabIndex = 0;
            this.tbIdea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdea_KeyDown);
            this.tbIdea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdea_KeyPress);
            this.tbIdea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbIdea_KeyUp);
            // 
            // btnSendToTheNextForm
            // 
            this.btnSendToTheNextForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSendToTheNextForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendToTheNextForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToTheNextForm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSendToTheNextForm.ForeColor = System.Drawing.Color.White;
            this.btnSendToTheNextForm.Location = new System.Drawing.Point(835, 24);
            this.btnSendToTheNextForm.Name = "btnSendToTheNextForm";
            this.btnSendToTheNextForm.Size = new System.Drawing.Size(109, 32);
            this.btnSendToTheNextForm.TabIndex = 1;
            this.btnSendToTheNextForm.Text = "Отчет";
            this.btnSendToTheNextForm.UseVisualStyleBackColor = false;
            this.btnSendToTheNextForm.Click += new System.EventHandler(this.btnSendToTheNextForm_Click);
            // 
            // btnPlusIdea
            // 
            this.btnPlusIdea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlusIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusIdea.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPlusIdea.ForeColor = System.Drawing.Color.White;
            this.btnPlusIdea.Location = new System.Drawing.Point(659, 24);
            this.btnPlusIdea.Name = "btnPlusIdea";
            this.btnPlusIdea.Size = new System.Drawing.Size(148, 32);
            this.btnPlusIdea.TabIndex = 4;
            this.btnPlusIdea.Text = "Следующая идея";
            this.btnPlusIdea.UseVisualStyleBackColor = false;
            this.btnPlusIdea.Click += new System.EventHandler(this.btnPlusIdea_Click);
            // 
            // lIdeas
            // 
            this.lIdeas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lIdeas.AutoSize = true;
            this.lIdeas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lIdeas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lIdeas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lIdeas.Location = new System.Drawing.Point(656, 120);
            this.lIdeas.Name = "lIdeas";
            this.lIdeas.Size = new System.Drawing.Size(203, 20);
            this.lIdeas.TabIndex = 30;
            this.lIdeas.Text = "Вы не ввели ни одной идеи";
            this.lIdeas.Click += new System.EventHandler(this.lIdeas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackgroundImage = global::PRIZ.Properties.Resources.registration_underlay_big;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(155, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 116);
            this.panel1.TabIndex = 3;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUserName.Location = new System.Drawing.Point(151, 28);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 20);
            this.lbUserName.TabIndex = 16;
            this.lbUserName.Text = "Имя Фамилия";
            // 
            // btnWriteToUs
            // 
            this.btnWriteToUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWriteToUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteToUs.FlatAppearance.BorderSize = 0;
            this.btnWriteToUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWriteToUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWriteToUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteToUs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWriteToUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnWriteToUs.Image = global::PRIZ.Properties.Resources.writeus01;
            this.btnWriteToUs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWriteToUs.Location = new System.Drawing.Point(12, 324);
            this.btnWriteToUs.Name = "btnWriteToUs";
            this.btnWriteToUs.Size = new System.Drawing.Size(111, 68);
            this.btnWriteToUs.TabIndex = 20;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnWriteToUs_MouseLeave);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnAbout.Image = global::PRIZ.Properties.Resources.about01;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(12, 244);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(111, 68);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseDown);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
            // 
            // btnModules
            // 
            this.btnModules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModules.FlatAppearance.BorderSize = 0;
            this.btnModules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnModules.Image = global::PRIZ.Properties.Resources.modules01;
            this.btnModules.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModules.Location = new System.Drawing.Point(12, 164);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(111, 68);
            this.btnModules.TabIndex = 18;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
            // 
            // btnLogoCreativeThinker
            // 
            this.btnLogoCreativeThinker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoCreativeThinker.BackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.BackgroundImage = global::PRIZ.Properties.Resources.Logo_ShKM;
            this.btnLogoCreativeThinker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogoCreativeThinker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoCreativeThinker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.BorderSize = 0;
            this.btnLogoCreativeThinker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoCreativeThinker.Location = new System.Drawing.Point(864, 14);
            this.btnLogoCreativeThinker.Name = "btnLogoCreativeThinker";
            this.btnLogoCreativeThinker.Size = new System.Drawing.Size(114, 93);
            this.btnLogoCreativeThinker.TabIndex = 21;
            this.btnLogoCreativeThinker.UseVisualStyleBackColor = false;
            this.btnLogoCreativeThinker.Click += new System.EventHandler(this.btnLogoCreativeThinker_Click_1);
            // 
            // btnLogoEducationEra
            // 
            this.btnLogoEducationEra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoEducationEra.BackgroundImage = global::PRIZ.Properties.Resources.logo_educationfornewera;
            this.btnLogoEducationEra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoEducationEra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoEducationEra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.BorderSize = 0;
            this.btnLogoEducationEra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoEducationEra.Location = new System.Drawing.Point(739, 10);
            this.btnLogoEducationEra.Name = "btnLogoEducationEra";
            this.btnLogoEducationEra.Size = new System.Drawing.Size(121, 99);
            this.btnLogoEducationEra.TabIndex = 20;
            this.btnLogoEducationEra.UseVisualStyleBackColor = true;
            this.btnLogoEducationEra.Click += new System.EventHandler(this.btnLogoEducationEra_Click);
            // 
            // showTaskCond
            // 
            this.showTaskCond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showTaskCond.AutoSize = true;
            this.showTaskCond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTaskCond.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTaskCond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.showTaskCond.Location = new System.Drawing.Point(151, 514);
            this.showTaskCond.Name = "showTaskCond";
            this.showTaskCond.Size = new System.Drawing.Size(119, 20);
            this.showTaskCond.TabIndex = 29;
            this.showTaskCond.Text = "Условие задачи";
            this.showTaskCond.Click += new System.EventHandler(this.showTaskCond_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(51, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 31;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlPhenomenas
            // 
            this.pnlPhenomenas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPhenomenas.AutoScroll = true;
            this.pnlPhenomenas.BackColor = System.Drawing.Color.White;
            this.pnlPhenomenas.Location = new System.Drawing.Point(151, 155);
            this.pnlPhenomenas.Name = "pnlPhenomenas";
            this.pnlPhenomenas.Size = new System.Drawing.Size(182, 327);
            this.pnlPhenomenas.TabIndex = 32;
            // 
            // pnlForHypo
            // 
            this.pnlForHypo.AutoScroll = true;
            this.pnlForHypo.BackColor = System.Drawing.Color.White;
            this.pnlForHypo.Location = new System.Drawing.Point(0, 0);
            this.pnlForHypo.Name = "pnlForHypo";
            this.pnlForHypo.Size = new System.Drawing.Size(167, 327);
            this.pnlForHypo.TabIndex = 34;
            // 
            // tbHypo
            // 
            this.tbHypo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHypo.Location = new System.Drawing.Point(173, 0);
            this.tbHypo.Name = "tbHypo";
            this.tbHypo.ReadOnly = true;
            this.tbHypo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbHypo.Size = new System.Drawing.Size(429, 327);
            this.tbHypo.TabIndex = 0;
            this.tbHypo.Text = "";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.tbHypo);
            this.panel3.Controls.Add(this.pnlForHypo);
            this.panel3.Location = new System.Drawing.Point(342, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 327);
            this.panel3.TabIndex = 35;
            // 
            // FormPhenomenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.pnlPhenomenas);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showTaskCond);
            this.Controls.Add(this.btnLogoEducationEra);
            this.Controls.Add(this.btnLogoCreativeThinker);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormPhenomenas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ПРИЗ";
            this.Load += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.tbForText_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.Click += new System.EventHandler(this.tbForText_SizeChanged);
            this.Leave += new System.EventHandler(this.LabelLostFokus);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendToTheNextForm;
        private System.Windows.Forms.TextBox tbIdea;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnLogoCreativeThinker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlusIdea;
        private System.Windows.Forms.Button btnLogoEducationEra;
        private System.Windows.Forms.Label showTaskCond;
        private System.Windows.Forms.Label lIdeas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlPhenomenas;
        private System.Windows.Forms.Panel pnlForHypo;
        private System.Windows.Forms.RichTextBox tbHypo;
        private System.Windows.Forms.Panel panel3;
    }
}