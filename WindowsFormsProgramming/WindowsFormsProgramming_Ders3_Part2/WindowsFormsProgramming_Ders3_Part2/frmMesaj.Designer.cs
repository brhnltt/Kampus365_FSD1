namespace WindowsFormsProgramming_Ders3_Part2
{
    partial class frmMesaj
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
            this.btnDetayFormAc = new System.Windows.Forms.Button();
            this.btnDetayFormAc2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDetayFormaAktar = new System.Windows.Forms.Button();
            this.btnDetayFormaAktar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetayFormAc
            // 
            this.btnDetayFormAc.Location = new System.Drawing.Point(12, 12);
            this.btnDetayFormAc.Name = "btnDetayFormAc";
            this.btnDetayFormAc.Size = new System.Drawing.Size(208, 23);
            this.btnDetayFormAc.TabIndex = 0;
            this.btnDetayFormAc.Text = "Detay Form Aç (Show Dialog)";
            this.btnDetayFormAc.UseVisualStyleBackColor = true;
            this.btnDetayFormAc.Click += new System.EventHandler(this.btnDetayFormAc_Click);
            // 
            // btnDetayFormAc2
            // 
            this.btnDetayFormAc2.Location = new System.Drawing.Point(12, 41);
            this.btnDetayFormAc2.Name = "btnDetayFormAc2";
            this.btnDetayFormAc2.Size = new System.Drawing.Size(208, 23);
            this.btnDetayFormAc2.TabIndex = 1;
            this.btnDetayFormAc2.Text = "Detay Form Aç (Show)";
            this.btnDetayFormAc2.UseVisualStyleBackColor = true;
            this.btnDetayFormAc2.Click += new System.EventHandler(this.btnDetayFormAc2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 2;
            // 
            // btnDetayFormaAktar
            // 
            this.btnDetayFormaAktar.Location = new System.Drawing.Point(173, 114);
            this.btnDetayFormaAktar.Name = "btnDetayFormaAktar";
            this.btnDetayFormaAktar.Size = new System.Drawing.Size(186, 23);
            this.btnDetayFormaAktar.TabIndex = 3;
            this.btnDetayFormaAktar.Text = "Detay Forma Aktar 1";
            this.btnDetayFormaAktar.UseVisualStyleBackColor = true;
            this.btnDetayFormaAktar.Click += new System.EventHandler(this.btnDetayFormaAktar_Click);
            // 
            // btnDetayFormaAktar2
            // 
            this.btnDetayFormaAktar2.Location = new System.Drawing.Point(173, 143);
            this.btnDetayFormaAktar2.Name = "btnDetayFormaAktar2";
            this.btnDetayFormaAktar2.Size = new System.Drawing.Size(186, 23);
            this.btnDetayFormaAktar2.TabIndex = 4;
            this.btnDetayFormaAktar2.Text = "Detay Forma Aktar 2";
            this.btnDetayFormaAktar2.UseVisualStyleBackColor = true;
            this.btnDetayFormaAktar2.Click += new System.EventHandler(this.btnDetayFormaAktar2_Click);
            // 
            // frmMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 196);
            this.Controls.Add(this.btnDetayFormaAktar2);
            this.Controls.Add(this.btnDetayFormaAktar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDetayFormAc2);
            this.Controls.Add(this.btnDetayFormAc);
            this.Name = "frmMesaj";
            this.Text = "frmMesaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetayFormAc;
        private System.Windows.Forms.Button btnDetayFormAc2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDetayFormaAktar;
        private System.Windows.Forms.Button btnDetayFormaAktar2;
    }
}