namespace WinFormsApp_EF_Ders3_Part2
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddressSave = new System.Windows.Forms.Button();
            this.txtAddressDetail = new System.Windows.Forms.TextBox();
            this.lstAddresses = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPhoneSave = new System.Windows.Forms.Button();
            this.lstPhones = new System.Windows.Forms.ListBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 15;
            this.lstUsers.Location = new System.Drawing.Point(6, 32);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(188, 259);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.btnAddNewUser);
            this.groupBox1.Controls.Add(this.lstUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 355);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(188, 23);
            this.txtPass.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "E-Mail";
            this.txtEmail.Size = new System.Drawing.Size(188, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(6, 297);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Full name";
            this.txtFullName.Size = new System.Drawing.Size(188, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(119, 384);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Add New";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddressSave);
            this.groupBox2.Controls.Add(this.txtAddressDetail);
            this.groupBox2.Controls.Add(this.lstAddresses);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Addresses";
            // 
            // btnAddressSave
            // 
            this.btnAddressSave.Location = new System.Drawing.Point(119, 221);
            this.btnAddressSave.Name = "btnAddressSave";
            this.btnAddressSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddressSave.TabIndex = 2;
            this.btnAddressSave.Text = "Save";
            this.btnAddressSave.UseVisualStyleBackColor = true;
            this.btnAddressSave.Click += new System.EventHandler(this.btnAddressSave_Click);
            // 
            // txtAddressDetail
            // 
            this.txtAddressDetail.Location = new System.Drawing.Point(6, 192);
            this.txtAddressDetail.Name = "txtAddressDetail";
            this.txtAddressDetail.Size = new System.Drawing.Size(188, 23);
            this.txtAddressDetail.TabIndex = 1;
            // 
            // lstAddresses
            // 
            this.lstAddresses.FormattingEnabled = true;
            this.lstAddresses.ItemHeight = 15;
            this.lstAddresses.Location = new System.Drawing.Point(6, 32);
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.Size = new System.Drawing.Size(188, 154);
            this.lstAddresses.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPhoneSave);
            this.groupBox3.Controls.Add(this.lstPhones);
            this.groupBox3.Controls.Add(this.txtPhoneNumber);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 291);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phones";
            // 
            // btnPhoneSave
            // 
            this.btnPhoneSave.Location = new System.Drawing.Point(119, 221);
            this.btnPhoneSave.Name = "btnPhoneSave";
            this.btnPhoneSave.Size = new System.Drawing.Size(75, 23);
            this.btnPhoneSave.TabIndex = 2;
            this.btnPhoneSave.Text = "Save";
            this.btnPhoneSave.UseVisualStyleBackColor = true;
            this.btnPhoneSave.Click += new System.EventHandler(this.btnPhoneSave_Click);
            // 
            // lstPhones
            // 
            this.lstPhones.FormattingEnabled = true;
            this.lstPhones.ItemHeight = 15;
            this.lstPhones.Location = new System.Drawing.Point(6, 32);
            this.lstPhones.Name = "lstPhones";
            this.lstPhones.Size = new System.Drawing.Size(188, 154);
            this.lstPhones.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(6, 192);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(188, 23);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 444);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddressSave;
        private System.Windows.Forms.TextBox txtAddressDetail;
        private System.Windows.Forms.ListBox lstAddresses;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPhoneSave;
        private System.Windows.Forms.ListBox lstPhones;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}
