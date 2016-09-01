﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10Mhrs
{
    public partial class HastaReceteGecmisi : Form
    {
        public HastaReceteGecmisi()
        {
            InitializeComponent();
        }

        private void HastaReceteGecmisi_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void btn_listele_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_HastaReceteGecmisi", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@tc",txt_tc.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_recetegecmisi.DataSource = dt;

        }
    }
}
