namespace PersonelKayıtSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.RdnBekar = new System.Windows.Forms.RadioButton();
            this.RdnEvli = new System.Windows.Forms.RadioButton();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblMeslek = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.LblMaas = new System.Windows.Forms.Label();
            this.LblSehir = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.Lblid = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLPERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabanıDataSet1 = new PersonelKayıtSistemi.PersonelVeriTabanıDataSet1();
            this.tBL_PERSONELTableAdapter = new PersonelKayıtSistemi.PersonelVeriTabanıDataSet1TableAdapters.TBL_PERSONELTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbSehir);
            this.groupBox1.Controls.Add(this.MskMaas);
            this.groupBox1.Controls.Add(this.RdnBekar);
            this.groupBox1.Controls.Add(this.RdnEvli);
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.LblMeslek);
            this.groupBox1.Controls.Add(this.LblDurum);
            this.groupBox1.Controls.Add(this.LblMaas);
            this.groupBox1.Controls.Add(this.LblSehir);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.Lblid);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 345);
            this.groupBox1.TabIndex = 5454;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(128, 160);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(98, 31);
            this.CmbSehir.TabIndex = 545346;
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(128, 198);
            this.MskMaas.Mask = "0000";
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(100, 31);
            this.MskMaas.TabIndex = 4;
            // 
            // RdnBekar
            // 
            this.RdnBekar.AutoSize = true;
            this.RdnBekar.Location = new System.Drawing.Point(168, 235);
            this.RdnBekar.Name = "RdnBekar";
            this.RdnBekar.Size = new System.Drawing.Size(72, 27);
            this.RdnBekar.TabIndex = 6;
            this.RdnBekar.TabStop = true;
            this.RdnBekar.Text = "Bekar";
            this.RdnBekar.UseVisualStyleBackColor = true;
            this.RdnBekar.CheckedChanged += new System.EventHandler(this.RdnBekar_CheckedChanged);
            // 
            // RdnEvli
            // 
            this.RdnEvli.AutoSize = true;
            this.RdnEvli.Location = new System.Drawing.Point(107, 235);
            this.RdnEvli.Name = "RdnEvli";
            this.RdnEvli.Size = new System.Drawing.Size(55, 27);
            this.RdnEvli.TabIndex = 5;
            this.RdnEvli.TabStop = true;
            this.RdnEvli.Text = "Evli";
            this.RdnEvli.UseVisualStyleBackColor = true;
            this.RdnEvli.CheckedChanged += new System.EventHandler(this.RdnEvli_CheckedChanged);
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(128, 268);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(100, 31);
            this.TxtMeslek.TabIndex = 7;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(128, 123);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 31);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(128, 86);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 31);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(128, 46);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 31);
            this.TxtId.TabIndex = 0;
            this.TxtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblMeslek
            // 
            this.LblMeslek.AutoSize = true;
            this.LblMeslek.Location = new System.Drawing.Point(23, 271);
            this.LblMeslek.Name = "LblMeslek";
            this.LblMeslek.Size = new System.Drawing.Size(65, 23);
            this.LblMeslek.TabIndex = 64354;
            this.LblMeslek.Text = "Meslek";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(23, 234);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(65, 23);
            this.LblDurum.TabIndex = 545345;
            this.LblDurum.Text = "Durum";
            // 
            // LblMaas
            // 
            this.LblMaas.AutoSize = true;
            this.LblMaas.Location = new System.Drawing.Point(23, 197);
            this.LblMaas.Name = "LblMaas";
            this.LblMaas.Size = new System.Drawing.Size(52, 23);
            this.LblMaas.TabIndex = 445345;
            this.LblMaas.Text = "Maaş";
            // 
            // LblSehir
            // 
            this.LblSehir.AutoSize = true;
            this.LblSehir.Location = new System.Drawing.Point(23, 160);
            this.LblSehir.Name = "LblSehir";
            this.LblSehir.Size = new System.Drawing.Size(49, 23);
            this.LblSehir.TabIndex = 34534;
            this.LblSehir.Text = "Şehir";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(23, 123);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(58, 23);
            this.LblSoyad.TabIndex = 25464;
            this.LblSoyad.Text = "Soyad";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(23, 86);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(106, 23);
            this.LblAd.TabIndex = 11212;
            this.LblAd.Text = "Personel Ad:";
            this.LblAd.Click += new System.EventHandler(this.LblAd_Click);
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.Location = new System.Drawing.Point(23, 49);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(99, 23);
            this.Lblid.TabIndex = 1111;
            this.Lblid.Text = "Personel id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafikler);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(340, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 345);
            this.groupBox2.TabIndex = 4142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Location = new System.Drawing.Point(49, 292);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(173, 37);
            this.BtnGrafikler.TabIndex = 14;
            this.BtnGrafikler.Text = "Grafikler";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.Location = new System.Drawing.Point(49, 250);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(173, 37);
            this.Btnİstatistik.TabIndex = 13;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(49, 208);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(173, 37);
            this.BtnTemizle.TabIndex = 12;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(49, 166);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(173, 37);
            this.BtnGüncelle.TabIndex = 11;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(49, 124);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(173, 37);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(49, 82);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(173, 37);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(49, 40);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(173, 37);
            this.BtnListele.TabIndex = 8;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLPERSONELBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 153);
            this.dataGridView1.TabIndex = 5455;
            this.dataGridView1.Tag = "Kayıtlar";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "perMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "perMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "perDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "perDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "perMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "perMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tBLPERSONELBindingSource
            // 
            this.tBLPERSONELBindingSource.DataMember = "TBL_PERSONEL";
            this.tBLPERSONELBindingSource.DataSource = this.personelVeriTabanıDataSet1;
            // 
            // personelVeriTabanıDataSet1
            // 
            this.personelVeriTabanıDataSet1.DataSetName = "PersonelVeriTabanıDataSet1";
            this.personelVeriTabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_PERSONELTableAdapter
            // 
            this.tBL_PERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 545347;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(842, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskMaas;
        private System.Windows.Forms.RadioButton RdnBekar;
        private System.Windows.Forms.RadioButton RdnEvli;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblMeslek;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label LblMaas;
        private System.Windows.Forms.Label LblSehir;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label Lblid;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabanıDataSet1 personelVeriTabanıDataSet1;
        private System.Windows.Forms.BindingSource tBLPERSONELBindingSource;
        private PersonelVeriTabanıDataSet1TableAdapters.TBL_PERSONELTableAdapter tBL_PERSONELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.Label label1;
    }
}

