namespace Date_Time_Calculator.UserControls
{
    partial class Date_Working_Counter
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Sunday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Saturday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Friday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Thursday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Wednesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Tuesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Monday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.res = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.Unix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.guna2DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel5);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(833, 364);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Location = new System.Drawing.Point(81, 74);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(683, 239);
            this.guna2Panel2.TabIndex = 19;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Location = new System.Drawing.Point(565, 112);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(75, 96);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Go";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel3.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel3.Controls.Add(this.guna2DateTimePicker2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.Sunday);
            this.guna2Panel3.Controls.Add(this.Saturday);
            this.guna2Panel3.Controls.Add(this.Friday);
            this.guna2Panel3.Controls.Add(this.Thursday);
            this.guna2Panel3.Controls.Add(this.Wednesday);
            this.guna2Panel3.Controls.Add(this.Tuesday);
            this.guna2Panel3.Controls.Add(this.Monday);
            this.guna2Panel3.Location = new System.Drawing.Point(17, 8);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(649, 74);
            this.guna2Panel3.TabIndex = 23;
            // 
            // Sunday
            // 
            this.Sunday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sunday.CheckedState.BorderRadius = 0;
            this.Sunday.CheckedState.BorderThickness = 0;
            this.Sunday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.Location = new System.Drawing.Point(419, 53);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(47, 17);
            this.Sunday.TabIndex = 16;
            this.Sunday.Text = "ВСК\\";
            this.Sunday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sunday.UncheckedState.BorderRadius = 0;
            this.Sunday.UncheckedState.BorderThickness = 0;
            this.Sunday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Saturday
            // 
            this.Saturday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Saturday.CheckedState.BorderRadius = 0;
            this.Saturday.CheckedState.BorderThickness = 0;
            this.Saturday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.Location = new System.Drawing.Point(380, 53);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(47, 17);
            this.Saturday.TabIndex = 15;
            this.Saturday.Text = "СБ\\";
            this.Saturday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Saturday.UncheckedState.BorderRadius = 0;
            this.Saturday.UncheckedState.BorderThickness = 0;
            this.Saturday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Friday
            // 
            this.Friday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Friday.CheckedState.BorderRadius = 0;
            this.Friday.CheckedState.BorderThickness = 0;
            this.Friday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.Location = new System.Drawing.Point(340, 53);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(47, 17);
            this.Friday.TabIndex = 14;
            this.Friday.Text = "ПТ\\";
            this.Friday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Friday.UncheckedState.BorderRadius = 0;
            this.Friday.UncheckedState.BorderThickness = 0;
            this.Friday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Thursday
            // 
            this.Thursday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Thursday.CheckedState.BorderRadius = 0;
            this.Thursday.CheckedState.BorderThickness = 0;
            this.Thursday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.Location = new System.Drawing.Point(300, 53);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(47, 17);
            this.Thursday.TabIndex = 13;
            this.Thursday.Text = "ЧТ\\";
            this.Thursday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Thursday.UncheckedState.BorderRadius = 0;
            this.Thursday.UncheckedState.BorderThickness = 0;
            this.Thursday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Wednesday
            // 
            this.Wednesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Wednesday.CheckedState.BorderRadius = 0;
            this.Wednesday.CheckedState.BorderThickness = 0;
            this.Wednesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.Location = new System.Drawing.Point(261, 53);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(47, 17);
            this.Wednesday.TabIndex = 12;
            this.Wednesday.Text = "СР\\";
            this.Wednesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Wednesday.UncheckedState.BorderRadius = 0;
            this.Wednesday.UncheckedState.BorderThickness = 0;
            this.Wednesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Tuesday
            // 
            this.Tuesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tuesday.CheckedState.BorderRadius = 0;
            this.Tuesday.CheckedState.BorderThickness = 0;
            this.Tuesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.Location = new System.Drawing.Point(222, 53);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(47, 17);
            this.Tuesday.TabIndex = 11;
            this.Tuesday.Text = "ВТ\\";
            this.Tuesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tuesday.UncheckedState.BorderRadius = 0;
            this.Tuesday.UncheckedState.BorderThickness = 0;
            this.Tuesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Monday
            // 
            this.Monday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Monday.CheckedState.BorderRadius = 0;
            this.Monday.CheckedState.BorderThickness = 0;
            this.Monday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.Location = new System.Drawing.Point(181, 53);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(47, 17);
            this.Monday.TabIndex = 10;
            this.Monday.Text = "ПН\\";
            this.Monday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UncheckedState.BorderRadius = 0;
            this.Monday.UncheckedState.BorderThickness = 0;
            this.Monday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.res);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel4.Location = new System.Drawing.Point(122, 112);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(404, 96);
            this.guna2Panel4.TabIndex = 22;
            // 
            // res
            // 
            this.res.AutoSize = false;
            this.res.BackColor = System.Drawing.Color.Transparent;
            this.res.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(312, 35);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(55, 23);
            this.res.TabIndex = 13;
            this.res.Text = "0  ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(11, 35);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(295, 23);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Между датами прошло робочих дней:  ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(169, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(526, 68);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Date Working Counter";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(35, 18);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(295, 23);
            this.guna2HtmlLabel2.TabIndex = 12;
            this.guna2HtmlLabel2.Text = "Между датами прошло робочих дней:  ";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.Unix);
            this.guna2Panel5.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(135, 31);
            this.guna2Panel5.TabIndex = 23;
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm";
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(143, 16);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.guna2DateTimePicker1.TabIndex = 39;
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm";
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(377, 16);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.guna2DateTimePicker2.TabIndex = 38;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.Image = global::Date_Time_Calculator.Properties.Resources._11;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(259, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(145, 53);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 37;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Date_Working_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Date_Working_Counter";
            this.Size = new System.Drawing.Size(839, 385);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CheckBox Sunday;
        private Guna.UI2.WinForms.Guna2CheckBox Saturday;
        private Guna.UI2.WinForms.Guna2CheckBox Friday;
        private Guna.UI2.WinForms.Guna2CheckBox Thursday;
        private Guna.UI2.WinForms.Guna2CheckBox Wednesday;
        private Guna.UI2.WinForms.Guna2CheckBox Tuesday;
        private Guna.UI2.WinForms.Guna2CheckBox Monday;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel res;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel Unix;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
