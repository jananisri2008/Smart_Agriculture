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
    public partial class Report : Form
    {
        SqlConnection Cn;   
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cn = new SqlConnection("Data Source=DESKTOP-DQAJJ3U;Initial Catalog=AgriDB;Integrated Security=True");
            Cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select cid as ID,cname as ItemName,edesc as Details,cat as Category from tb_item1 where cat='"+comboBox2.Text+"' or etype='"+comboBox2.Text+"' order by cid" , Cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
