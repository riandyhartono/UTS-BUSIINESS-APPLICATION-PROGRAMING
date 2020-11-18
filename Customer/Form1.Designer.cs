namespace Customer
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
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuBox = new System.Windows.Forms.DataGridView();
            this.BestBox = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DaftarMeja = new System.Windows.Forms.ComboBox();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.TombolPesan = new System.Windows.Forms.Button();
            this.nudBanyaknya = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TombolBayar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PesananBox = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestBox)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanyaknya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesananBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Daftar Pesanan";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(545, 273);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(53, 18);
            this.Total.TabIndex = 53;
            this.Total.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Total Harga :";
            // 
            // MenuBox
            // 
            this.MenuBox.BackgroundColor = System.Drawing.Color.Ivory;
            this.MenuBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuBox.Location = new System.Drawing.Point(12, 35);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(242, 156);
            this.MenuBox.TabIndex = 43;
            this.MenuBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuBox_CellClick);
            // 
            // BestBox
            // 
            this.BestBox.BackgroundColor = System.Drawing.Color.Ivory;
            this.BestBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestBox.Location = new System.Drawing.Point(187, 238);
            this.BestBox.MultiSelect = false;
            this.BestBox.Name = "BestBox";
            this.BestBox.ReadOnly = true;
            this.BestBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BestBox.Size = new System.Drawing.Size(243, 135);
            this.BestBox.TabIndex = 51;
            this.BestBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BestBox_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 27);
            this.label5.TabIndex = 50;
            this.label5.Text = "Our Best Seller";
            // 
            // DaftarMeja
            // 
            this.DaftarMeja.FormattingEnabled = true;
            this.DaftarMeja.Location = new System.Drawing.Point(818, 10);
            this.DaftarMeja.Name = "DaftarMeja";
            this.DaftarMeja.Size = new System.Drawing.Size(52, 21);
            this.DaftarMeja.TabIndex = 49;
            this.DaftarMeja.SelectedIndexChanged += new System.EventHandler(this.DaftarMeja_SelectedIndexChanged);
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.TombolPesan);
            this.grpbxPesan.Controls.Add(this.nudBanyaknya);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(17, 197);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 176);
            this.grpbxPesan.TabIndex = 48;
            this.grpbxPesan.TabStop = false;
            // 
            // TombolPesan
            // 
            this.TombolPesan.BackColor = System.Drawing.Color.Orange;
            this.TombolPesan.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolPesan.Location = new System.Drawing.Point(24, 116);
            this.TombolPesan.Name = "TombolPesan";
            this.TombolPesan.Size = new System.Drawing.Size(100, 39);
            this.TombolPesan.TabIndex = 4;
            this.TombolPesan.Text = "Pesan";
            this.TombolPesan.UseVisualStyleBackColor = false;
            this.TombolPesan.Click += new System.EventHandler(this.TombolPesan_Click);
            // 
            // nudBanyaknya
            // 
            this.nudBanyaknya.Location = new System.Drawing.Point(24, 59);
            this.nudBanyaknya.Name = "nudBanyaknya";
            this.nudBanyaknya.Size = new System.Drawing.Size(100, 20);
            this.nudBanyaknya.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banyaknya";
            // 
            // TombolBayar
            // 
            this.TombolBayar.BackColor = System.Drawing.Color.Orange;
            this.TombolBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TombolBayar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolBayar.ForeColor = System.Drawing.Color.Black;
            this.TombolBayar.Location = new System.Drawing.Point(761, 273);
            this.TombolBayar.Name = "TombolBayar";
            this.TombolBayar.Size = new System.Drawing.Size(109, 28);
            this.TombolBayar.TabIndex = 46;
            this.TombolBayar.Text = "Bayar";
            this.TombolBayar.UseVisualStyleBackColor = false;
            this.TombolBayar.Click += new System.EventHandler(this.TombolBayar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nomor Meja";
            // 
            // PesananBox
            // 
            this.PesananBox.BackgroundColor = System.Drawing.Color.Ivory;
            this.PesananBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PesananBox.Location = new System.Drawing.Point(447, 67);
            this.PesananBox.MultiSelect = false;
            this.PesananBox.Name = "PesananBox";
            this.PesananBox.ReadOnly = true;
            this.PesananBox.Size = new System.Drawing.Size(423, 200);
            this.PesananBox.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(260, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(882, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MenuBox);
            this.Controls.Add(this.BestBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DaftarMeja);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.TombolBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PesananBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestBox)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanyaknya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesananBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MenuBox;
        private System.Windows.Forms.DataGridView BestBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DaftarMeja;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Button TombolPesan;
        private System.Windows.Forms.NumericUpDown nudBanyaknya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TombolBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PesananBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

