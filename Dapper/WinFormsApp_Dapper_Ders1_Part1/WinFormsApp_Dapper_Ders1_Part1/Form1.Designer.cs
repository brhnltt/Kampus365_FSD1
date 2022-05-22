namespace WinFormsApp_Dapper_Ders1_Part1
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect3 = new System.Windows.Forms.Button();
            this.btnMultipleInsert = new System.Windows.Forms.Button();
            this.btnSelectIn = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnStoredProcedure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 142);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(102, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 394);
            this.listBox1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(12, 41);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 23);
            this.btnSelect2.TabIndex = 3;
            this.btnSelect2.Text = "Select 2";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect3
            // 
            this.btnSelect3.Location = new System.Drawing.Point(12, 70);
            this.btnSelect3.Name = "btnSelect3";
            this.btnSelect3.Size = new System.Drawing.Size(75, 23);
            this.btnSelect3.TabIndex = 6;
            this.btnSelect3.Text = "Select 3";
            this.btnSelect3.UseVisualStyleBackColor = true;
            this.btnSelect3.Click += new System.EventHandler(this.btnSelect3_Click);
            // 
            // btnMultipleInsert
            // 
            this.btnMultipleInsert.Location = new System.Drawing.Point(12, 171);
            this.btnMultipleInsert.Name = "btnMultipleInsert";
            this.btnMultipleInsert.Size = new System.Drawing.Size(75, 43);
            this.btnMultipleInsert.TabIndex = 7;
            this.btnMultipleInsert.Text = "Multiple Insert";
            this.btnMultipleInsert.UseVisualStyleBackColor = true;
            this.btnMultipleInsert.Click += new System.EventHandler(this.btnMultipleInsert_Click);
            // 
            // btnSelectIn
            // 
            this.btnSelectIn.Location = new System.Drawing.Point(12, 99);
            this.btnSelectIn.Name = "btnSelectIn";
            this.btnSelectIn.Size = new System.Drawing.Size(75, 23);
            this.btnSelectIn.TabIndex = 8;
            this.btnSelectIn.Text = "Select IN";
            this.btnSelectIn.UseVisualStyleBackColor = true;
            this.btnSelectIn.Click += new System.EventHandler(this.btnSelectIn_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(12, 305);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnTransaction.TabIndex = 9;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.Location = new System.Drawing.Point(12, 334);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(75, 40);
            this.btnStoredProcedure.TabIndex = 10;
            this.btnStoredProcedure.Text = "Stored Procedure";
            this.btnStoredProcedure.UseVisualStyleBackColor = true;
            this.btnStoredProcedure.Click += new System.EventHandler(this.btnStoredProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 417);
            this.Controls.Add(this.btnStoredProcedure);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnSelectIn);
            this.Controls.Add(this.btnMultipleInsert);
            this.Controls.Add(this.btnSelect3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Dapper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect3;
        private System.Windows.Forms.Button btnMultipleInsert;
        private System.Windows.Forms.Button btnSelectIn;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnStoredProcedure;
    }
}
