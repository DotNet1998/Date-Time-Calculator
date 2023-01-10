using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Calculator
{
    public partial class Birthday_Informer : UserControl
    {
        public Birthday_Informer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime a = guna2DateTimePicker2.Value;  // Дата рождения 
            DateTime b = DateTime.Now;  // дата (прямо сейчас) 
          
            int needYear = b.Year; // присваиваю теперешний год переменной 

            var nextBirthDay = new DateTime(b.Year, a.Month, a.Day); // создал переменную следующего дня рождения, Вставив в нее теперешний год,
                                                                     //  месяц и день, от даты рождения 

            var y = 0;   // счётчики которые плюсуются от даты к дате 
            var m = 0;
            var d = 0;
            var h = 0;
            var mn = 0;
            var s = 0;



            while ((a < b && (a.AddYears(1) < b)))//ГОДА
            {
                a = a.AddYears(1);
                y++;   // плюсую  add years. 
            }

            Year.Text = y.ToString() + "л.";

            while ((a < b && (a.AddMonths(1) < b))) // Месяца
            {
                a = a.AddMonths(1);
                m++;
            }
            Year.Text += m.ToString()+ "м.";

 
            while ((a < b && (a.AddDays(1) < b))) // Дни
            {
                a = a.AddDays(1);
                d++;
            }
            Year.Text += d.ToString() + "д.";

            while ((a < b && (a.AddHours(1) < b))) // Часы
            {
                a = a.AddHours(1) ;
                h++;
            }
            Year.Text += h.ToString() + "ч.";

            while ((a < b && (a.AddMinutes(1) < b))) // Минуты
            {
                a = a.AddMinutes(1);
                mn++;
            }
            Year.Text += mn.ToString() + "м.";

            while ((a < b && (a.AddSeconds(1) < b))) // Секунды
            {
                a = a.AddSeconds(1);
                s++;
            }
            Year.Text += s.ToString() + "с.";

            // ------------------------------------------------------- До следующего дня рождения.
                          
             y = 0; // обнуляю счётчики 
             m = 0;
             d = 0;
             h = 0;
             mn = 0;
             s = 0;
          
            while ((b < nextBirthDay && (b.AddYears(1) < nextBirthDay)))//ГОДА
            {
                b = b.AddYears(1);
                y++;
             
            }
            
            Year2.Text = y.ToString() + "л.";

            while ((b < nextBirthDay && (b.AddMonths(1) < nextBirthDay))) // Месяца
            {
                b = b.AddMonths(1);
                m++;
            }
            Year2.Text += m.ToString() + "м.";


            while ((b < nextBirthDay && (b.AddDays(1) < nextBirthDay))) // Дни
            {
                b = b.AddDays(1);
                d++;
            }
            Year2.Text += d.ToString() + "д.";

            while ((b < nextBirthDay && (b.AddHours(1) < nextBirthDay))) // Часы
            {
                b = b.AddHours(1);
                h++;
            }
            Year2.Text += h.ToString() + "ч.";

            while ((b < nextBirthDay && (b.AddMinutes(1) < nextBirthDay))) // Минуты
            {
                b = b.AddMinutes(1);
                mn++;
            }
            Year2.Text += mn.ToString() + "м.";

            while ((b < nextBirthDay && (b.AddSeconds(1) < nextBirthDay))) // Секунды
            {
                b = b.AddSeconds(1);
                s++;
            }
            Year2.Text += s.ToString() + "с.";



        }
    }
}
