namespace EF_RentACarOrnegi
{
    partial class frmVehicles
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
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAgeLimit = new System.Windows.Forms.NumericUpDown();
            this.nudExtraKMPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDailyPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudLimitKM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraKMPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitKM)).BeginInit();
            this.SuspendLayout();
            // 
            // lstVehicles
            // 
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.ItemHeight = 17;
            this.lstVehicles.Location = new System.Drawing.Point(12, 14);
            this.lstVehicles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(190, 378);
            this.lstVehicles.TabIndex = 0;
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(413, 367);
            this.btnCreateVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(75, 30);
            this.btnCreateVehicle.TabIndex = 1;
            this.btnCreateVehicle.Text = "Ekle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(209, 36);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(279, 25);
            this.txtBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(209, 86);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(279, 25);
            this.txtModel.TabIndex = 3;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(209, 136);
            this.nudYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(137, 25);
            this.nudYear.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yaş Sınırı";
            // 
            // nudAgeLimit
            // 
            this.nudAgeLimit.Location = new System.Drawing.Point(209, 186);
            this.nudAgeLimit.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAgeLimit.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudAgeLimit.Name = "nudAgeLimit";
            this.nudAgeLimit.Size = new System.Drawing.Size(137, 25);
            this.nudAgeLimit.TabIndex = 4;
            this.nudAgeLimit.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nudExtraKMPrice
            // 
            this.nudExtraKMPrice.DecimalPlaces = 2;
            this.nudExtraKMPrice.Location = new System.Drawing.Point(209, 286);
            this.nudExtraKMPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudExtraKMPrice.Name = "nudExtraKMPrice";
            this.nudExtraKMPrice.Size = new System.Drawing.Size(275, 25);
            this.nudExtraKMPrice.TabIndex = 8;
            // 
            // nudDailyPrice
            // 
            this.nudDailyPrice.DecimalPlaces = 2;
            this.nudDailyPrice.Location = new System.Drawing.Point(209, 236);
            this.nudDailyPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDailyPrice.Name = "nudDailyPrice";
            this.nudDailyPrice.Size = new System.Drawing.Size(275, 25);
            this.nudDailyPrice.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ekstra KM Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Günlük Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plaka No";
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(209, 336);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(137, 25);
            this.txtPlateNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "KM Limit";
            // 
            // nudLimitKM
            // 
            this.nudLimitKM.Location = new System.Drawing.Point(352, 337);
            this.nudLimitKM.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLimitKM.Name = "nudLimitKM";
            this.nudLimitKM.Size = new System.Drawing.Size(132, 25);
            this.nudLimitKM.TabIndex = 4;
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 404);
            this.Controls.Add(this.nudExtraKMPrice);
            this.Controls.Add(this.nudDailyPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAgeLimit);
            this.Controls.Add(this.nudLimitKM);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlateNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.lstVehicles);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraKMPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAgeLimit;
        private System.Windows.Forms.NumericUpDown nudExtraKMPrice;
        private System.Windows.Forms.NumericUpDown nudDailyPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudLimitKM;
    }
}