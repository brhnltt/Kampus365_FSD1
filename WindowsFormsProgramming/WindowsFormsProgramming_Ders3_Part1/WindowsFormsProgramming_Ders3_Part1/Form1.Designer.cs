namespace WindowsFormsProgramming_Ders3_Part1
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstMetinler = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(19, 233);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(139, 23);
            this.txtMetin.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(164, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstMetinler
            // 
            this.lstMetinler.FormattingEnabled = true;
            this.lstMetinler.ItemHeight = 15;
            this.lstMetinler.Location = new System.Drawing.Point(19, 12);
            this.lstMetinler.Name = "lstMetinler";
            this.lstMetinler.Size = new System.Drawing.Size(220, 214);
            this.lstMetinler.TabIndex = 2;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(164, 262);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 303);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstMetinler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Örnek List Yapısı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstMetinler;
        private System.Windows.Forms.Button btnGoster;
    }
}
