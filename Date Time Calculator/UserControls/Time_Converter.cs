using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Date_Time_Calculator.UserControls
{
    public partial class Time_Converter : UserControl
    {
        public Time_Converter()
        {
            InitializeComponent();
            timer1.Start();
            unix();
        }
        public void unix()
        {
            DateTime foo = DateTime.Now;
            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
            Unix.Text = $"Unix TS: {unixTime.ToString()}";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x = Convert.ToInt32(vvod.Text);



            if (ComboBox1.Text == "Лет")  // ГОДА
            {
                if (ComboBox2.Text == "Лет")

                {
                    y = x;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Месяцев")

                {

                    y = x * 12;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Дней")

                {
                    y = x * 365;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Часов")

                {
                    y = x * 8760;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Минут")

                {
                    y = x * 525600;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x * 31536000;
                    res.Text = y.ToString();
                }

            }
            if (ComboBox1.Text == "Месяцев")  // Месяца

            {
                if (ComboBox2.Text == "Лет")

                {
                    if (x < 12)
                    {
                        y =  0;
                        res.Text = y.ToString();
                    }
                    if (x >= 12)
                    {
                        y = x / 12;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Месяцев")

                {

                    y = x;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Дней")

                {
                    y = x * 30;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Часов")

                {
                    y = x * 730;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Минут")

                {
                    y = x * 43800;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x * 2628003;
                    res.Text = y.ToString();
                }
            }
            if (ComboBox1.Text == "Дней")  // Дни

            {
                if (ComboBox2.Text == "Лет")

                {
                    if (x < 365)
                    {
                        y = 0;
                        res.Text = y.ToString();

                    }
                    if (x >= 365)
                    {
                        y = x / 365;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Месяцев")

                {
                    if (x < 30)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if ( x >= 30)
                    {
                        y = x / 30;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Дней")

                {
                    y = x;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Часов")

                {
                    y = x * 24;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Минут")

                {
                    y = x * 1440;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x * 86400;
                    res.Text = y.ToString();
                }
            }
            if (ComboBox1.Text == "Часов")  // Часов

            {
                if (ComboBox2.Text == "Лет")

                {
                    if (x < 8760)
                    {
                        y = 0;
                        res.Text = y.ToString();

                    }
                    if (x >= 8760)
                    {

                        y = x / 8760;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Месяцев")

                {
                    if (x < 730)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 730)
                    {
                        y = x / 730;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Дней")

                {
                    if ( x < 24)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 24)
                    {
                        y = x / 24;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Часов")

                {
                    y = x;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Минут")

                {
                    y = x * 60;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x * 3600;
                    res.Text = y.ToString();
                }
            }
            if (ComboBox1.Text == "Минут")  // Минут

            {
                if (ComboBox2.Text == "Лет")

                {
                    if (x < 525600)
                    {
                        y = 0;
                        res.Text = y.ToString();

                    }
                    if (x >= 525600)
                    {

                        y = x / 525600;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Месяцев")

                {
                    if (x < 43800)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 43800)
                    {
                        y = x / 43800;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Дней")

                {
                    if (x < 1440)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 1440)
                    {
                        y = x / 1440;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Часов")

                {
                    if ( x < 60)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 60)
                    {
                        y = x / 60;
                        res.Text = y.ToString();
                    }  
                }

                if (ComboBox2.Text == "Минут")

                {
                    y = x ;
                    res.Text = y.ToString();
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x * 60;
                    res.Text = y.ToString();
                }
            }

            if (ComboBox1.Text == "Cекунд")  // Секунд

            {
                if (ComboBox2.Text == "Лет")

                {
                    if (x < 31536000)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 31536000)
                    {
                        y = x / 31536000;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Месяцев")

                {
                    if (x < 2592000)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 2592000)
                    {
                        y = x / 2592000;
                        res.Text = y.ToString();
                    }
                }

                if (ComboBox2.Text == "Дней")

                {
                    if (x < 86400)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 86400)
                    {
                        y = x / 86400;
                        res.Text = y.ToString();
                    }

                }

                if (ComboBox2.Text == "Часов")

                {
                    if (x < 3600)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                    if (x >= 3600)
                    {
                        y = x / 3600;
                        res.Text = y.ToString();
                    }

                }

                if (ComboBox2.Text == "Минут")

                {
                    if (x < 60)
                    {
                        y = 0;
                        res.Text = y.ToString();
                    }
                   if (x >= 60)
                   {
                        y = x / 60;
                        res.Text = y.ToString();
                   }
                    
                }

                if (ComboBox2.Text == "Секунд")

                {
                    y = x ;
                    res.Text = y.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            unix();
        }
    }
}