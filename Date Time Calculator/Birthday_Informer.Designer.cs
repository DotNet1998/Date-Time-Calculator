namespace Date_Time_Calculator
{
    partial class Birthday_Informer
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.countYears = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.go = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.NYEARS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.countLive = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.brth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.doNextBirthday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.Unix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countYears)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel5);
            this.guna2Panel1.Controls.Add(this.guna2Panel8);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(833, 372);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.countYears);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel8.Location = new System.Drawing.Point(112, 322);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(600, 34);
            this.guna2Panel8.TabIndex = 22;
            // 
            // countYears
            // 
            this.countYears.BackColor = System.Drawing.Color.Transparent;
            this.countYears.BorderColor = System.Drawing.Color.Silver;
            this.countYears.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countYears.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countYears.Location = new System.Drawing.Point(295, 5);
            this.countYears.Name = "countYears";
            this.countYears.Size = new System.Drawing.Size(50, 23);
            this.countYears.TabIndex = 34;
            this.countYears.UpDownButtonFillColor = System.Drawing.Color.Gainsboro;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(49, 7);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(244, 23);
            this.guna2HtmlLabel3.TabIndex = 33;
            this.guna2HtmlLabel3.Text = "Через сколько вам исполнится: ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel3.Controls.Add(this.go);
            this.guna2Panel3.Controls.Add(this.guna2Panel2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.guna2Panel7);
            this.guna2Panel3.Location = new System.Drawing.Point(87, 62);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(656, 254);
            this.guna2Panel3.TabIndex = 21;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(93, 17);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(189, 23);
            this.guna2HtmlLabel12.TabIndex = 32;
            this.guna2HtmlLabel12.Text = "Введи дату рождения";
            // 
            // go
            // 
            this.go.BorderColor = System.Drawing.Color.Silver;
            this.go.BorderRadius = 14;
            this.go.BorderThickness = 1;
            this.go.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.go.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.go.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.go.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.go.FillColor = System.Drawing.Color.Gainsboro;
            this.go.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.go.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.go.Location = new System.Drawing.Point(552, 59);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(91, 173);
            this.go.TabIndex = 29;
            this.go.Text = "Go";
            this.go.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.NYEARS);
            this.guna2Panel2.Controls.Add(this.countLive);
            this.guna2Panel2.Controls.Add(this.brth);
            this.guna2Panel2.Controls.Add(this.doNextBirthday);
            this.guna2Panel2.Location = new System.Drawing.Point(71, 59);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(475, 169);
            this.guna2Panel2.TabIndex = 31;
            // 
            // NYEARS
            // 
            this.NYEARS.AutoSize = false;
            this.NYEARS.BackColor = System.Drawing.Color.Transparent;
            this.NYEARS.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NYEARS.Location = new System.Drawing.Point(8, 134);
            this.NYEARS.Name = "NYEARS";
            this.NYEARS.Size = new System.Drawing.Size(433, 19);
            this.NYEARS.TabIndex = 15;
            this.NYEARS.Text = "N лет исполнится через:";
            // 
            // countLive
            // 
            this.countLive.AutoSize = false;
            this.countLive.BackColor = System.Drawing.Color.Transparent;
            this.countLive.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLive.Location = new System.Drawing.Point(6, 13);
            this.countLive.Name = "countLive";
            this.countLive.Size = new System.Drawing.Size(417, 23);
            this.countLive.TabIndex = 11;
            this.countLive.Text = "Сколько живет:";
            // 
            // brth
            // 
            this.brth.AutoSize = false;
            this.brth.BackColor = System.Drawing.Color.Transparent;
            this.brth.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brth.Location = new System.Drawing.Point(6, 92);
            this.brth.Name = "brth";
            this.brth.Size = new System.Drawing.Size(450, 19);
            this.brth.TabIndex = 14;
            this.brth.Text = "18 лет исполнилось:";
            // 
            // doNextBirthday
            // 
            this.doNextBirthday.AutoSize = false;
            this.doNextBirthday.BackColor = System.Drawing.Color.Transparent;
            this.doNextBirthday.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doNextBirthday.Location = new System.Drawing.Point(6, 51);
            this.doNextBirthday.Name = "doNextBirthday";
            this.doNextBirthday.Size = new System.Drawing.Size(466, 26);
            this.doNextBirthday.TabIndex = 11;
            this.doNextBirthday.Text = " До следующего день рождения :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.Image = global::Date_Time_Calculator.Properties.Resources._11;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(244, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(145, 48);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Location = new System.Drawing.Point(104, 254);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(600, 24);
            this.guna2Panel7.TabIndex = 22;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(217, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(444, 68);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Birthday Informer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm";
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(364, 19);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.guna2DateTimePicker1.TabIndex = 34;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.Unix);
            this.guna2Panel5.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(135, 31);
            this.guna2Panel5.TabIndex = 35;
            // 
            // Unix
            // 
            this.Unix.AutoSize = false;
            this.Unix.BackColor = System.Drawing.Color.Transparent;
            this.Unix.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unix.Location = new System.Drawing.Point(4, 7);
            this.Unix.Name = "Unix";
            this.Unix.Size = new System.Drawing.Size(121, 20);
            this.Unix.TabIndex = 23;
            this.Unix.Text = "Unix TS:";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Birthday_Informer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Birthday_Informer";
            this.Size = new System.Drawing.Size(839, 385);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countYears)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel NYEARS;
        private Guna.UI2.WinForms.Guna2HtmlLabel brth;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel doNextBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel countLive;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown countYears;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button go;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel Unix;
        private System.Windows.Forms.Timer timer2;
    }
}
