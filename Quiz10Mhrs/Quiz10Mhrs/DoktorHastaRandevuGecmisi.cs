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
    public partial class DoktorHastaRandevuGecmisi : Form
    {
        public DoktorHastaRandevuGecmisi()
        {
            InitializeComponent();
        }

        private void DoktorHastaRandevuGecmisi_Load(object sender, EventArgs e)
        {
            dgw_randevugecmisi.Enabled = false;
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void btn_listele_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlCommand com = new SqlCommand("select HastaId from Hasta where Tc=@tc",con);
            com.Parameters.AddWithValue("@tc", textBox1.Text);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                }
            }
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("select h.Tc,h.Ad,h.Soyad,concat(RTRIM(p.Ad),' ',p.Soyad) as DoktorAdSoyad,b.bolum,RandevuTarihi,RandevuSaati from Randevu r join Personel p on r.PersonelId=p.PersonelId join DoktorBolum db on p.PersonelId=db.personelid join Bolumler b on b.bolumId=db.bolumid join Hasta h on r.HastaId=h.HastaId where r.HastaId=@id", con);
            da.SelectCommand.Parameters.AddWithValue("@id",id);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_randevugecmisi.DataSource = dt;
            con.Close();
        }
    }
}
