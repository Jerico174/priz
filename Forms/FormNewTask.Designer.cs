﻿namespace PRIZ
{
    partial class FormNewTask
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTask));
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbGiven = new System.Windows.Forms.TextBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlAdded = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPhenomenas = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAddPhenomenas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bntCheckAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlAdded.SuspendLayout();
            this.pnlAddPhenomenas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(811, 633);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(162, 31);
            this.btnAddTask.TabIndex = 42;
            this.btnAddTask.Text = "Добавить задание";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tbGiven
            // 
            this.tbGiven.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGiven.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.tbGiven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbGiven.Location = new System.Drawing.Point(610, 182);
            this.tbGiven.Multiline = true;
            this.tbGiven.Name = "tbGiven";
            this.tbGiven.Size = new System.Drawing.Size(363, 206);
            this.tbGiven.TabIndex = 3;
            this.tbGiven.Text = "Описание задания";
            this.tbGiven.Enter += new System.EventHandler(this.descFrom_Enter);
            this.tbGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiven_KeyPress);
            this.tbGiven.Leave += new System.EventHandler(this.descFrom_Leave);
            // 
            // tbTaskName
            // 
            this.tbTaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTaskName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbTaskName.Location = new System.Drawing.Point(610, 117);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(363, 46);
            this.tbTaskName.TabIndex = 2;
            this.tbTaskName.Text = "Название задания";
            this.tbTaskName.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.tbTaskName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.tbTaskName.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::PRIZ.Properties.Resources.iconimage;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(155, 117);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(430, 270);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 38;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlAdded
            // 
            this.pnlAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlAdded.Controls.Add(this.label1);
            this.pnlAdded.Location = new System.Drawing.Point(-4, 171);
            this.pnlAdded.Name = "pnlAdded";
            this.pnlAdded.Size = new System.Drawing.Size(1016, 216);
            this.pnlAdded.TabIndex = 0;
            this.pnlAdded.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(388, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание добавлено";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(151, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Имя Фамилия";
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
            this.btnAbout.TabIndex = 47;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseDown);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
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
            this.btnWriteToUs.TabIndex = 48;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnWriteToUs_MouseLeave);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
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
            this.btnModules.TabIndex = 46;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
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
            this.btnBack.TabIndex = 45;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.label3.TabIndex = 44;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(147, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Новое задание";
            // 
            // pnlPhenomenas
            // 
            this.pnlPhenomenas.AutoScroll = true;
            this.pnlPhenomenas.Location = new System.Drawing.Point(155, 469);
            this.pnlPhenomenas.Name = "pnlPhenomenas";
            this.pnlPhenomenas.Size = new System.Drawing.Size(430, 143);
            this.pnlPhenomenas.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(148, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 38);
            this.label5.TabIndex = 78;
            this.label5.Text = "Выберите нужные явления";
            // 
            // pnlAddPhenomenas
            // 
            this.pnlAddPhenomenas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddPhenomenas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlAddPhenomenas.Controls.Add(this.label6);
            this.pnlAddPhenomenas.Location = new System.Drawing.Point(155, 438);
            this.pnlAddPhenomenas.Name = "pnlAddPhenomenas";
            this.pnlAddPhenomenas.Size = new System.Drawing.Size(430, 175);
            this.pnlAddPhenomenas.TabIndex = 80;
            this.pnlAddPhenomenas.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(73, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Явлений не найдено";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntCheckAll
            // 
            this.bntCheckAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntCheckAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCheckAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.bntCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCheckAll.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntCheckAll.ForeColor = System.Drawing.Color.Black;
            this.bntCheckAll.Location = new System.Drawing.Point(155, 438);
            this.bntCheckAll.Name = "bntCheckAll";
            this.bntCheckAll.Size = new System.Drawing.Size(430, 31);
            this.bntCheckAll.TabIndex = 81;
            this.bntCheckAll.Text = "Добавить всё";
            this.bntCheckAll.UseVisualStyleBackColor = false;
            this.bntCheckAll.Click += new System.EventHandler(this.bntCheckAll_Click);
            // 
            // FormNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.pnlAddPhenomenas);
            this.Controls.Add(this.pnlAdded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlPhenomenas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.tbGiven);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.bntCheckAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ПРИЗ";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlAdded.ResumeLayout(false);
            this.pnlAdded.PerformLayout();
            this.pnlAddPhenomenas.ResumeLayout(false);
            this.pnlAddPhenomenas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox tbGiven;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlAdded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPhenomenas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAddPhenomenas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntCheckAll;
    }
}