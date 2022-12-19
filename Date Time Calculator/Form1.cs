using Date_Time_Calculator.UserControls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Date_Comparer comparer = new Date_Comparer();
            addUserControl(comparer);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button25_Click(object sender, EventArgs e)
        {
            Date_Comparer comparer = new Date_Comparer();
            addUserControl(comparer);

        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            Date_Working_Counter workingcounter = new Date_Working_Counter();
            addUserControl(workingcounter);

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            Leap_Counter leap_Counter= new Leap_Counter();
            addUserControl(leap_Counter);
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            Time_Converter time_Converter= new Time_Converter();
            addUserControl(time_Converter); 
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            Birthday_Informer birthdayinformer = new Birthday_Informer();   
            addUserControl(birthdayinformer);

        }
    }
}
