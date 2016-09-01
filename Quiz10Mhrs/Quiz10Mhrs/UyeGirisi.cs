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

    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }
        KontrolImpl kontrol = new KontrolImpl();
        HastaSayfasi hasta = new HastaSayfasi();
        AdminSayfasi admin = new AdminSayfasi();
        DoktorSayfasi doktor = new DoktorSayfasi();
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string sifre = txt_sifre.Text;
            if (tc == "")
            {
                ep_tc.SetError(txt_tc, "Bu alan boş geçilemez!!!");
            }
            else
            {
                ep_tc.Clear();
                if (sifre == "")
                {
                    ep_sifre.SetError(txt_sifre, "Bu alan boş geçilemez!!!");
                }
                else
                {
                    if (txt_tc.Text=="11111111111" && txt_sifre.Text=="admin123.")
                    {
                        admin.Show();
                    }
                    else if ((kontrol.doktorgiris(txt_tc.Text))!=0 && txt_sifre.Text=="doktor123!")
                    {
                        doktor.Show();
                    }
                    else if ((kontrol.hastagiris(txt_tc.Text,txt_sifre.Text))!=0)
                    {
                        hasta.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sisteme kayıtlı böyle bir kullanıcı bulunmamaktadır.");
                    }
                }
            }

        }

        private void UyeGirisi_Load(object sender, EventArgs e)
        {

        }
        Kaydol kaydol = new Kaydol();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kaydol.Show();
        }
        SifremiUnuttum sifremiunuttum = new SifremiUnuttum();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum.Show();
        }
    }
}

