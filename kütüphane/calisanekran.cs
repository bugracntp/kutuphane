using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane
{
    public partial class calisanekran : Form
    {
        string[] tur = {"Roman","Ansiklopedi","Şiir","Çocuk","Psikoloji"};
        OleDbCommand komut;
        OleDbDataReader dr;
        public string dropTable;
        bool kitapKotrol = true;
        girisekranı ge = new girisekranı();

            
        public calisanekran()
        {
            InitializeComponent();
        }

        private void calisanekran_Load(object sender, EventArgs e)
        {
            kitapTCmb.Items.AddRange(tur);
            Tarih.Text = DateTime.Now.ToString();
            saat.Enabled = true;
            saat.Interval = 1000;
            listeleme();
            {
                tcTxt.MaxLength = 11;
                telefonTxt.MaxLength = 10;
                yasTxt.MaxLength = 2;
                tcTxt.Mask = "00000000000";
                yasTxt.Mask = "00";
                telefonTxt.MaxLength = 10;
                telefonTxt.Mask = "0000000000";
                kAdTxt.MaxLength = 12;
                toolTip1.SetToolTip(this.tcTxt, "T.C numaranız 11 karakter olmalıdır.");
                toolTip1.SetToolTip(this.telefonTxt, "5xx xxx xxxx şeklinde giriniz.");
                adTxt.Mask = "LL?????????";
                soyadTxt.Mask = "LL????????????";
            }
            sifreTxt.PasswordChar = '*';
            tekrarSifreTxt.PasswordChar = '*';
        }

        private void uyeBtn_Click(object sender, EventArgs e)
        {
            yetkiCmb.Items.Clear();
            tabControl1.SelectedTab=tabPage2;
            tabControl2.SelectedTab=tabPage4;
            listeleme();
            yetkiCmb.Items.Add("Üye");
            yetkiCmb.Items.Add("Çalışan");
            yetkiCmb.Items.Add("Yönetici");
        }

        private void kitapIslemleriBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            tabControl2.SelectedTab = tabPage3;
            listeleme();
            kitapTCmb.Items.AddRange(tur);
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            Tarih.Text = DateTime.Now.ToString();
        }

        private void kitapTCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kitapTCmb.Text == "Roman")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Aşk");
                katagoriCmb.Items.Add("Aksiyon");
                katagoriCmb.Items.Add("Bilimkurgu");
                katagoriCmb.Items.Add("Gizem");
                katagoriCmb.Items.Add("Korku");
                katagoriCmb.Items.Add("Polisiye");
                katagoriCmb.Items.Add("Tarihi");
            }
            else if (kitapTCmb.Text == "Çocuk")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Masal");
                katagoriCmb.Items.Add("Hikaye");
                katagoriCmb.Items.Add("Eğitim");
            }
            else if (kitapTCmb.Text == "Psikoloji")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Kişisel Gelişim");
                katagoriCmb.Items.Add("Toplum Piskolojisi");
                katagoriCmb.Items.Add("Yaklaşımlar");
                katagoriCmb.Items.Add("Çocuk Piskolojisi");
                katagoriCmb.Items.Add("Eğitim Piskolojisi");
                katagoriCmb.Items.Add("Aile Piskolojisi");
            }
            else if (kitapTCmb.Text == "Şiir")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Aşk");
                katagoriCmb.Items.Add("Derlemeler");
                katagoriCmb.Items.Add("Tarihi");
                katagoriCmb.Items.Add("Çocuk");
            }
            else if (kitapTCmb.Text == "Psikoloji")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Kişisel Gelişim");
                katagoriCmb.Items.Add("Toplum Piskolojisi");
                katagoriCmb.Items.Add("Yaklaşımlar");
                katagoriCmb.Items.Add("Çocuk Piskolojisi");
                katagoriCmb.Items.Add("Eğitim Piskolojisi");
                katagoriCmb.Items.Add("Aile Piskolojisi");
            }
            else if (kitapTCmb.Text == "Ansiklopedi")
            {
                katagoriCmb.Items.Clear();
                katagoriCmb.Items.Add("Bilim Ansiklopedisi");
                katagoriCmb.Items.Add("Tarih Ansiklopedisi");
                katagoriCmb.Items.Add("Doğa Ansiklopedisi");
                katagoriCmb.Items.Add("Edebiyat Ansiklopedisi");
                katagoriCmb.Items.Add("Biyoloji Ansiklopedisi");
                katagoriCmb.Items.Add("Kimya Ansiklopedisi");
                katagoriCmb.Items.Add("Fizik Ansiklopedisi");
                katagoriCmb.Items.Add("Coğrafya Ansiklopedisi");
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (adTxt.Text != "" && soyadTxt.Text != "" && yasTxt.Text != "" && tcTxt.Text != "" && telefonTxt.Text != "" && kAdTxt.Text != "" && sifreTxt.Text != "")
            {
                Kontrol();
                if (kitapKotrol)
                {
                    ge.baglanti.Open();
                    try
                    {
                        string ad = kitapAdTxt.Text, yazar = yazarTxt.Text, sayfaSayisi = sayfaSayisiTxt.Text, tur = kitapTCmb.Text, kategori = katagoriCmb.Text;
                        komut = new OleDbCommand("INSERT INTO  kitapTablo(ad,yazar,tur,kategori,sayfaS) VALUES (@ad,@yazar,@tur,@kategori,@sayfaS)", ge.baglanti);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@yazar", yazar);
                        komut.Parameters.AddWithValue("@tur", tur);
                        komut.Parameters.AddWithValue("@kategori", kategori);
                        komut.Parameters.AddWithValue("@sayfaS", sayfaSayisi);
                        MessageBox.Show("Kitap Kütüphaneye Eklenmiştir.");
                        komut.ExecuteNonQuery();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "kütüphane programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ge.baglanti.Close();
                    listeleme();
                }
            }
            else
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz");

                
        }

        private void kEkleBtn_Click(object sender, EventArgs e)
        {
            if (adTxt.Text != "" && soyadTxt.Text != "" && yasTxt.Text != "" && tcTxt.Text != "" && telefonTxt.Text != "" && kAdTxt.Text != "" && sifreTxt.Text != "")
            {
                if (sifreTxt.Text == tekrarSifreTxt.Text)
                {
                    ge.baglanti.Open();
                    try
                    {
                        string ad = adTxt.Text, soyad = soyadTxt.Text, yas = yasTxt.Text, tc = tcTxt.Text, telefon = telefonTxt.Text, yetki = yetkiCmb.Text, kullaniciAd = kAdTxt.Text, sifre = sifreTxt.Text;
                        komut = new OleDbCommand("INSERT INTO  kullaniciTablo(ad,soyad,yas,tc,telefon,yetki,kullaniciAd,sifre) VALUES (@ad,@soyad,@yas,@tc,@telefon,@yetki,@kullaniciAd,@sifre)", ge.baglanti);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@soyad", soyad);
                        komut.Parameters.AddWithValue("@yas", yas);
                        komut.Parameters.AddWithValue("@tc", tc);
                        komut.Parameters.AddWithValue("@telefon", telefon);
                        komut.Parameters.AddWithValue("@yetki", yetki);
                        komut.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        MessageBox.Show("Kullanıcı Eklenmiştir.");
                        komut.ExecuteNonQuery();
                        ge.baglanti.Close();
                        tabloOlustur();


                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "kütüphane programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    listeleme();
                }
                else
                    MessageBox.Show("Şifreler Uyuşmuyor");

            }
            else
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            ge.baglanti.Open();
            try
            {
                int id = Convert.ToInt32(kullaniciTablo.SelectedItems[0].SubItems[0].Text);
                string ad = adTxt.Text, soyad = soyadTxt.Text, yas = yasTxt.Text, tc = tcTxt.Text, telefon = telefonTxt.Text, yetki = yetkiCmb.Text, kullaniciAd = kAdTxt.Text, sifre = sifreTxt.Text;
                komut.CommandText = "UPDATE urunTablo SET ad = @ad, soyad = @soyad, yas = @yas, tc = @tc, telefon = @telefon, yetki = @yetki, kullaniciAd = @kullaniciAd, sifre = @sifre WHERE id = " + id;
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@yas", yas);
                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@yetki", yetki);
                komut.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                komut.Parameters.AddWithValue("@sifre", sifre);
                MessageBox.Show("Kitap Kütüphaneye Eklenmiştir.");
                komut.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "kütüphane programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ge.baglanti.Close();
            listeleme();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            ge.baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = ge.baglanti;
            if (kitapListesi.SelectedItems.Count == 0)
                MessageBox.Show("En az bir öğe seçiniz");
            else
            {
                int id = Convert.ToInt32(kitapListesi.SelectedItems[0].Text);
                komut.CommandText = "DELETE FROM kitapTablo WHERE id=" + id;
                MessageBox.Show("Kitap Silindi. İşlem Başarılı!");
                komut.ExecuteNonQuery();
            }
            ge.baglanti.Close();
            listeleme();
        }

        private void usilBtn_Click(object sender, EventArgs e)
        {
            
            if (kullaniciTablo.SelectedItems.Count == 0)
                MessageBox.Show("En az bir öğe seçiniz");
            else
            {
                ge.baglanti.Open();
                komut = new OleDbCommand();
                komut.Connection = ge.baglanti;
                int id = Convert.ToInt32(kullaniciTablo.SelectedItems[0].Text);
                komut.CommandText = "DELETE FROM kullaniciTablo WHERE id=" + id;
                MessageBox.Show("Kullanıcı Silindi. İşlem Başarılı!");
                komut.ExecuteNonQuery();
                ge.baglanti.Close();
            }
            listeleme();
        }
       
        private void listeleme()
        {
            komut = new OleDbCommand();
            if (tabControl2.SelectedTab == tabPage3)
            {
                ge.baglanti.Open();
                kitapListesi.Items.Clear();
                komut.CommandText = "SELECT * FROM kitapTablo";
                komut.Connection = ge.baglanti;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem liste = new ListViewItem(dr["id"].ToString());
                    liste.SubItems.Add(dr["ad"].ToString());
                    liste.SubItems.Add(dr["yazar"].ToString());
                    liste.SubItems.Add(dr["sayfaS"].ToString());
                    liste.SubItems.Add(dr["tur"].ToString());
                    liste.SubItems.Add(dr["kategori"].ToString());
                    kitapListesi.Items.Add(liste);
                }
                ge.baglanti.Close();
                dr.Close();

            }
            else if (tabControl2.SelectedTab == tabPage4)
            {
                ge.baglanti.Open();
                kullaniciTablo.Items.Clear();
                komut.CommandText = "SELECT * FROM kullaniciTablo";
                komut.Connection = ge.baglanti;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem liste = new ListViewItem(dr["id"].ToString());
                    liste.SubItems.Add(dr["ad"].ToString());
                    liste.SubItems.Add(dr["soyad"].ToString());
                    liste.SubItems.Add(dr["yas"].ToString());
                    liste.SubItems.Add(dr["tc"].ToString());
                    liste.SubItems.Add(dr["telefon"].ToString());
                    liste.SubItems.Add(dr["yetki"].ToString());
                    liste.SubItems.Add(dr["kullaniciAd"].ToString());
                    kullaniciTablo.Items.Add(liste);
                }
                ge.baglanti.Close();
                dr.Close();
            }
        }

        private void kitapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in kitapListesi.SelectedItems)
            {
                int idlist = Convert.ToInt32(kitapListesi.SelectedItems[0].SubItems[0].Text);
                string ad = kitapListesi.SelectedItems[0].SubItems[1].Text;
                string yazarAd = kitapListesi.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void kullaniciTablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in kullaniciTablo.SelectedItems)
            {
                int idlist = Convert.ToInt32(kullaniciTablo.SelectedItems[0].SubItems[0].Text);
                string ad = kullaniciTablo.SelectedItems[0].SubItems[1].Text;
                string soyad = kullaniciTablo.SelectedItems[0].SubItems[2].Text;
            }
        }
        private void Kontrol()
        {
            ge.baglanti.Open();
            komut = new OleDbCommand("SELECT id,ad FROM kitapTablo", ge.baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ad"].ToString() == kitapAdTxt.Text)
                {
                    MessageBox.Show("Bu Kitap Daha Önce Eklenmiş");
                    kitapKotrol = false;
                    break;
                }
                else
                    kitapKotrol = true;
            }
            ge.baglanti.Close();
        }

        private void calisanekran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void tabloOlustur()
        {
            string tabloAd = "emanet" + adTxt.Text.ToUpper();
            ge.baglanti.Open();
            try
            {
                komut = new OleDbCommand("CREATE TABLE " + tabloAd + "(id int,ad char(50),yazar char(50),alimTarih date,teslimTarih date);", ge.baglanti);
                komut.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Kayıt Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ge.baglanti.Close();
        }
        private void gizleCmb_CheckedChanged(object sender, EventArgs e)
        {
            if (gizleCmb.Checked)
            {
                //karakteri göster.
                sifreTxt.PasswordChar = '*';
                tekrarSifreTxt.PasswordChar = '*';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifreTxt.PasswordChar = '\0';
                tekrarSifreTxt.PasswordChar = '\0';
            }
        }

    }
}
