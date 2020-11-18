namespace Admin
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TombolCetak = new System.Windows.Forms.Button();
            this.TombolDelete = new System.Windows.Forms.Button();
            this.TombolSimpan = new System.Windows.Forms.Button();
            this.HargaMenu = new System.Windows.Forms.NumericUpDown();
            this.NamaMenu = new System.Windows.Forms.TextBox();
            this.TombolMasukkan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoMeja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalPenjualan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PenjualanBox = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.DateTimePicker();
            this.MejaBox = new System.Windows.Forms.DataGridView();
            this.Meja8 = new System.Windows.Forms.Label();
            this.Meja7 = new System.Windows.Forms.Label();
            this.Meja6 = new System.Windows.Forms.Label();
            this.Meja5 = new System.Windows.Forms.Label();
            this.Meja4 = new System.Windows.Forms.Label();
            this.Meja3 = new System.Windows.Forms.Label();
            this.Meja2 = new System.Windows.Forms.Label();
            this.Meja1 = new System.Windows.Forms.Label();
            this.Meja9 = new System.Windows.Forms.Label();
            this.Meja10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HargaMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenjualanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MejaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TombolCetak
            // 
            this.TombolCetak.BackColor = System.Drawing.Color.DarkOrange;
            this.TombolCetak.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolCetak.Location = new System.Drawing.Point(731, 39);
            this.TombolCetak.Name = "TombolCetak";
            this.TombolCetak.Size = new System.Drawing.Size(84, 29);
            this.TombolCetak.TabIndex = 115;
            this.TombolCetak.Text = "Cetak";
            this.TombolCetak.UseVisualStyleBackColor = false;
            this.TombolCetak.Click += new System.EventHandler(this.TombolCetak_Click);
            // 
            // TombolDelete
            // 
            this.TombolDelete.BackColor = System.Drawing.Color.Red;
            this.TombolDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolDelete.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolDelete.ForeColor = System.Drawing.Color.White;
            this.TombolDelete.Location = new System.Drawing.Point(335, 285);
            this.TombolDelete.Name = "TombolDelete";
            this.TombolDelete.Size = new System.Drawing.Size(120, 23);
            this.TombolDelete.TabIndex = 114;
            this.TombolDelete.Text = "Delete";
            this.TombolDelete.UseVisualStyleBackColor = false;
            this.TombolDelete.Click += new System.EventHandler(this.TombolDelete_Click);
            // 
            // TombolSimpan
            // 
            this.TombolSimpan.BackColor = System.Drawing.Color.Chartreuse;
            this.TombolSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TombolSimpan.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolSimpan.Location = new System.Drawing.Point(335, 256);
            this.TombolSimpan.Name = "TombolSimpan";
            this.TombolSimpan.Size = new System.Drawing.Size(120, 23);
            this.TombolSimpan.TabIndex = 113;
            this.TombolSimpan.Text = "Simpan";
            this.TombolSimpan.UseVisualStyleBackColor = false;
            this.TombolSimpan.Click += new System.EventHandler(this.TombolSimpan_Click);
            // 
            // HargaMenu
            // 
            this.HargaMenu.Location = new System.Drawing.Point(402, 74);
            this.HargaMenu.Name = "HargaMenu";
            this.HargaMenu.Size = new System.Drawing.Size(100, 20);
            this.HargaMenu.TabIndex = 112;
            // 
            // NamaMenu
            // 
            this.NamaMenu.Location = new System.Drawing.Point(402, 44);
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.Size = new System.Drawing.Size(100, 20);
            this.NamaMenu.TabIndex = 111;
            this.NamaMenu.Leave += new System.EventHandler(this.NamaMenu_Leave);
            // 
            // TombolMasukkan
            // 
            this.TombolMasukkan.BackColor = System.Drawing.SystemColors.Info;
            this.TombolMasukkan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolMasukkan.Location = new System.Drawing.Point(402, 101);
            this.TombolMasukkan.Name = "TombolMasukkan";
            this.TombolMasukkan.Size = new System.Drawing.Size(100, 23);
            this.TombolMasukkan.TabIndex = 110;
            this.TombolMasukkan.Text = "Masukkan";
            this.TombolMasukkan.UseVisualStyleBackColor = false;
            this.TombolMasukkan.Click += new System.EventHandler(this.TombolMasukkan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(335, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 24);
            this.label7.TabIndex = 108;
            this.label7.Tag = "";
            this.label7.Text = "Tambah/Edit Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Geometr415 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "Gambar Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Geometr415 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Harga Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr415 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Nama Menu";
            // 
            // lblNoMeja
            // 
            this.lblNoMeja.AutoSize = true;
            this.lblNoMeja.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMeja.Location = new System.Drawing.Point(609, 35);
            this.lblNoMeja.Name = "lblNoMeja";
            this.lblNoMeja.Size = new System.Drawing.Size(0, 23);
            this.lblNoMeja.TabIndex = 104;
            this.lblNoMeja.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 103;
            this.label4.Tag = "";
            this.label4.Text = "Bill Meja";
            // 
            // TotalPenjualan
            // 
            this.TotalPenjualan.AutoSize = true;
            this.TotalPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.TotalPenjualan.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPenjualan.Location = new System.Drawing.Point(131, 311);
            this.TotalPenjualan.Name = "TotalPenjualan";
            this.TotalPenjualan.Size = new System.Drawing.Size(51, 16);
            this.TotalPenjualan.TabIndex = 102;
            this.TotalPenjualan.Text = "label3";
            this.TotalPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 101;
            this.label2.Tag = "";
            this.label2.Text = "Total Penjualan :";
            // 
            // PenjualanBox
            // 
            this.PenjualanBox.BackgroundColor = System.Drawing.Color.Beige;
            this.PenjualanBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PenjualanBox.Location = new System.Drawing.Point(12, 67);
            this.PenjualanBox.Name = "PenjualanBox";
            this.PenjualanBox.Size = new System.Drawing.Size(256, 241);
            this.PenjualanBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 99;
            this.label1.Tag = "";
            this.label1.Text = "Rincian Penjualan";
            // 
            // Tanggal
            // 
            this.Tanggal.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanggal.Location = new System.Drawing.Point(12, 42);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(193, 22);
            this.Tanggal.TabIndex = 98;
            this.Tanggal.ValueChanged += new System.EventHandler(this.Tanggal_ValueChanged);
            // 
            // MejaBox
            // 
            this.MejaBox.BackgroundColor = System.Drawing.Color.Beige;
            this.MejaBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MejaBox.Location = new System.Drawing.Point(522, 70);
            this.MejaBox.Name = "MejaBox";
            this.MejaBox.Size = new System.Drawing.Size(209, 200);
            this.MejaBox.TabIndex = 97;
            // 
            // Meja8
            // 
            this.Meja8.BackColor = System.Drawing.Color.Lime;
            this.Meja8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja8.ForeColor = System.Drawing.Color.Black;
            this.Meja8.Location = new System.Drawing.Point(771, 150);
            this.Meja8.Name = "Meja8";
            this.Meja8.Size = new System.Drawing.Size(44, 40);
            this.Meja8.TabIndex = 96;
            this.Meja8.Text = "8";
            this.Meja8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja8.Click += new System.EventHandler(this.Meja8_Click);
            // 
            // Meja7
            // 
            this.Meja7.BackColor = System.Drawing.Color.Lime;
            this.Meja7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja7.ForeColor = System.Drawing.Color.Black;
            this.Meja7.Location = new System.Drawing.Point(771, 110);
            this.Meja7.Name = "Meja7";
            this.Meja7.Size = new System.Drawing.Size(44, 40);
            this.Meja7.TabIndex = 95;
            this.Meja7.Text = "7";
            this.Meja7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja7.Click += new System.EventHandler(this.Meja7_Click);
            // 
            // Meja6
            // 
            this.Meja6.BackColor = System.Drawing.Color.Lime;
            this.Meja6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja6.ForeColor = System.Drawing.Color.Black;
            this.Meja6.Location = new System.Drawing.Point(771, 70);
            this.Meja6.Name = "Meja6";
            this.Meja6.Size = new System.Drawing.Size(44, 40);
            this.Meja6.TabIndex = 94;
            this.Meja6.Text = "6";
            this.Meja6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja6.Click += new System.EventHandler(this.Meja6_Click);
            // 
            // Meja5
            // 
            this.Meja5.BackColor = System.Drawing.Color.Lime;
            this.Meja5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja5.ForeColor = System.Drawing.Color.Black;
            this.Meja5.Location = new System.Drawing.Point(731, 230);
            this.Meja5.Name = "Meja5";
            this.Meja5.Size = new System.Drawing.Size(44, 40);
            this.Meja5.TabIndex = 93;
            this.Meja5.Text = "5";
            this.Meja5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja5.Click += new System.EventHandler(this.Meja5_Click);
            // 
            // Meja4
            // 
            this.Meja4.BackColor = System.Drawing.Color.Lime;
            this.Meja4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja4.ForeColor = System.Drawing.Color.Black;
            this.Meja4.Location = new System.Drawing.Point(731, 190);
            this.Meja4.Name = "Meja4";
            this.Meja4.Size = new System.Drawing.Size(44, 40);
            this.Meja4.TabIndex = 92;
            this.Meja4.Text = "4";
            this.Meja4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja4.Click += new System.EventHandler(this.Meja4_Click);
            // 
            // Meja3
            // 
            this.Meja3.BackColor = System.Drawing.Color.Lime;
            this.Meja3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja3.ForeColor = System.Drawing.Color.Black;
            this.Meja3.Location = new System.Drawing.Point(731, 150);
            this.Meja3.Name = "Meja3";
            this.Meja3.Size = new System.Drawing.Size(44, 40);
            this.Meja3.TabIndex = 91;
            this.Meja3.Text = "3";
            this.Meja3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja3.Click += new System.EventHandler(this.Meja3_Click);
            // 
            // Meja2
            // 
            this.Meja2.BackColor = System.Drawing.Color.Lime;
            this.Meja2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja2.ForeColor = System.Drawing.Color.Black;
            this.Meja2.Location = new System.Drawing.Point(731, 110);
            this.Meja2.Name = "Meja2";
            this.Meja2.Size = new System.Drawing.Size(44, 40);
            this.Meja2.TabIndex = 90;
            this.Meja2.Text = "2";
            this.Meja2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja2.Click += new System.EventHandler(this.Meja2_Click);
            // 
            // Meja1
            // 
            this.Meja1.BackColor = System.Drawing.Color.Lime;
            this.Meja1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja1.ForeColor = System.Drawing.Color.Black;
            this.Meja1.Location = new System.Drawing.Point(731, 70);
            this.Meja1.Name = "Meja1";
            this.Meja1.Size = new System.Drawing.Size(44, 40);
            this.Meja1.TabIndex = 89;
            this.Meja1.Text = "1";
            this.Meja1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja1.Click += new System.EventHandler(this.Meja1_Click);
            // 
            // Meja9
            // 
            this.Meja9.BackColor = System.Drawing.Color.Lime;
            this.Meja9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja9.ForeColor = System.Drawing.Color.Black;
            this.Meja9.Location = new System.Drawing.Point(771, 190);
            this.Meja9.Name = "Meja9";
            this.Meja9.Size = new System.Drawing.Size(44, 40);
            this.Meja9.TabIndex = 117;
            this.Meja9.Text = "9";
            this.Meja9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja9.Click += new System.EventHandler(this.Meja9_Click);
            // 
            // Meja10
            // 
            this.Meja10.BackColor = System.Drawing.Color.Lime;
            this.Meja10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Meja10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meja10.ForeColor = System.Drawing.Color.Black;
            this.Meja10.Location = new System.Drawing.Point(771, 230);
            this.Meja10.Name = "Meja10";
            this.Meja10.Size = new System.Drawing.Size(44, 40);
            this.Meja10.TabIndex = 118;
            this.Meja10.Text = "10";
            this.Meja10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Meja10.Click += new System.EventHandler(this.Meja10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(827, 339);
            this.Controls.Add(this.Meja10);
            this.Controls.Add(this.Meja9);
            this.Controls.Add(this.TombolCetak);
            this.Controls.Add(this.TombolDelete);
            this.Controls.Add(this.TombolSimpan);
            this.Controls.Add(this.HargaMenu);
            this.Controls.Add(this.NamaMenu);
            this.Controls.Add(this.TombolMasukkan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoMeja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalPenjualan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PenjualanBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tanggal);
            this.Controls.Add(this.MejaBox);
            this.Controls.Add(this.Meja8);
            this.Controls.Add(this.Meja7);
            this.Controls.Add(this.Meja6);
            this.Controls.Add(this.Meja5);
            this.Controls.Add(this.Meja4);
            this.Controls.Add(this.Meja3);
            this.Controls.Add(this.Meja2);
            this.Controls.Add(this.Meja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HargaMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenjualanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MejaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button TombolCetak;
        private System.Windows.Forms.Button TombolDelete;
        private System.Windows.Forms.Button TombolSimpan;
        private System.Windows.Forms.NumericUpDown HargaMenu;
        private System.Windows.Forms.TextBox NamaMenu;
        private System.Windows.Forms.Button TombolMasukkan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoMeja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalPenjualan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PenjualanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Tanggal;
        private System.Windows.Forms.DataGridView MejaBox;
        private System.Windows.Forms.Label Meja8;
        private System.Windows.Forms.Label Meja7;
        private System.Windows.Forms.Label Meja6;
        private System.Windows.Forms.Label Meja5;
        private System.Windows.Forms.Label Meja4;
        private System.Windows.Forms.Label Meja3;
        private System.Windows.Forms.Label Meja2;
        private System.Windows.Forms.Label Meja1;
        private System.Windows.Forms.Label Meja9;
        private System.Windows.Forms.Label Meja10;
    }
}

