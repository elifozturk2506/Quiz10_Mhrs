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
    public partial class RandevuAl1 : Form
    {
        public RandevuAl1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        RandevuOnayla randevuonay = new RandevuOnayla();
        private void RandevuAl1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bolumler", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
           cmb_bolumler.DataSource = dt;
           cmb_bolumler.DisplayMember = "bolum";
           cmb_bolumler.ValueMember = "bolumId";
           dtp_randevutarihi.Enabled = false;
            cmb_doktorlar.Enabled = false;
            grup_randevuSaati.Enabled = false;

        }

        private void cmb_bolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktorlar.Enabled = true;
            SqlDataAdapter da = new SqlDataAdapter("select PersonelId,concat(RTRIM(Ad),' ' ,Soyad) as AdSoyad from Personel p join DoktorBolum db on p.PersonelId=db.personelid join Bolumler b on b.bolumId=db.bolumid where bolumId=@bolumid", con);
            da.SelectCommand.Parameters.AddWithValue("@bolumid", cmb_bolumler.SelectedIndex + 1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_doktorlar.DataSource = dt;

            cmb_doktorlar.ValueMember = "AdSoyad";
            cmb_doktorlar.ValueMember = "p.PersonelId";

            cmb_doktorlar.SelectedIndex = 0;
            dtp_randevutarihi.Enabled = false;
        }

        private void cmb_doktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //randevu alınabilecek tarihler haftalık olarak gözükücek ve hafasonları gözükmeyecek
            dtp_randevutarihi.Enabled = true;
            dtp_randevutarihi.MinDate = DateTime.Now;
            if ((int)DateTime.Today.DayOfWeek <= 5)
            {
                dtp_randevutarihi.MaxDate = DateTime.Today.AddDays(5 - (int)DateTime.Today.DayOfWeek);
            }
            if ((int)DateTime.Today.DayOfWeek == 6)
            {
                dtp_randevutarihi.MinDate = DateTime.Today.AddDays((int)DateTime.Today.DayOfWeek + 3);
                dtp_randevutarihi.MaxDate = DateTime.Today.AddDays((int)DateTime.Today.DayOfWeek + 7);
            }
            if ((int)DateTime.Today.DayOfWeek == 7)
            {
                dtp_randevutarihi.MinDate = DateTime.Today.AddDays((int)DateTime.Today.DayOfWeek + 2);
                dtp_randevutarihi.MaxDate = DateTime.Today.AddDays((int)DateTime.Today.DayOfWeek + 7);
            }
        }

        private void dtp_randevutarihi_ValueChanged(object sender, EventArgs e)
        {
          
            grup_randevuSaati.Enabled = true;
         

               

        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
             
            string randevuasaati = "";
            int bolumid = 0;
            int personelid = 0;
            bolumid = Convert.ToInt32(cmb_bolumler.SelectedValue.ToString());
            personelid = Convert.ToInt32(cmb_doktorlar.SelectedValue.ToString());
            DateTime dt = dtp_randevutarihi.Value.Date;

            foreach (Control kontrol in this.grup_randevuSaati.Controls)
            {

                if (kontrol is RadioButton)
                {

                    if (((RadioButton)kontrol).Checked == true)
                    {
                        randevuasaati = ((RadioButton)kontrol).Text.ToString();

                    }

                }
            }
            
            if (randevuasaati == "")
            {
                ep_randevusaati.SetError(grup_randevuSaati, "Lütfen randevu saati seçiniz");
            }
               
            else
            {
                
                Kontrol.Randevusaati = randevuasaati;
                Kontrol.Randevutarihi = dt;
                Kontrol.Randevupersonelid = personelid;
                SqlDataAdapter da2 = new SqlDataAdapter("select * from Randevu where RandevuTarihi=@rtarihi and HastaId=@id", con);
                da2.SelectCommand.Parameters.AddWithValue("@id", Kontrol.IlgiliHastaId);
                da2.SelectCommand.Parameters.AddWithValue("@rtarihi", Kontrol.Randevutarihi);
                con.Open();
                DataTable dt3 = new DataTable();
                da2.Fill(dt3);
                con.Close();
                
                    if (dt3.Rows.Count!=0)
                    {
                        ep_randevutarihi.SetError(dtp_randevutarihi, "Bu Tarihe Randevunuz Bulunmaktadır !!!");
                    }
                    else
                    {
                        SqlDataAdapter da3 = new SqlDataAdapter("select * from Randevu where RandevuTarihi=@rtarih and RandevuSaati=@rsaati", con);
                        da3.SelectCommand.Parameters.AddWithValue("@rtarih", Kontrol.Randevutarihi);
                        da3.SelectCommand.Parameters.AddWithValue("@rsaati", Kontrol.Randevusaati);
                        con.Open();
                        DataTable dt4 = new DataTable();
                        da3.Fill(dt4);
                        con.Close();
                        if (dt4.Rows.Count!=0)
                        {
                            ep_randevusaati.SetError(grup_randevuSaati, "Bu Randevu Saati Dolu !!!");
                        }
                        else
                        {
                          randevuonay.Show();
                        }
                        
                    }
               

                
            }
           
        }

        private void grup_randevuSaati_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
