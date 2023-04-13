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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=safak;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by perSehir ", baglanti);
            SqlDataReader rd1 = komut1.ExecuteReader();
            while(rd1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(rd1[0], rd1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) from Tbl_Personel group by permeslek", baglanti);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while(rd2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(rd2[0], rd2[1]);
            }
            baglanti.Close();



        }
    }
}
