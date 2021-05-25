namespace Login_032
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
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DTPTanggal = new System.Windows.Forms.DateTimePicker();
            this.CBoxColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxDesign = new System.Windows.Forms.TextBox();
            this.TxtBoxItemName = new System.Windows.Forms.TextBox();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.TxtBoxDesignCari = new System.Windows.Forms.TextBox();
            this.TxtBoxItemNameCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(352, 414);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(75, 24);
            this.BtnHapus.TabIndex = 39;
            this.BtnHapus.Text = "Delete";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(210, 414);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 24);
            this.BtnUpdate.TabIndex = 38;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(66, 414);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 24);
            this.BtnSimpan.TabIndex = 37;
            this.BtnSimpan.Text = "Save";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(352, 56);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 24);
            this.BtnCari.TabIndex = 36;
            this.BtnCari.Text = "Search";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // DTPTanggal
            // 
            this.DTPTanggal.Location = new System.Drawing.Point(164, 371);
            this.DTPTanggal.Name = "DTPTanggal";
            this.DTPTanggal.Size = new System.Drawing.Size(200, 20);
            this.DTPTanggal.TabIndex = 34;
            // 
            // CBoxColor
            // 
            this.CBoxColor.FormattingEnabled = true;
            this.CBoxColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow"});
            this.CBoxColor.Location = new System.Drawing.Point(164, 318);
            this.CBoxColor.Name = "CBoxColor";
            this.CBoxColor.Size = new System.Drawing.Size(121, 21);
            this.CBoxColor.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tanggal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Design";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Design";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Master Product";
            // 
            // TxtBoxDesign
            // 
            this.TxtBoxDesign.Location = new System.Drawing.Point(164, 269);
            this.TxtBoxDesign.Name = "TxtBoxDesign";
            this.TxtBoxDesign.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDesign.TabIndex = 24;
            // 
            // TxtBoxItemName
            // 
            this.TxtBoxItemName.Location = new System.Drawing.Point(164, 218);
            this.TxtBoxItemName.Name = "TxtBoxItemName";
            this.TxtBoxItemName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxItemName.TabIndex = 23;
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Location = new System.Drawing.Point(164, 169);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxID.TabIndex = 22;
            // 
            // TxtBoxDesignCari
            // 
            this.TxtBoxDesignCari.Location = new System.Drawing.Point(164, 106);
            this.TxtBoxDesignCari.Name = "TxtBoxDesignCari";
            this.TxtBoxDesignCari.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDesignCari.TabIndex = 21;
            // 
            // TxtBoxItemNameCari
            // 
            this.TxtBoxItemNameCari.Location = new System.Drawing.Point(164, 60);
            this.TxtBoxItemNameCari.Name = "TxtBoxItemNameCari";
            this.TxtBoxItemNameCari.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxItemNameCari.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 599);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTPTanggal);
            this.Controls.Add(this.CBoxColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxDesign);
            this.Controls.Add(this.TxtBoxItemName);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.TxtBoxDesignCari);
            this.Controls.Add(this.TxtBoxItemNameCari);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTPTanggal;
        private System.Windows.Forms.ComboBox CBoxColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxDesign;
        private System.Windows.Forms.TextBox TxtBoxItemName;
        private System.Windows.Forms.TextBox TxtBoxID;
        private System.Windows.Forms.TextBox TxtBoxDesignCari;
        private System.Windows.Forms.TextBox TxtBoxItemNameCari;
    }
}