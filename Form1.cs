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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        SqlConnection baglanti = new SqlConnection("Data Source=safak;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");


        void temizle()
        {
            TxtId.Text = "";
            TxtSoyad.Text = "";
            TxtAd.Text = "";
            TxtMeslek.Text = "";
            CmbSehir.Text = "";
            MskMaas.Text = "";
            RdnBekar.Checked = false;
            RdnEvli.Checked = false;
            TxtAd.Focus();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void personelVeriTabanıDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tBL_PERSONELTableAdapter.Fill(this.personelVeriTabanıDataSet1.TBL_PERSONEL);
        }

        private void LblAd_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,perSehir,permaas,permeslek,perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");
            baglanti.Close();
        }

        //private void rdnevli_checkedchanged(object sender, eventargs e)
        //{
        //   if(rdnevli.checked == true )
        //    {

        //    label1.text = "true";
        //    }

        //}

        //private void RdnBekar_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RdnBekar.Checked == true)
        //    {

        //        label1.Text = "False";
        //    }

            
        //}

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
        
        
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel Where PerId=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("PERSONEL SİLİNDİ");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where PerId=@a7", baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", CmbSehir.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", MskMaas.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", label1.Text);
            komutgüncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutgüncelle.Parameters.AddWithValue("@a7", TxtId.Text);
            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        //private void label1_TextChanged(object sender, EventArgs e)
        //{
        //    if(label1.Text=="true")
        //    {
        //        RdnEvli.Checked = true;
        //    }
        //    if(label1.Text=="false")
        //    {
        //        RdnBekar.Checked = true;
        //    }

        //}


    }
}
