namespace WindowsFormsProgramming_Ders2_Part1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtTelefonYeni = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtNotYeni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGrupYeni = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEPostaYeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyadYeni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblKisiBilgiDetay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKisiler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler";
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 15;
            this.lstKisiler.Items.AddRange(new object[] {
            "Murat Başeren - 0555 888 77 66",
            "Burhan Altıntaş - 0555 888 77 61",
            "Feyza Aşenel - 0555 888 77 62",
            "Berat Sarıkamış - 0555 888 77 63"});
            this.lstKisiler.Location = new System.Drawing.Point(6, 35);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(346, 409);
            this.lstKisiler.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtTelefonYeni);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtNotYeni);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbGrupYeni);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEPostaYeni);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAdSoyadYeni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(376, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Ekleme";
            // 
            // mtxtTelefonYeni
            // 
            this.mtxtTelefonYeni.Location = new System.Drawing.Point(88, 53);
            this.mtxtTelefonYeni.Mask = "(999) 000 00 00";
            this.mtxtTelefonYeni.Name = "mtxtTelefonYeni";
            this.mtxtTelefonYeni.Size = new System.Drawing.Size(152, 23);
            this.mtxtTelefonYeni.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(317, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtNotYeni
            // 
            this.txtNotYeni.Location = new System.Drawing.Point(317, 24);
            this.txtNotYeni.Multiline = true;
            this.txtNotYeni.Name = "txtNotYeni";
            this.txtNotYeni.PlaceholderText = "...";
            this.txtNotYeni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotYeni.Size = new System.Drawing.Size(145, 110);
            this.txtNotYeni.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Not :";
            // 
            // cmbGrupYeni
            // 
            this.cmbGrupYeni.FormattingEnabled = true;
            this.cmbGrupYeni.Items.AddRange(new object[] {
            "Arkadaş",
            "Aile",
            "Yakın Dost",
            "Can Kurtaran"});
            this.cmbGrupYeni.Location = new System.Drawing.Point(88, 111);
            this.cmbGrupYeni.Name = "cmbGrupYeni";
            this.cmbGrupYeni.Size = new System.Drawing.Size(152, 23);
            this.cmbGrupYeni.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grubu :";
            // 
            // txtEPostaYeni
            // 
            this.txtEPostaYeni.Location = new System.Drawing.Point(88, 82);
            this.txtEPostaYeni.Name = "txtEPostaYeni";
            this.txtEPostaYeni.PlaceholderText = "john@doe.com";
            this.txtEPostaYeni.Size = new System.Drawing.Size(152, 23);
            this.txtEPostaYeni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon :";
            // 
            // txtAdSoyadYeni
            // 
            this.txtAdSoyadYeni.Location = new System.Drawing.Point(88, 24);
            this.txtAdSoyadYeni.MaxLength = 50;
            this.txtAdSoyadYeni.Name = "txtAdSoyadYeni";
            this.txtAdSoyadYeni.PlaceholderText = "John Doe";
            this.txtAdSoyadYeni.Size = new System.Drawing.Size(152, 23);
            this.txtAdSoyadYeni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(317, 150);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblKisiBilgiDetay);
            this.groupBox4.Location = new System.Drawing.Point(376, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 82);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kişi Sil";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(392, 51);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(312, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Silmek istediğinize emin misiniz?";
            // 
            // lblKisiBilgiDetay
            // 
            this.lblKisiBilgiDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKisiBilgiDetay.Location = new System.Drawing.Point(19, 23);
            this.lblKisiBilgiDetay.Name = "lblKisiBilgiDetay";
            this.lblKisiBilgiDetay.Size = new System.Drawing.Size(277, 46);
            this.lblKisiBilgiDetay.TabIndex = 0;
            this.lblKisiBilgiDetay.Text = "Murat Başeren - murat.baseren@codeove.com - 0555 888 77 66 - Arkadaş asdas dsa ad" +
    "s as das sad sa dsa";
            this.lblKisiBilgiDetay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ad Soyad :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(88, 24);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(152, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-Posta :";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(88, 82);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(152, 23);
            this.txtEPosta.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grubu :";
            // 
            // cmbGrup
            // 
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Items.AddRange(new object[] {
            "Arkadaş",
            "Aile",
            "Yakın Dost",
            "Can Kurtaran"});
            this.cmbGrup.Location = new System.Drawing.Point(88, 111);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(152, 23);
            this.cmbGrup.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Not :";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(317, 24);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNot.Size = new System.Drawing.Size(145, 110);
            this.txtNot.TabIndex = 9;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(88, 53);
            this.mtxtTelefon.Mask = "(999) 000 00 00";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(152, 23);
            this.mtxtTelefon.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtTelefon);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.txtNot);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbGrup);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEPosta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAdSoyad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(376, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Düzenleme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 476);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Defteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtNotYeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGrupYeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEPostaYeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyadYeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblKisiBilgiDetay;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonYeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGrup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
