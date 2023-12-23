﻿using System;
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
    public partial class AgriDBmonitoring : Form
    {
        SqlConnection Cn;
        SqlCommand Cmd;
        SqlDataReader dr;
        string S;
        public AgriDBmonitoring()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            textBox5.Text = openFileDialog1.FileName.ToString();

           
        }

        private void AgriDBmonitoring_Load(object sender, EventArgs e)
        {
            Cn = new SqlConnection("Data Source=DESKTOP-DQAJJ3U;Initial Catalog=AgriDB;Integrated Security=True");
            Cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             S = "select *  from tb_soil where image='" + textBox5.Text + "'";
            Cmd = new SqlCommand(S, Cn);
            dr = Cmd.ExecuteReader();
            if (dr.Read())
            {
                label9.Text = dr.GetValue(0).ToString();
                label8.Text = dr.GetValue(1).ToString() + "pH";
                label7.Text = dr.GetValue(2).ToString() + "pH";
                label1.Text = dr.GetValue(3).ToString();
                String S1 = dr.GetValue(4).ToString();
                pictureBox1.Image = Image.FromFile(S1);

            }
            dr.Close();
            Cmd.Dispose();
        
        }
         
    }
}
