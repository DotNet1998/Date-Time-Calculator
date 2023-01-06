using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Calculator.UserControls
{
    public partial class Date_Comparer : UserControl
    {
        public Date_Comparer()
        {
            InitializeComponent();     
        }
     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            
            DateTime a = guna2DateTimePicker1.Value;
            DateTime b = guna2DateTimePicker2.Value;

            TimeSpan res = b - a;
            lAlldays.Text = res.Days.ToString();

            var y = 0;
            var m = 0;
            var w = 0;
            var d = 0;
            var h = 0;
            var mn = 0;
            var s = 0;
            var ml = 0;
           
            while ((a < b  && (a.AddYears(1) < b)))//ГОДА
                {
                     a = a.AddYears(1);
                     y++;   // плюсую  add years. 
            }

            lYear.Text = y.ToString();

           

            while  ((a < b && (a.AddMonths(1) < b))) // Месяца
            {
                a = a.AddMonths(1);
                m++;
            }
            lMounse.Text = m.ToString();

            while ((a < b && (a.AddDays(7) < b))) // Недели
            {
                a = a.AddDays(7);
                w++;
            }
            lWeek.Text = w.ToString();

            while ((a < b && (a.AddDays(1) < b))) // Дни
            {
                a = a.AddDays(1);
                d++;
            }
            lDay.Text = d.ToString();

            while ((a < b && (a.AddHours(1) < b))) // Часы
            {
                a = a.AddHours(1);
                h++;
            }
            lHour.Text = h.ToString();

            while ((a < b && (a.AddMinutes(1) < b))) // Минуты
            {
                a = a.AddMinutes(1);
                mn++;
            }
            lMinuts.Text = mn.ToString();

            while ((a < b && (a.AddSeconds(1) < b))) // Секунды
            {
                a = a.AddSeconds(1);
                s++;
            }
            lSecound.Text = s.ToString();

            while ((a < b && (a.AddMilliseconds(1) < b))) // Милисекунды
            {
                a = a.AddMilliseconds(1);
                ml++;
            }
            lMilisecounds.Text = ml.ToString();

           

            



        }
    }
}
