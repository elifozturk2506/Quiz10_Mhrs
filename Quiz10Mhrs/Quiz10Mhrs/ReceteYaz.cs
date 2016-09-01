using System;
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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select IlacId,Ad from Ilaclar",con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            cmb_ilaclar.DataSource = dt;
            cmb_ilaclar.DisplayMember = "Ad";
            cmb_ilaclar.ValueMember = "IlacId";
        }

        private void btn_ilacekle_Click(object sender, EventArgs e)
        {
            lb_ilaclar.Items.Add(cmb_ilaclar.Text);

        }

        private void btn_ilacsil_Click(object sender, EventArgs e)
        {
            lb_ilaclar.Items.RemoveAt(lb_ilaclar.SelectedIndex);
        }

        private void btn_tumunusil_Click(object sender, EventArgs e)
        {
            lb_ilaclar.Items.Clear();
        }
        public void ReceteKayit(int hastaid)
        {
           
            SqlDataAdapter da2 = new SqlDataAdapter("insert into Recete(HastaId,PersonelId,CreateDate,IsDeleted) Values(@hastaid,@personelid,@createdate,@isdeleted)", con);
            da2.SelectCommand.Parameters.AddWithValue("@hastaid", hastaid);
            da2.SelectCommand.Parameters.AddWithValue("@personelid", Kontrol.IlgiliDoktorId);
            da2.SelectCommand.Parameters.AddWithValue("@createdate", DateTime.Now);
            da2.SelectCommand.Parameters.AddWithValue("@isdeleted", 0);
            con.Open();
            da2.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public void ReceteIlacKayit(int hastaid)
        {
            int receteid = 0;
            int[] ilacids =new int[lb_ilaclar.Items.Count];
            SqlCommand da = new SqlCommand("select top 1 ReceteId from Recete where HastaId=@id ",con);
            da.Parameters.AddWithValue("@id", hastaid);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    receteid = dr.GetInt32(0);
                }
            }
            con.Close();
            for (int i = 0; i < lb_ilaclar.Items.Count; i++)
            {
                SqlCommand com = new SqlCommand("select IlacId from Ilaclar where Ad=@ad",con);
                com.Parameters.AddWithValue("@ad",lb_ilaclar.Items[i].ToString());
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        ilacids[i] = dr.GetInt32(0);
                    }
                }
                con.Close();
            }
            for (int i = 0; i < ilacids.Length; i++)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("insert into ReceteIlac(ReceteId,IlacId,IsDeleted) Values(@receteid,@ilacid,@isdeleted)", con);
                da2.SelectCommand.Parameters.AddWithValue("@receteid", receteid);
                da2.SelectCommand.Parameters.AddWithValue("@ilacid", ilacids[0]);
                da2.SelectCommand.Parameters.AddWithValue("@isdeleted", 0);
                con.Open();
                da2.SelectCommand.ExecuteNonQuery();
                con.Close();
            }

        }
        private void btn_recetekayit_Click(object sender, EventArgs e)
        {
            int hastaid = 0;
            SqlCommand da = new SqlCommand("select HastaId from Hasta where Tc=@tc", con);
            da.Parameters.AddWithValue("@tc", textBox1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    hastaid = dr.GetInt32(0);
                }

            }
            con.Close();
            ReceteKayit(hastaid);
            ReceteIlacKayit(hastaid);
            MessageBox.Show("İşlem Gerçekleşmiştir...");
               textBox1.Text="";
               lb_ilaclar.Items.Clear();

        }
    }
}
