using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PersonelKayıtSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=safak;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

            //toplam personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from TBL_PERSONEL", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lblToplam.Text = dr1[0].ToString();
            }
            baglanti.Close();


            //evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_Personel where Perdurum=1 ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                lblEvli.Text= dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar personel sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where Perdurum=0 ", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekar.Text = dr3[0].ToString();
            }


        }
    }
}
