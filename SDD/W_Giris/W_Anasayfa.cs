﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public partial class W_Anasayfa : Form
    {
        public W_Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Personel_Kayıt personelKayıt = new W_Personel_Kayıt();
            personelKayıt.Show();
        }

        private void personelListeleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            W_Personel_Liste personelListe = new W_Personel_Liste();
            personelListe.Show();
        }
    }
}
