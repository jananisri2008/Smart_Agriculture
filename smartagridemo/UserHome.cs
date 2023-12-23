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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgriDBmonitoring aa = new AgriDBmonitoring();
            aa.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upreparation b = new Upreparation();
            b.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UFertidemo aa = new UFertidemo();
            aa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uirregation c = new Uirregation();
            c.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
