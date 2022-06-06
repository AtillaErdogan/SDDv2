using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace W_Giris
{
    public partial class W_Personel_Liste : Form
    {
        public W_Personel_Liste()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        private void W_Personel_Liste_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananPersonel = txtPersonel_Ad.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Personel where Ad like '%"+arananPersonel+"%' ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Aktiflik"].Visible = false;
            dataGridView1.Columns["PasifTarih"].Visible = false;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            W_Detay detay = new W_Detay();
            detay.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                SqlCommand komut = new SqlCommand("delete from Personel where Id =@personelId",Baglanti);
                komut.Parameters.AddWithValue("@personelId", dataGridView1.CurrentRow.Cells["Id"].Value);
                Baglanti.Open();
                int sayac = komut.ExecuteNonQuery();
                Baglanti.Close();
                if (sayac>0)
                {
                    MessageBox.Show("Kayıt Silinmiştir.");
                }

            }
        }
    }
}
