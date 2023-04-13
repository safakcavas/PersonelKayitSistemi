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
            baglanti.Close();

            // sehir sayisi
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From TBL_PERSONEL", baglanti); // distinct tekrarsız olarak sayma işlemi yapar kaç farklı şehir olduğunu listeledik 
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();
            }
            baglanti.Close();
          
            // toplam maas
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(perMaas)  from TBL_PERSONEL", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
            {
                lblTopMaas.Text= dr5[0].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg( perMaas)  from TBL_PERSONEL",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                lblOrtMaas.Text = dr6[0].ToString();
            }

            baglanti.Close();
        }
      


        
        private void lblSehir_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
