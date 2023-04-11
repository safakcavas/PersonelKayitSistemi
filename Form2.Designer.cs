namespace PersonelKayıtSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.TextBox();
            this.lblEvli = new System.Windows.Forms.TextBox();
            this.lblBekar = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTopMaas = new System.Windows.Forms.TextBox();
            this.lblOrtMaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // lblToplam
            // 
            this.lblToplam.Location = new System.Drawing.Point(184, 52);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(100, 31);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "0";
            // 
            // lblEvli
            // 
            this.lblEvli.Location = new System.Drawing.Point(184, 91);
            this.lblEvli.Name = "lblEvli";
            this.lblEvli.Size = new System.Drawing.Size(100, 31);
            this.lblEvli.TabIndex = 7;
            this.lblEvli.Text = "0";
            // 
            // lblBekar
            // 
            this.lblBekar.Location = new System.Drawing.Point(184, 130);
            this.lblBekar.Name = "lblBekar";
            this.lblBekar.Size = new System.Drawing.Size(100, 31);
            this.lblBekar.TabIndex = 8;
            this.lblBekar.Text = "0";
            // 
            // lblSehir
            // 
            this.lblSehir.Location = new System.Drawing.Point(184, 169);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(100, 31);
            this.lblSehir.TabIndex = 9;
            this.lblSehir.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toplam Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ortalama Maaş:";
            // 
            // lblTopMaas
            // 
            this.lblTopMaas.Location = new System.Drawing.Point(184, 216);
            this.lblTopMaas.Name = "lblTopMaas";
            this.lblTopMaas.Size = new System.Drawing.Size(100, 31);
            this.lblTopMaas.TabIndex = 12;
            this.lblTopMaas.Text = "0";
            // 
            // lblOrtMaas
            // 
            this.lblOrtMaas.Location = new System.Drawing.Point(184, 262);
            this.lblOrtMaas.Name = "lblOrtMaas";
            this.lblOrtMaas.Size = new System.Drawing.Size(100, 31);
            this.lblOrtMaas.TabIndex = 13;
            this.lblOrtMaas.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 305);
            this.Controls.Add(this.lblOrtMaas);
            this.Controls.Add(this.lblTopMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblBekar);
            this.Controls.Add(this.lblEvli);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "Frmistatistik";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblToplam;
        private System.Windows.Forms.TextBox lblEvli;
        private System.Windows.Forms.TextBox lblBekar;
        private System.Windows.Forms.TextBox lblSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblTopMaas;
        private System.Windows.Forms.TextBox lblOrtMaas;
    }
}