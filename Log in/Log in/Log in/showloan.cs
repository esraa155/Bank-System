﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Log_in
{
    public partial class showloan : Form
    {
        public showloan()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=Bank;Integrated Security=True");
        private void Show_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM LOAN",con);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
