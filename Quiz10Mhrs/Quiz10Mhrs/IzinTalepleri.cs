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
    public partial class IzinTalepleri : Form
    {
        public IzinTalepleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void IzinTalepleri_Load(object sender, EventArgs e)
        {

            Doldur();
        }
        public void Doldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select p.PersonelId,RTRIM(p.Ad) as PersonelAd,RTRIM(p.Soyad) as PersonelSoyad,obi.StartDate,obi.EndDate from OnayBekleyenIzinler obi join Personel p on obi.PersonelId=p.PersonelId", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_izintalepleri.DataSource = dt;
            con.Close();
        }
        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string personelid = dgw_izintalepleri.SelectedRows[0].Cells[0].Value.ToString();
            DateTime startdate = Convert.ToDateTime(dgw_izintalepleri.SelectedRows[0].Cells[3].Value);
            DateTime endate = Convert.ToDateTime(dgw_izintalepleri.SelectedRows[0].Cells[4].Value);
            SqlDataAdapter da2 = new SqlDataAdapter("insert into PersonelIzin(PersonelId,StartDate,EndDate,CreateDate,IsDeleted) Values(@id,@sdate,@edate,@cdate,@isdeleted)", con);
            da2.SelectCommand.Parameters.AddWithValue("@id", personelid);
            da2.SelectCommand.Parameters.AddWithValue("@sdate", startdate);
            da2.SelectCommand.Parameters.AddWithValue("@edate", endate);
            da2.SelectCommand.Parameters.AddWithValue("@cdate", DateTime.Now);
            da2.SelectCommand.Parameters.AddWithValue("@isdeleted", 0);
     
            con.Open();

            da2.SelectCommand.ExecuteNonQuery();

            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("delete from OnayBekleyenIzinler where PersonelId=@id", con);
            da.SelectCommand.Parameters.AddWithValue("@id", personelid);
            con.Open();
            da.SelectCommand.ExecuteNonQuery();
            con.Close();

            dgw_izintalepleri.DataSource = null;
            Doldur();


        }

        private void reddetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personelid = dgw_izintalepleri.SelectedRows[0].Cells[0].Value.ToString();
            DateTime startdate = Convert.ToDateTime(dgw_izintalepleri.SelectedRows[0].Cells[3].Value);
            DateTime endate = Convert.ToDateTime(dgw_izintalepleri.SelectedRows[0].Cells[4].Value);
            SqlDataAdapter da = new SqlDataAdapter("delete from OnayBekleyenIzinler where PersonelId=@id", con);
            da.SelectCommand.Parameters.AddWithValue("@id", personelid);
            con.Open();

            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            dgw_izintalepleri.DataSource = null;
            Doldur();
        }

        
    }
}
