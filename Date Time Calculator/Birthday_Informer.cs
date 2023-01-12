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
            DateTime Birthsday = guna2DateTimePicker2.Value;  // Дата рождения 
            DateTime b = DateTime.Now;  // дата (прямо сейчас) 
            DateTime Yers18 = new DateTime(Birthsday.Year + 18, Birthsday.Month, Birthsday.Day, Birthsday.Hour, Birthsday.Minute, Birthsday.Second); // день рождение плюс 18 лет
            int needYear = b.Year; // присваиваю теперешний год переменной 

            var nextBirthDay = new DateTime(b.Year, Birthsday.Month, Birthsday.Day , Birthsday.Hour, Birthsday.Minute, Birthsday.Second); // день рождения но год изменён на 2023
                                                                                     //  месяц и день, от даты рождения 
            int cYears = (int)countYears.Value; //беру значене с чек бокса N лет,  и перевожу его в int переменную
           
            var nYears = new DateTime(Birthsday.Year + cYears, Birthsday.Month, Birthsday.Day, Birthsday.Hour, Birthsday.Minute, Birthsday.Second); // дата рождения плюс N лет

            var year = 0;   // счётчики которые плюсуются от даты к дате 
            var months = 0; 
            var day = 0;
            var hours = 0;
            var minutes = 0;
            var secounds = 0;

            // прохожусь от даты рождения до даты прямо сейчас , плюссую счётчики , и вывожу в лейбл значения счётчиков.

            while ((Birthsday < b && (Birthsday.AddYears(1) < b)))//ГОДА
            {
                Birthsday = Birthsday.AddYears(1);
                year++;   // плюсую  add years. 
            }

            while ((Birthsday < b && (Birthsday.AddMonths(1) < b))) // Месяца
            {
                Birthsday = Birthsday.AddMonths(1);
                months++;
            }

            while ((Birthsday < b && (Birthsday.AddDays(1) < b))) // Дни
            {
                Birthsday = Birthsday.AddDays(1);
                day++;
            }

            while ((Birthsday < b && (Birthsday.AddHours(1) < b))) // Часы
            {
                Birthsday = Birthsday.AddHours(1);
                hours++;
            }

            while ((Birthsday < b && (Birthsday.AddMinutes(1) < b))) // Минуты
            {
                Birthsday = Birthsday.AddMinutes(1);
                minutes++;
            }

            while ((Birthsday < b && (Birthsday.AddSeconds(1) < b))) // Секунды
            {
                Birthsday = Birthsday.AddSeconds(1);
                secounds++;
            }
            countLive.Text = $"Сколько живет: {year}л.{months}м.{day}д.{hours}ч.{minutes}мин.{secounds}с.";




            ////////////////////////////////////////////////////////////До следующего дня рождения.
            
            // прохожусь от даты сейчвс до даты день рождения с изменнёным годом на 2023 для того чтобы рассчитать сколько от щас до следующего дня рождения 
            year = 0;   // счётчики которые плюсуются от даты к дате 
            months = 0;
            day = 0;
            hours = 0;
            minutes = 0;
            secounds = 0;


            while ((b < nextBirthDay && (b.AddYears(1) < nextBirthDay)))//ГОДА
            {
                b = b.AddYears(1);
                year++;
            }

            while ((b < nextBirthDay && (b.AddMonths(1) < nextBirthDay))) // Месяца
            {

                b = b.AddMonths(1);
                months++;
            }
  
            while ((b < nextBirthDay && (b.AddDays(1) < nextBirthDay))) // Дни
            {

                b = b.AddDays(1);
                day++;
            }
           
            while ((b < nextBirthDay && (b.AddHours(1) < nextBirthDay))) // Часы
            {

                b = b.AddHours(1);
                hours++;
            }

            while ((b < nextBirthDay && (b.AddMinutes(1) < nextBirthDay))) // Минуты
            {

                b = b.AddMinutes(1);
                minutes++;
            }

            while ((b < nextBirthDay && (b.AddSeconds(1) < nextBirthDay))) // Секунды
            {

                b = b.AddSeconds(1);
                secounds++;
            }
          doNextBirthday.Text = $" До следующего день рождения: {year}л.{months}м.{day}д.{hours}ч.{minutes}мин.{secounds}с.";

            // ------------------------------------------------------- 18 лет исполнилось.

            // обнуляю счётчики 
            year = 0;
            months = 0;
            day = 0;
            hours = 0;
            minutes = 0;
            secounds = 0;
            DateTime c = DateTime.Now;

          // иду от даты рождения +18 лет , до теперешней даты , и плюсую счётчик  , сколько наплюсовало столько и вывожу в лейбл .

            while ((Yers18 < c && (Yers18.AddYears(1) < c)))//ГОДА 
            {
                Yers18 = Yers18.AddYears(1);

                year++;
            }


            while ((Yers18 < c && (Yers18.AddMonths(1) < c)))// Месяца
            {
                Yers18 = Yers18.AddMonths(1);

                months++;

            }

            while ((Yers18 < c && (Yers18.AddDays(1) < c)))//Дни
            {
                Yers18 = Yers18.AddDays(1);

                day++;

            }

            while ((Yers18 < c && (Yers18.AddHours(1) < c)))//Часы
            {
                Yers18 = Yers18.AddHours(1);

                hours++;

            }

            while ((Yers18 < c && (Yers18.AddMinutes(1) < c)))//Минуты
            {
                Yers18 = Yers18.AddMinutes(1);

                minutes++;

            }

            while ((Yers18 < c && (Yers18.AddSeconds(1) < c)))//Секунды
            {
                Yers18 = Yers18.AddSeconds(1);

                secounds++;

            }

            if (c > Yers18)
            {
                brth.Text = $"18 лет исполнилось : {year}л.{months}м.{day}д.{hours}ч.{minutes}м.{secounds}с. назад.";
            }


            //////////////////////////////////////////////////////////// Исполнится 18 лет через  
            // иду от тепершней даты к даты 18 лет + 18,  и плюсую счётчик, сколько наплюсовало столько и вывожу в лейбл


            while ((c < Yers18 && (c.AddYears(1) < Yers18)))//ГОДА
            {
                c = c.AddYears(1);

                year++;
            }


            while ((c < Yers18 && (c.AddMonths(1) < Yers18)))// Месяца
            {
                c = c.AddMonths(1);

                months++;

            }

            while ((c < Yers18 && (c.AddDays(1) < Yers18)))//Дни
            {
                c = c.AddDays(1);

                day++;

            }

            while ((c < Yers18 && (c.AddHours(1) < Yers18)))//Часы
            {
                c = c.AddHours(1);

                hours++;

            }

            while ((c < Yers18 && (c.AddMinutes(1) < Yers18)))//Минуты
            {
                c = c.AddMinutes(1);

                minutes++;

            }

            while ((c < Yers18 && (c.AddSeconds(1) < Yers18)))//Секунды
            {
                c = c.AddSeconds(1);

                secounds++;

            }

            if (c < Yers18)
            {
                brth.Text = $"18 лет исполнится через : {year}л.{months}м.{day}д.{hours}ч.{minutes}м.{secounds}с.";
            }

            ///////////////////////////////////////////////////////////////// Через сколько исполнится N лет 
            // обнуляю счётчики 
            year = 0;
            months = 0;
            day = 0;
            hours = 0;
            minutes = 0;
            secounds = 0;

            // Прохожусь от даты сейчас до даты дня рождения + N лет , и плюсую счётчики

            while ((c < nYears && (c.AddYears(1) < nYears)))//ГОДА
            {
                c = c.AddYears(1);

                year++;
            }


            while ((c < nYears && (c.AddMonths(1) < nYears)))// Месяца
            {
                c = c.AddMonths(1);

                months++;

            }

            while ((c < nYears && (c.AddDays(1) < nYears)))//Дни
            {
                c = c.AddDays(1);

                day++;

            }

            while ((c < nYears && (c.AddHours(1) < nYears)))//Часы
            {
                c = c.AddHours(1);

                hours++;

            }

            while ((c < nYears && (c.AddMinutes(1) < nYears)))//Минуты
            {
                c = c.AddMinutes(1);

                minutes++;

            }

            while ((c < nYears && (c.AddSeconds(1) < nYears)))//Секунды
            {
                c = c.AddSeconds(1);

                secounds++;

            }

            NYEARS.Text = $"{cYears} лет исполнится через: {year}л.{months}м.{day}д.{hours}ч.{minutes}м.{secounds}с.";

        }
    }
}
