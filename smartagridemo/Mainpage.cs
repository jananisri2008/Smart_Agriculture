using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smartagridemo
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgriDBupload a = new AgriDBupload();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgriDBmonitoring B = new AgriDBmonitoring();
            B.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Preprationmodule c = new Preprationmodule();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fertilizers d = new Fertilizers();
            d.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report aa = new Report();
            aa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
