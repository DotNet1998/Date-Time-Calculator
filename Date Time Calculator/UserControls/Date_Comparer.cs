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
    public partial class Date_Comparer : UserControl
    {
        public Date_Comparer()
        {
            InitializeComponent();
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "mm/dd/yyyy hh:mm:ss";
            guna2DateTimePicker2.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker2.CustomFormat = "mm/dd/yyyy hh:mm:ss";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
            var a = guna2DateTimePicker1.Value;
            var b = guna2DateTimePicker2.Value;
            var y = 0;
            var m = 0;
          
            while (a.Year < b.Year)
            {
               a = a.AddYears(1);
                lYear.Text = y++.ToString();
                 if ((a.Year % 100 != 0 || a.Year % 400 == 0) && (b.Year % 100 != 0 || b.Year % 400 == 0))
                {
                    a = a.AddMonths(1);
                    lMounse.Text = m++.ToString();
                    
                }
                else
                    a = a.AddMonths(1);
                lMounse.Text = m++.ToString();
            }



            while (a < b)
            {
                if ((a.Year % 100 != 0 || a.Year % 400 == 0) && (b.Year % 100 != 0 || b.Year % 400 == 0))
                {
                    a = a.AddMonths(1);
                    lMounse.Text = m++.ToString();
                    
                }
                else
                    a = a.AddMonths(1);
                lMounse.Text = m++.ToString();
            }



        }
    }
}
