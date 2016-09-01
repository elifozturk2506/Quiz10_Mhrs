using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10Mhrs
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }
        UyeGirisi uyegiris = new UyeGirisi();
        Kaydol kaydol = new Kaydol();
        private void btn_uyegiris_Click(object sender, EventArgs e)
        {
            
            uyegiris.Show();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            kaydol.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
