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
    public partial class RandevuGecmisi : Form
    {
        public RandevuGecmisi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void dgw_randevugecmisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RandevuGecmisi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Tc,Ad,Soyad,concat(RTRIM(p.Ad),' ',p.Soyad) as DoktorAdSoyad,b.bolum,RandevuTarihi,RandevuSaati from Randevu r join Personel p on r.PersonelId=p.PersonelId join DoktorBolum db on p.PersonelId=db.personelid join Bolumler b on b.bolumId=db.bolumid where r.HastaId=@id",con);
            da.SelectCommand.Parameters.AddWithValue("id",Kontrol.IlgiliHastaId);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_randevugecmisi.DataSource = dt;

        }
    }
}
