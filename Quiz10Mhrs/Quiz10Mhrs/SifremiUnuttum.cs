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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "";
            if (textBox1.Text!="")
            {
                SqlCommand com = new SqlCommand("Select Password from Hasta where Tc=@tc", con);
                com.Parameters.AddWithValue("@tc", textBox1.Text);
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        sifre = dr.GetString(0);
                    }

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("TC Alanı Boş Geçilemez !!");
            }
            if (sifre=="")
            {
                MessageBox.Show("Yanlış TC Girdiniz !!!");
            }
            else
            {
                MessageBox.Show("Şifreniz = "+sifre);
            }

        }
    }
}
