namespace MyFirstCustomerProject
{
    partial class Form1
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
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDepartmentList = new System.Windows.Forms.Button();
            this.BtnDepartmentDelete = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Id:";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentID.Location = new System.Drawing.Point(227, 31);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(197, 30);
            this.txtDepartmentID.TabIndex = 1;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDepartmentName.Location = new System.Drawing.Point(227, 67);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(197, 30);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departman Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departman Durum:";
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbActive.Location = new System.Drawing.Point(227, 104);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(71, 29);
            this.rdbActive.TabIndex = 5;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Aktif";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbPassive.Location = new System.Drawing.Point(304, 105);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(76, 29);
            this.rdbPassive.TabIndex = 6;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "Pasif";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 448);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(458, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 142);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Kategori";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(1035, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 142);
            this.panel2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(62, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "XYZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Son Kategori";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(650, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 142);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "XYZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "İlk Kategori";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSalmon;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(843, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 142);
            this.panel6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "A Harfli Kategori";
            // 
            // BtnDepartmentList
            // 
            this.BtnDepartmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDepartmentList.Location = new System.Drawing.Point(843, 201);
            this.BtnDepartmentList.Name = "BtnDepartmentList";
            this.BtnDepartmentList.Size = new System.Drawing.Size(378, 34);
            this.BtnDepartmentList.TabIndex = 12;
            this.BtnDepartmentList.Text = "Verileri Listele";
            this.BtnDepartmentList.UseVisualStyleBackColor = true;
            this.BtnDepartmentList.Click += new System.EventHandler(this.BtnDepartmentList_Click);
            // 
            // BtnDepartmentDelete
            // 
            this.BtnDepartmentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDepartmentDelete.Location = new System.Drawing.Point(843, 241);
            this.BtnDepartmentDelete.Name = "BtnDepartmentDelete";
            this.BtnDepartmentDelete.Size = new System.Drawing.Size(378, 34);
            this.BtnDepartmentDelete.TabIndex = 13;
            this.BtnDepartmentDelete.Text = "Verileri Sil";
            this.BtnDepartmentDelete.UseVisualStyleBackColor = true;
            this.BtnDepartmentDelete.Click += new System.EventHandler(this.BtnDepartmentDelete_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(843, 281);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(378, 34);
            this.btnDepartmentUpdate.TabIndex = 14;
            this.btnDepartmentUpdate.Text = "Verileri Güncelle";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // btnDepartmentSave
            // 
            this.btnDepartmentSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentSave.Location = new System.Drawing.Point(843, 321);
            this.btnDepartmentSave.Name = "btnDepartmentSave";
            this.btnDepartmentSave.Size = new System.Drawing.Size(378, 34);
            this.btnDepartmentSave.TabIndex = 15;
            this.btnDepartmentSave.Text = "Veri Ekle";
            this.btnDepartmentSave.UseVisualStyleBackColor = true;
            this.btnDepartmentSave.Click += new System.EventHandler(this.btnDepartmentSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 754);
            this.Controls.Add(this.btnDepartmentSave);
            this.Controls.Add(this.btnDepartmentUpdate);
            this.Controls.Add(this.BtnDepartmentDelete);
            this.Controls.Add(this.BtnDepartmentList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPassive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDepartmentList;
        private System.Windows.Forms.Button BtnDepartmentDelete;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentSave;
    }
}

