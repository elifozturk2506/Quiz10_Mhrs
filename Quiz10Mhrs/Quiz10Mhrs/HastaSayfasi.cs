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
    public partial class HastaSayfasi : Form
    {
        public HastaSayfasi()
        {
            InitializeComponent();
        }
        RandevuAl1 randevual = new RandevuAl1();
        RandevuGecmisi randevugecmisi = new RandevuGecmisi();
        ProfilGoruntule profilgoruntule = new ProfilGoruntule();
        private void HastaSayfasi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
            SqlCommand com = new SqlCommand("select concat(RTRIM(Ad),' ',RTRIM(Soyad)) as AdSoyad from Hasta where HastaId=@id", con);
            com.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    label2.Text = dr.GetString(0);
                }

            }
           
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            randevual.MdiParent = this;
            randevual.WindowState = FormWindowState.Maximized;
            randevual.Show();
        }

        private void randevuGeçmişiGörüüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            randevugecmisi.MdiParent = this;
            randevugecmisi.WindowState = FormWindowState.Maximized;
            randevugecmisi.Show();
        }

        private void profilGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
           profilgoruntule.MdiParent = this;
            profilgoruntule.WindowState = FormWindowState.Maximized;
            profilgoruntule.Show();
        }
    }
}
