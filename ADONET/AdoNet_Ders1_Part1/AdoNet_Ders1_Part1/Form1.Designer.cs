namespace AdoNet_Ders1_Part1
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
            this.btnSqlConnectionOpenClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnTotalCategoryIds = new System.Windows.Forms.Button();
            this.txtInsertCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdCatName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTotalCatExeScalar = new System.Windows.Forms.Button();
            this.btnReadFromStoredProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSqlConnectionOpenClose
            // 
            this.btnSqlConnectionOpenClose.Location = new System.Drawing.Point(12, 12);
            this.btnSqlConnectionOpenClose.Name = "btnSqlConnectionOpenClose";
            this.btnSqlConnectionOpenClose.Size = new System.Drawing.Size(220, 50);
            this.btnSqlConnectionOpenClose.TabIndex = 0;
            this.btnSqlConnectionOpenClose.Text = "SQL Bağlantı Aç ve Kapat";
            this.btnSqlConnectionOpenClose.UseVisualStyleBackColor = true;
            this.btnSqlConnectionOpenClose.Click += new System.EventHandler(this.btnSqlConnectionOpenClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 597);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 68);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(220, 38);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select All Categories";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnTotalCategoryIds
            // 
            this.btnTotalCategoryIds.Location = new System.Drawing.Point(12, 112);
            this.btnTotalCategoryIds.Name = "btnTotalCategoryIds";
            this.btnTotalCategoryIds.Size = new System.Drawing.Size(220, 32);
            this.btnTotalCategoryIds.TabIndex = 3;
            this.btnTotalCategoryIds.Text = "Total Category Ids";
            this.btnTotalCategoryIds.UseVisualStyleBackColor = true;
            this.btnTotalCategoryIds.Click += new System.EventHandler(this.btnTotalCategoryIds_Click);
            // 
            // txtInsertCatName
            // 
            this.txtInsertCatName.Location = new System.Drawing.Point(12, 327);
            this.txtInsertCatName.MaxLength = 20;
            this.txtInsertCatName.Name = "txtInsertCatName";
            this.txtInsertCatName.PlaceholderText = "Category Name";
            this.txtInsertCatName.Size = new System.Drawing.Size(220, 23);
            this.txtInsertCatName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(157, 356);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Update";
            // 
            // txtUpdCatName
            // 
            this.txtUpdCatName.Location = new System.Drawing.Point(12, 426);
            this.txtUpdCatName.MaxLength = 20;
            this.txtUpdCatName.Name = "txtUpdCatName";
            this.txtUpdCatName.PlaceholderText = "Category Name";
            this.txtUpdCatName.Size = new System.Drawing.Size(220, 23);
            this.txtUpdCatName.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category Delete";
            // 
            // btnTotalCatExeScalar
            // 
            this.btnTotalCatExeScalar.Location = new System.Drawing.Point(12, 150);
            this.btnTotalCatExeScalar.Name = "btnTotalCatExeScalar";
            this.btnTotalCatExeScalar.Size = new System.Drawing.Size(220, 32);
            this.btnTotalCatExeScalar.TabIndex = 15;
            this.btnTotalCatExeScalar.Text = "Total Cat Ids By ExecuteScalar";
            this.btnTotalCatExeScalar.UseVisualStyleBackColor = true;
            this.btnTotalCatExeScalar.Click += new System.EventHandler(this.btnTotalCatExeScalar_Click);
            // 
            // btnReadFromStoredProcedure
            // 
            this.btnReadFromStoredProcedure.Location = new System.Drawing.Point(12, 188);
            this.btnReadFromStoredProcedure.Name = "btnReadFromStoredProcedure";
            this.btnReadFromStoredProcedure.Size = new System.Drawing.Size(220, 23);
            this.btnReadFromStoredProcedure.TabIndex = 16;
            this.btnReadFromStoredProcedure.Text = "Read From Stored Procedure";
            this.btnReadFromStoredProcedure.UseVisualStyleBackColor = true;
            this.btnReadFromStoredProcedure.Click += new System.EventHandler(this.btnReadFromStoredProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 621);
            this.Controls.Add(this.btnReadFromStoredProcedure);
            this.Controls.Add(this.btnTotalCatExeScalar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdCatName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsertCatName);
            this.Controls.Add(this.btnTotalCategoryIds);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSqlConnectionOpenClose);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSqlConnectionOpenClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnTotalCategoryIds;
        private System.Windows.Forms.TextBox txtInsertCatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdCatName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTotalCatExeScalar;
        private System.Windows.Forms.Button btnReadFromStoredProcedure;
    }
}
