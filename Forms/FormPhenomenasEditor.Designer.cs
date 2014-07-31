namespace PRIZ
{
    partial class FormPhenomenasEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhenomenasEditor));
            this.tbPhenomenaContent = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPhenomenaName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAdded = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPhenomenas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAdded.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPhenomenaContent
            // 
            this.tbPhenomenaContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhenomenaContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPhenomenaContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhenomenaContent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhenomenaContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbPhenomenaContent.Location = new System.Drawing.Point(0, 0);
            this.tbPhenomenaContent.Name = "tbPhenomenaContent";
            this.tbPhenomenaContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbPhenomenaContent.Size = new System.Drawing.Size(603, 420);
            this.tbPhenomenaContent.TabIndex = 3;
            this.tbPhenomenaContent.Text = "Описание явления";
            this.tbPhenomenaContent.TextChanged += new System.EventHandler(this.tbPhenomenaName_TextChanged);
            this.tbPhenomenaContent.Enter += new System.EventHandler(this.tbPhenomenaContent_Enter);
            this.tbPhenomenaContent.Leave += new System.EventHandler(this.tbPhenomenaContent_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUnderline);
            this.panel1.Controls.Add(this.btnItalic);
            this.panel1.Controls.Add(this.btnBold);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Location = new System.Drawing.Point(0, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 160);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(890, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnderline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnderline.ForeColor = System.Drawing.Color.White;
            this.btnUnderline.Location = new System.Drawing.Point(255, 66);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(31, 31);
            this.btnUnderline.TabIndex = 15;
            this.btnUnderline.Text = "П";
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnItalic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnItalic.ForeColor = System.Drawing.Color.White;
            this.btnItalic.Location = new System.Drawing.Point(218, 66);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(31, 31);
            this.btnItalic.TabIndex = 14;
            this.btnItalic.Text = "К";
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBold.ForeColor = System.Drawing.Color.White;
            this.btnBold.Location = new System.Drawing.Point(181, 66);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(31, 31);
            this.btnBold.TabIndex = 13;
            this.btnBold.Text = "Ж";
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(12, 66);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(163, 31);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Добавить изображение";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 420);
            this.panel2.TabIndex = 2;
            // 
            // tbPhenomenaName
            // 
            this.tbPhenomenaName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhenomenaName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.tbPhenomenaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbPhenomenaName.Location = new System.Drawing.Point(299, 53);
            this.tbPhenomenaName.Multiline = true;
            this.tbPhenomenaName.Name = "tbPhenomenaName";
            this.tbPhenomenaName.Size = new System.Drawing.Size(430, 44);
            this.tbPhenomenaName.TabIndex = 2;
            this.tbPhenomenaName.Text = "Название явления";
            this.tbPhenomenaName.TextChanged += new System.EventHandler(this.tbPhenomenaName_TextChanged);
            this.tbPhenomenaName.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.tbPhenomenaName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhenomenaName_KeyPress);
            this.tbPhenomenaName.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnBack.TabIndex = 36;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnWriteToUs
            // 
            this.btnWriteToUs.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnWriteToUs.TabIndex = 34;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnAbout.TabIndex = 33;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseDown);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
            // 
            // btnModules
            // 
            this.btnModules.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnModules.TabIndex = 32;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
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
            this.lbUserName.TabIndex = 37;
            this.lbUserName.Text = "Имя Фамилия";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.tbPhenomenaContent);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(126, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 420);
            this.panel3.TabIndex = 38;
            // 
            // pnlAdded
            // 
            this.pnlAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlAdded.Controls.Add(this.label1);
            this.pnlAdded.Location = new System.Drawing.Point(-11, 167);
            this.pnlAdded.Name = "pnlAdded";
            this.pnlAdded.Size = new System.Drawing.Size(1033, 216);
            this.pnlAdded.TabIndex = 16;
            this.pnlAdded.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(328, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Явление успешно добавлено";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlPhenomenas
            // 
            this.pnlPhenomenas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPhenomenas.AutoScroll = true;
            this.pnlPhenomenas.Location = new System.Drawing.Point(731, 103);
            this.pnlPhenomenas.Name = "pnlPhenomenas";
            this.pnlPhenomenas.Size = new System.Drawing.Size(273, 420);
            this.pnlPhenomenas.TabIndex = 39;
            // 
            // FormPhenomenasEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.pnlAdded);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.tbPhenomenaName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPhenomenas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormPhenomenasEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактор явлений";
            this.Load += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.FormPhenomenasEditor_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlAdded.ResumeLayout(false);
            this.pnlAdded.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbPhenomenaContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPhenomenaName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAdded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlPhenomenas;
    }
}