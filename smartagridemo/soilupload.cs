using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace smartagridemo
{
    public partial class AgriDBupload : Form
    {
        SqlConnection Cn;
        SqlCommand Cmd;
        string S;
        public AgriDBupload()
        {
            InitializeComponent();
        }

        private void AgriDBupload_Load(object sender, EventArgs e)
        {
            Cn = new SqlConnection("Data Source=DESKTOP-DQAJJ3U;Initial Catalog=AgriDB;Integrated Security=True");
            Cn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            S = "insert into tb_soil values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            Cmd = new SqlCommand(S, Cn);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox5.Text = openFileDialog1.FileName.ToString();
        }

       
    }
}
