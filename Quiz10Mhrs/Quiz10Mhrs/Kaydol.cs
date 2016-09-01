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
    
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        KontrolImpl kontrol = new KontrolImpl();
        private void Kaydol_Load(object sender, EventArgs e)
        {

        }
        public void Kayit(string tc,string ad,string soyad,DateTime dtarihi,bool cinsiyet,string sifre) 
        {
            SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
            SqlDataAdapter com = new SqlDataAdapter("insert into Hasta(Tc,Ad,Soyad,DogumTarihi,Cinsiyet,Password,CreateDate,IsDeleted) Values(@tc,@ad,@soyad,@dtarihi,@cinsiyet,@sifre,@otarihi,@isdeleted)", con);
            com.SelectCommand.Parameters.AddWithValue("@tc",tc);
            com.SelectCommand.Parameters.AddWithValue("@ad", ad);
            com.SelectCommand.Parameters.AddWithValue("@soyad", soyad);
            com.SelectCommand.Parameters.AddWithValue("@dtarihi", dtarihi);
            com.SelectCommand.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            com.SelectCommand.Parameters.AddWithValue("@sifre", sifre);
            com.SelectCommand.Parameters.AddWithValue("@otarihi", DateTime.Now);
            com.SelectCommand.Parameters.AddWithValue("@isdeleted", 0);
          
                con.Open();

                com.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıtınız başarıyla gerçekleşmiştir...");
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tc.Text = "";
            txt_sifre.Text = "";
            txt_sifrekontrol.Text = "";

        }
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            bool cinsiyet = false;
            if (txt_ad.Text == "") 
            {
                ap_ad.SetError(txt_ad, "Bu alan boş geçilemez!!!");
            }
            if (txt_soyad.Text=="")
            {
                  ap_soyad.SetError(txt_soyad, "Bu alan boş geçilemez!!!");
            }
            if (txt_tc.Text == "")
            {
                ap_tc.SetError(txt_tc, "Bu alan boş geçilemez!!!");
            }
            if (txt_sifre.Text == "")
            {
                ap_sifre.SetError(txt_sifre, "Bu alan boş geçilemez!!!");
            }
            if (txt_sifrekontrol.Text == "")
            {
                ap_sifretekrar.SetError(txt_sifrekontrol, "Bu alan boş geçilemez!!!");
            }
            else
            {
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                if (kontrol.tcuygunmu(txt_tc.Text)) 
                {
                    if (!kontrol.tcvalidmi(txt_tc.Text))
                    {
                        string tc = txt_tc.Text;
                        if (kontrol.sifresyntaxuygunmu(txt_sifre.Text))
                        {
                            string sifre = txt_sifre.Text;
                            if (kontrol.sifreleruyusuyormu(sifre,txt_sifrekontrol.Text))
                            {
                                string sifretekrar = txt_sifrekontrol.Text;
                                DateTime dtarihi = dateTimePicker1.Value;
                                if (rd_erkek.Checked)
                                {
                                    cinsiyet = false;
                                }
                                else { cinsiyet = true; }
                                Kayit(tc,ad,soyad,dtarihi,cinsiyet,sifre);

                            }
                            else
                            {
                                ap_sifretekrar.SetError(txt_sifrekontrol, "Şifreler uyuşmuyor!!!");
                            }
                        }
                        else
                        {
                            ap_sifre.SetError(txt_sifre, "Şifre uygun değil!!!");
                        }
                    }
                    else
                    {
                        ap_tc.SetError(txt_tc, "Bu kişi kayıtlı!!!");
                    }
                }
                else
                {
                    ap_tc.SetError(txt_tc, "Tc uygun değil!!!");
                }
                
                
                
                
            }
        }
    }
}
