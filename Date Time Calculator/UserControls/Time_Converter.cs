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
    public partial class Time_Converter : UserControl
    {
        public Time_Converter()
        {
            InitializeComponent();
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "mm/dd/yyyy hh:mm:ss";
            guna2DateTimePicker2.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker2.CustomFormat = "mm/dd/yyyy hh:mm:ss";
        }
    }
}
