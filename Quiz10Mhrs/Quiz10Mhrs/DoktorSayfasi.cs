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
    public partial class DoktorSayfasi : Form
    {
        public DoktorSayfasi()
        {
            InitializeComponent();
         }
        DoktorHastaRandevuGecmisi dhrg= new DoktorHastaRandevuGecmisi();
        ReceteYaz receteyaz = new ReceteYaz();
        İzinTalebi izintalebi = new İzinTalebi();
        HastaReceteGecmisi hastarecetegecmisi = new HastaReceteGecmisi();
      
        private void DoktorSayfasi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
            SqlCommand com = new SqlCommand("select concat(RTRIM(Ad),' ',RTRIM(Soyad)) as AdSoyad from Personel where PersonelId=@id",con);
            com.Parameters.AddWithValue("@id",Kontrol.IlgiliDoktorId);
            if (con.State==ConnectionState.Closed)
            {
                 con.Open();
                 SqlDataReader dr = com.ExecuteReader();
                 while (dr.Read())
                 {
                     label2.Text = dr.GetString(0);
                 }
            
            }
           
           
        }

        private void hastaRandevuGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dhrg.MdiParent = this;
            dhrg.WindowState = FormWindowState.Maximized;
            dhrg.Show();
        }

        private void hastaReçeteYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            receteyaz.MdiParent = this;
            receteyaz.WindowState = FormWindowState.Maximized;
            receteyaz.Show();
        }

        private void izinTalebiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
           izintalebi.MdiParent = this;
            izintalebi.WindowState = FormWindowState.Maximized;
            izintalebi.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            hastarecetegecmisi.MdiParent = this;
            hastarecetegecmisi.WindowState = FormWindowState.Maximized;
            hastarecetegecmisi.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
