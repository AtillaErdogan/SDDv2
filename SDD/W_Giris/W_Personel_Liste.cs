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
        Tools tools = new Tools();
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        private void W_Personel_Liste_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string arananPersonel = txtPersonel_Ad.Text;
            tools.FiltreListele(arananPersonel,"Personel");
            dataGridView1.DataSource = tools.FiltreListele(arananPersonel,"personel");
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
            if (dataGridView1.CurrentRow != null)
            {

                object referans = dataGridView1.CurrentRow.Cells["Id"].Value;
                tools.PersonelSil(referans,"Personel");
                dataGridView1.DataSource = tools.Listele("Personel");
                

                

            }
            
        }
    }
}
