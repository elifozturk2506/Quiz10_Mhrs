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
    public partial class RandevuOnayla : Form
    {
        public RandevuOnayla()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void RandevuOnayla_Load(object sender, EventArgs e)
        {
            string personeladsoyad = "";
            SqlCommand da = new SqlCommand("select concat(RTRIM(Ad),' ' ,RTRIM(Soyad)) as AdSoyad from Personel where PersonelId=@id", con);
            da.Parameters.AddWithValue("@id", Kontrol.Randevupersonelid);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    personeladsoyad = dr.GetString(0);
                }
            }
            con.Close();
            lbl_ad.Text = Kontrol.IlgiliHastaAd;
            lbl_soyad.Text = Kontrol.IlgiliHastaSoyad;
            lbl_tc.Text = Kontrol.IlgiliHastaTc;
            lbl_doktorad.Text = personeladsoyad;
            lbl_randevutarihi.Text = Kontrol.Randevutarihi.ToString() ;
            lbl_randevusaati.Text = Kontrol.Randevusaati;
            
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into Randevu(HastaId,PersonelId,RandevuSaati,CreateDate,IsDeleted,RandevuTarihi) Values(@hastaid,@personelid,@randevusaati,@createdate,@isdeleted,@randevutarihi)", con);
            da.SelectCommand.Parameters.AddWithValue("@hastaid",Kontrol.IlgiliHastaId);
            da.SelectCommand.Parameters.AddWithValue("@personelid", Kontrol.Randevupersonelid);
            da.SelectCommand.Parameters.AddWithValue("@randevusaati", Kontrol.Randevusaati);
            da.SelectCommand.Parameters.AddWithValue("@createdate", DateTime.Now.Date);
            da.SelectCommand.Parameters.AddWithValue("@isdeleted", 0);
            da.SelectCommand.Parameters.AddWithValue("@randevutarihi", Kontrol.Randevutarihi);
            con.Open();
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Randevu Alınmıştır...");
        }
    }
}
