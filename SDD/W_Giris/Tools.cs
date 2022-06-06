using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace W_Giris
{
    public class Tools
    {
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public DataTable Listele(string TabloAdı) {

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from "+TabloAdı+" ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }

        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public DataTable FiltreListele(string arananNesne ,String TabloAdı)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from " + TabloAdı + " where Ad like '%" + arananNesne + "%' ", Baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
            
            
        }

        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void PersonelSil(object referans, String TabloAdı)
        {

            SqlCommand komut = new SqlCommand("delete from "+TabloAdı+" where Id =@personelId", Baglanti);
            komut.Parameters.AddWithValue("@personelId", referans);
            Baglanti.Open();
            int sayac = komut.ExecuteNonQuery();
            Baglanti.Close();
            if (sayac > 0)
            {
                
                MessageBox.Show("Kayıt Silinmiştir.");
                
            }
            else {
                MessageBox.Show("Silme işlemi yapılamadı.");
            }
            
        }

        //--------------------------------------------------------------
        //--------------------------------------------------------------

        public void PersonelEkle(String personelAd, String personelSoyad, byte personelCinsiyet, byte personelAktif)
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "INSERT INTO Personel (Ad,Soyad,Cinsiyet,Aktiflik) values(@personelAd,@personelSoyad,@personelCinsiyet,@personelAktif)";
            komut.Connection = Baglanti;
            komut.Parameters.AddWithValue("@personelAd", personelAd);
            komut.Parameters.AddWithValue("@personelSoyad", personelSoyad);
            komut.Parameters.AddWithValue("@personelCinsiyet", personelCinsiyet);
            komut.Parameters.AddWithValue("@personelAktif", personelAktif);
            Baglanti.Open();
            int eklenenDeger = komut.ExecuteNonQuery();
            if (eklenenDeger >= 1)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Hata!");

            }
            Baglanti.Close();

        }
        //public SqlConnection Baglanti()
        //{

        //    SqlConnection Baglanti = new SqlConnection("Server=localhost;Database=SDD;Trusted_Connection=True;");
        //    return Baglanti;
        //}

        //--------------------------------------------------------------
        //--------------------------------------------------------------
        public void Giris(string kullaniciAdi, string sifre) {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * from Kullanici where KullaniciAd='" + kullaniciAdi+ "' AND KullaniciSifre='" + sifre+"'";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("Giriş Başarılı ");
                W_Anasayfa anasayfa = new W_Anasayfa();
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
            Baglanti.Close();

        }

    }
}
