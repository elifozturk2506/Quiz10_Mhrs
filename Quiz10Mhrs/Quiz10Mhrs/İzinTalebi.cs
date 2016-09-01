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
    public partial class İzinTalebi : Form
    {
        public İzinTalebi()
        {
            InitializeComponent();
        }

        private void İzinTalebi_Load(object sender, EventArgs e)
        {
            dtp_izinbaslangic.MinDate = DateTime.Now.AddDays(1);
            dtp_izinbitis.MinDate = DateTime.Now.AddDays(1);
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void btn_izintalebi_Click(object sender, EventArgs e)
        {
            DateTime izinbaslangictarihi = dtp_izinbaslangic.Value;
            DateTime izinbitistarihi = dtp_izinbitis.Value;
            SqlCommand com = new SqlCommand("insert into OnayBekleyenIzinler(PersonelId,StartDate,EndDate) Values(@id,@startdate,@enddate)", con);
            com.Parameters.AddWithValue("@id",Kontrol.IlgiliDoktorId);
            com.Parameters.AddWithValue("@startdate",izinbaslangictarihi);
            com.Parameters.AddWithValue("@enddate", izinbitistarihi);
            con.Open();
            com.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Talebiniz İletilmiştir...");
        }
    }
}
