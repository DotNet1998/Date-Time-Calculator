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
    public partial class Leap_Counter : UserControl
    {
        public Leap_Counter()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime a = guna2DateTimePicker1.Value;
            DateTime b = guna2DateTimePicker2.Value;
            int y = 0;

            while ((a < b && (a.AddYears(1) < b)))//ГОДА
            {
                a = a.AddYears(1);
                if (a.Year % 4 == 0)
                {
                    y++;
                }
            }
            res.Text = y.ToString();
        }
    }
}
