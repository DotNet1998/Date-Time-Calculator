using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Calculator.UserControls
{
    public partial class Date_Working_Counter : UserControl
    {
        public Date_Working_Counter()
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
            DateTime a = guna2DateTimePicker1.Value;
            DateTime b = guna2DateTimePicker2.Value;
            
            int y = 0;
            
            while ((a < b && (a.AddDays(1) < b))) // Дни
            {
                a = a.AddDays(1);
                if ( Monday.Checked == true && a.DayOfWeek == DayOfWeek.Monday )
                y++;
                
                if (Tuesday.Checked == true && a.DayOfWeek == DayOfWeek.Tuesday)
                y++;
                
                if (Wednesday.Checked == true && a.DayOfWeek == DayOfWeek.Wednesday)
                y++;
                
                if (Thursday.Checked == true && a.DayOfWeek == DayOfWeek.Thursday)
                y++;
            
                if (Friday.Checked == true && a.DayOfWeek == DayOfWeek.Friday)
                y++;
        
                if (Saturday.Checked == true && a.DayOfWeek == DayOfWeek.Saturday)
                y++;
              
                if (Sunday.Checked == true && a.DayOfWeek == DayOfWeek.Sunday)
                y++;            
            }
                 res.Text = y.ToString();
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            unix();
        }
    }
}
