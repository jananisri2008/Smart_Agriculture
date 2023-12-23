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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                Mainpage aa = new Mainpage();
                aa.Show();
            }
            else if (textBox1.Text == "user" && textBox2.Text == "123")
            {
                UserHome bb = new UserHome();
                bb.Show();
            }
            else
            {

                MessageBox.Show("Invalid UserName & Password");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
