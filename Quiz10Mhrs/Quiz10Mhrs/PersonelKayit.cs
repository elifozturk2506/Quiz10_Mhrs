using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10Mhrs
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        string fotopath;
        private void llbl_resimekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                fotopath = openFileDialog1.FileName.ToString();

            }
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void btn_personelkaydet_Click(object sender, EventArgs e)
        {
            int personeltipid = 0;
            if (cmb_personeltip.SelectedIndex==0)
            {
                personeltipid = 8;
            }
            else if (cmb_personeltip.SelectedIndex == 1)
            {
                personeltipid = 9;
            }
            else{
                personeltipid = 10;
            }
            FileStream fs = new FileStream(fotopath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            SqlCommand com = new SqlCommand("insert into Personel(Tc,Ad,Soyad,PersonelTipId,CreateDate,Foto,FotoPath,IsDeleted) Values(@tc,@ad,@soyad,@personeltipid,@createdate,@foto,@fotopath,@isdeleted)",con);
            com.Parameters.AddWithValue("@tc",txt_tc.Text);
            com.Parameters.AddWithValue("@ad", txt_ad.Text);
            com.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            com.Parameters.AddWithValue("@personeltipid",personeltipid);
            com.Parameters.AddWithValue("@createdate", DateTime.Now);
            com.Parameters.AddWithValue("@foto", resim);
            com.Parameters.AddWithValue("@fotopath", fotopath);
            com.Parameters.AddWithValue("@isdeleted",0);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşmiştir");
            }
            txt_tc.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            cmb_personeltip.SelectedValue = "";
            pictureBox1.Image = null;
        }
    }
}
