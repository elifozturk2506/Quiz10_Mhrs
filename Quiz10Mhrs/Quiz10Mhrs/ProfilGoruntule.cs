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
    public partial class ProfilGoruntule : Form
    {
        public ProfilGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        KontrolImpl kontrol = new KontrolImpl();
        private void ProfilGoruntule_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Hasta where HastaId=@id",con);
            da.SelectCommand.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_profilgoruntule.DataSource = dt;
            con.Close();
        }

        private void adıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_updatesifre.Visible = false;
            btn_updatesoyad.Visible = false;
            groupBox2.Visible = true;
            textBox1.Visible = true;
            btn_updatead.Visible = true;
           textBox1.Text=dgw_profilgoruntule.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_updatesoyad_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("update  Hasta set Soyad=@soyad where HastaId=@id", con);
            da.SelectCommand.Parameters.AddWithValue("@soyad", textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
            con.Open();
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir...");
            textBox1.Text = "";
        }

        private void btn_updatead_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("update Hasta set Ad=@ad where HastaId=@id",con);
            da.SelectCommand.Parameters.AddWithValue("@ad",textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
            con.Open();
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir...");
            textBox1.Text = "";

        }

        private void btn_updatesifre_Click(object sender, EventArgs e)
        {
            if (kontrol.sifresyntaxuygunmu(textBox1.Text))
            {
                SqlDataAdapter da = new SqlDataAdapter("update Hasta set Password=@sifre where HastaId=@id", con);
                da.SelectCommand.Parameters.AddWithValue("@sifre", textBox1.Text);
                da.SelectCommand.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir...");
                textBox1.Text = "";
            }
            else
            {
                ep_sifre.SetError(textBox1,"Şifre Uygun Değil!!!");

            }
           
        }

        private void dgw_profilgoruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void soyadıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_updatead.Visible = false;
            btn_updatesifre.Visible = false;
            groupBox2.Visible = true;
            textBox1.Visible = true;
            btn_updatesoyad.Visible = true;
            textBox1.Text = dgw_profilgoruntule.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void şifreyiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_updatead.Visible = false;
            btn_updatesoyad.Visible = false;
            groupBox2.Visible = true;
            textBox1.Visible = true;
            btn_updatesifre.Visible = true;
            textBox1.Text = dgw_profilgoruntule.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
