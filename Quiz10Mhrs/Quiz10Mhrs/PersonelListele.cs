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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;Database=MhrsDB;Trusted_Connection=True;");
        private void PersonelListele_Load(object sender, EventArgs e)
        {
            cmb_personeltip.SelectedIndex = 0;
            PersonelList(0);





        }
        public void PersonelList(int personeltipid)
        {
            if (personeltipid!=0)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Personel where PersonelTipId=@id and IsDeleted=0", con);
                da.SelectCommand.Parameters.AddWithValue("@id", personeltipid);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgw_personelList.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Personel where IsDeleted=0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgw_personelList.DataSource = dt;
            }
           
        }
        private void cmb_personeltip_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgw_personelList.DataSource = null;
            if (cmb_personeltip.SelectedIndex==1)
            {
                PersonelList(8);
            }
            else if (cmb_personeltip.SelectedIndex == 2)
            {
                PersonelList(9);
            }
            else
            {
                PersonelList(10);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personelid = dgw_personelList.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result= MessageBox.Show("Silmek İstediğinizden Emin Misiniz !!!", "Personel Silme İsteği", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlDataAdapter da = new SqlDataAdapter("update from Personel set IsDeleted=1 where PersonelId=@id", con);
                da.SelectCommand.Parameters.AddWithValue("@id", personelid);
                da.SelectCommand.ExecuteNonQuery();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi...");
            }
         
         


           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
