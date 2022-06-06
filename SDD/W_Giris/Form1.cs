using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class Form1 : Form
    {
        Tools tools = new Tools();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            tools.Giris(kullaniciAdi,sifre);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tools.Listele("Personel");
            dataGridView1.DataSource = tools.Listele("Kullanici");
            dataGridView1.Columns["Aktiflik"].Visible = false;
            dataGridView1.Columns["PasifTarih"].Visible = false;
        }
    }
}
