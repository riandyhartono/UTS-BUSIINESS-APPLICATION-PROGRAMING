using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer
{
    public partial class Form1 : Form
    {
        public string makanan;
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();
            for (int i=1;i<11;i++)
            {
                DaftarMeja.Items.Add(i);
                
            }
            nudBanyaknya.Minimum = 1;
            nudBanyaknya.Maximum = 99;
            PesananBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BestBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MenuBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select NamaMenu, Cast(HargaMenu as decimal) Harga from Menu", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            MenuBox.DataSource = ds.Tables["Menu"];
            da = new SqlDataAdapter("select Top 3 NamaMenu, HargaMenu from Menu order by Populer desc", conn);
            ds = new DataSet();
            da.Fill(ds, "Menu");
            BestBox.DataSource = ds.Tables["Menu"];
            Total.Text = "0";
            grpbxPesan.Enabled = false;
            MenuBox.Enabled = false;
            BestBox.Enabled = false;
            TombolBayar.Enabled = false;
            DaftarMeja.Enabled = true;
            MenuBox.ClearSelection();
            BestBox.ClearSelection();
            PesananBox.ClearSelection();
            PesananBox.DataSource = null;
            pictureBox1.Image = null;
        }
        private void DaftarMeja_SelectedIndexChanged(object sender, EventArgs e)
        {
            BestBox.Enabled = true;
            MenuBox.Enabled = true;
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{DaftarMeja.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            PesananBox.DataSource = ds.Tables["Menu"];
            if (PesananBox.Rows.Count > 0)
                TombolBayar.Enabled = true;
        }

        
        private void BestBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MenuBox.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = BestBox.Rows[e.RowIndex].Cells[0].Value.ToString();
            Gambar(makanan);
        }

        private void MenuBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BestBox.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = MenuBox.Rows[e.RowIndex].Cells[0].Value.ToString();
            Gambar(makanan);

        }

        private void TombolBayar_Click(object sender, EventArgs e)
        {
            if (PesananBox.RowCount > 1)
            {
                MessageBox.Show("Please Wait..");
                string sql = String.Format("Update Meja set flag = '1' where TableNum = '{0}'", DaftarMeja.SelectedItem);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Form1_Load(null, null);
            }
        }
        private void TombolPesan_Click(object sender, EventArgs e)
        {
            TombolBayar.Enabled = true;
            string sql = String.Format("insert into Meja values('{0}','0','{1}','{2}',{3})", DaftarMeja.SelectedItem, makanan, DateTimeOffset.Now.ToString("yyyy/MM/dd"), nudBanyaknya.Value);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{DaftarMeja.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pesanan");
            PesananBox.DataSource = ds.Tables["Pesanan"];
            sql = String.Format("Update Menu set Populer += {0} where NamaMenu = '{1}'", nudBanyaknya.Value, makanan);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            int total = 0;
            for (int i = 0; i < PesananBox.Rows.Count; i++)
                total += Convert.ToInt32(PesananBox.Rows[i].Cells[3].Value);
            Total.Text = total.ToString();
        }
        public void Gambar(string makanan)
        {
            string sql = String.Format("Select GambarMenu from Menu where NamaMenu = '{0}'", makanan);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                pictureBox1.Image = Image.FromFile(reader[0].ToString());
            reader.Close();
        }

    }
}
