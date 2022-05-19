namespace EF_RentACarOrnegi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.LinkLabel();
            this.btnCreateVehicle = new System.Windows.Forms.LinkLabel();
            this.btnDelRent = new System.Windows.Forms.Button();
            this.btnSaveRent = new System.Windows.Forms.Button();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.cmbRentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudExtraPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudEndKM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudStartKM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRentings = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.nudLimitKM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitKM)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSummary);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelRent);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveRent);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewRent);
            this.splitContainer1.Panel1.Controls.Add(this.cmbRentType);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.nudExtraPrice);
            this.splitContainer1.Panel1.Controls.Add(this.nudDiscount);
            this.splitContainer1.Panel1.Controls.Add(this.nudPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.nudLimitKM);
            this.splitContainer1.Panel1.Controls.Add(this.nudEndKM);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.nudStartKM);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbVehicles);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRentings);
            this.splitContainer1.Size = new System.Drawing.Size(1009, 668);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSummary
            // 
            this.lblSummary.Location = new System.Drawing.Point(12, 595);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(266, 63);
            this.lblSummary.TabIndex = 10;
            this.lblSummary.Text = "Notlar :";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.AutoSize = true;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCustomer.Location = new System.Drawing.Point(191, 64);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(96, 15);
            this.btnCreateCustomer.TabIndex = 9;
            this.btnCreateCustomer.TabStop = true;
            this.btnCreateCustomer.Text = "Yeni Müşteri Ekle";
            this.btnCreateCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCreateCustomer_LinkClicked);
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.AutoSize = true;
            this.btnCreateVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateVehicle.Location = new System.Drawing.Point(208, 14);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(80, 15);
            this.btnCreateVehicle.TabIndex = 9;
            this.btnCreateVehicle.TabStop = true;
            this.btnCreateVehicle.Text = "Yeni Araç Ekle";
            this.btnCreateVehicle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCreateVehicle_LinkClicked);
            // 
            // btnDelRent
            // 
            this.btnDelRent.Location = new System.Drawing.Point(51, 563);
            this.btnDelRent.Name = "btnDelRent";
            this.btnDelRent.Size = new System.Drawing.Size(75, 29);
            this.btnDelRent.TabIndex = 8;
            this.btnDelRent.Text = "Sil";
            this.btnDelRent.UseVisualStyleBackColor = true;
            // 
            // btnSaveRent
            // 
            this.btnSaveRent.Location = new System.Drawing.Point(132, 563);
            this.btnSaveRent.Name = "btnSaveRent";
            this.btnSaveRent.Size = new System.Drawing.Size(75, 29);
            this.btnSaveRent.TabIndex = 8;
            this.btnSaveRent.Text = "Kaydet";
            this.btnSaveRent.UseVisualStyleBackColor = true;
            // 
            // btnNewRent
            // 
            this.btnNewRent.Location = new System.Drawing.Point(213, 563);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(75, 29);
            this.btnNewRent.TabIndex = 8;
            this.btnNewRent.Text = "Ekle";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // cmbRentType
            // 
            this.cmbRentType.FormattingEnabled = true;
            this.cmbRentType.Items.AddRange(new object[] {
            "Yok",
            "Kısa Dönem Kiralama",
            "Uzun Dönem Kiralama"});
            this.cmbRentType.Location = new System.Drawing.Point(12, 232);
            this.cmbRentType.Name = "cmbRentType";
            this.cmbRentType.Size = new System.Drawing.Size(275, 25);
            this.cmbRentType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kiralama Türü";
            // 
            // nudExtraPrice
            // 
            this.nudExtraPrice.DecimalPlaces = 2;
            this.nudExtraPrice.Location = new System.Drawing.Point(12, 532);
            this.nudExtraPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudExtraPrice.Name = "nudExtraPrice";
            this.nudExtraPrice.Size = new System.Drawing.Size(275, 25);
            this.nudExtraPrice.TabIndex = 5;
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Location = new System.Drawing.Point(13, 482);
            this.nudDiscount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(275, 25);
            this.nudDiscount.TabIndex = 5;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(12, 432);
            this.nudPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(275, 25);
            this.nudPrice.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ekstra Bedel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "İndirim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fiyat";
            // 
            // nudEndKM
            // 
            this.nudEndKM.Location = new System.Drawing.Point(12, 332);
            this.nudEndKM.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndKM.Name = "nudEndKM";
            this.nudEndKM.Size = new System.Drawing.Size(275, 25);
            this.nudEndKM.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Teslim Zamanı KM";
            // 
            // nudStartKM
            // 
            this.nudStartKM.Location = new System.Drawing.Point(12, 282);
            this.nudStartKM.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStartKM.Name = "nudStartKM";
            this.nudStartKM.Size = new System.Drawing.Size(275, 25);
            this.nudStartKM.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alım Zamanı KM";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(12, 182);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(275, 25);
            this.dtpEndDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teslim Tarihi";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 132);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(275, 25);
            this.dtpStartDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alım Tarihi";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(12, 82);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(275, 25);
            this.cmbCustomers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteriler";
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Location = new System.Drawing.Point(12, 32);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(275, 25);
            this.cmbVehicles.TabIndex = 1;
            this.cmbVehicles.SelectedIndexChanged += new System.EventHandler(this.cmbVehicles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araçlar";
            // 
            // dgvRentings
            // 
            this.dgvRentings.AllowUserToAddRows = false;
            this.dgvRentings.AllowUserToDeleteRows = false;
            this.dgvRentings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentings.Location = new System.Drawing.Point(0, 0);
            this.dgvRentings.Name = "dgvRentings";
            this.dgvRentings.ReadOnly = true;
            this.dgvRentings.RowTemplate.Height = 25;
            this.dgvRentings.Size = new System.Drawing.Size(705, 668);
            this.dgvRentings.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "KM Limit";
            // 
            // nudLimitKM
            // 
            this.nudLimitKM.Location = new System.Drawing.Point(12, 382);
            this.nudLimitKM.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLimitKM.Name = "nudLimitKM";
            this.nudLimitKM.Size = new System.Drawing.Size(275, 25);
            this.nudLimitKM.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 668);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvRentings;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStartKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudEndKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelRent;
        private System.Windows.Forms.Button btnSaveRent;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.NumericUpDown nudExtraPrice;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel btnCreateCustomer;
        private System.Windows.Forms.LinkLabel btnCreateVehicle;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.NumericUpDown nudLimitKM;
        private System.Windows.Forms.Label label11;
    }
}
