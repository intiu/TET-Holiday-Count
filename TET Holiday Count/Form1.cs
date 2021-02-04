using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TET_Holiday_Count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime endTime = new DateTime(2021, 02, 12, 0, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);

            d.Text = ts.Days.ToString("00");
            h.Text = ts.Hours.ToString("00");
            m.Text = ts.Minutes.ToString("00");
            s.Text = ts.Seconds.ToString("00");
        }
    }
}
