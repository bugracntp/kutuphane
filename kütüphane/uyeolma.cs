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
    public partial class uyeolma : Form
    {
        OleDbCommand komut;
        girisekranı ge = new girisekranı();
        int id;
        public uyeolma()
        {
            InitializeComponent();
        }

        private void uyeolma_Load(object sender, EventArgs e)
        {
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
         private void sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 58) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
         private void yazi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            if (adTxt.Text != "" && soyadTxt.Text != "" && yasTxt.Text != "" && tcTxt.Text != "" && telefonTxt.Text != "" && kAdTxt.Text != "" && sifreTxt.Text != "")
            {
                if (sifreTxt.Text == tekrarSifreTxt.Text)
                {
                    try
                    {
                        ge.baglanti.Open();
                        DialogResult secenek = MessageBox.Show("Bilgilerinizi Onaylıyor musunuz?", "Onaylama", MessageBoxButtons.YesNo);
                        if (secenek == DialogResult.Yes)
                        {
                            komut = new OleDbCommand("INSERT INTO kullaniciTablo(ad,soyad,yas,tc,telefon,yetki,kullaniciAd,sifre) VALUES (@ad,@soyad,@yas,@tc,@telefon,@yetki,@kullaniciAd,@sifre)", ge.baglanti);
                            string yetkiTipi = "Üye";
                            komut.Parameters.AddWithValue("@ad", adTxt.Text.ToUpper());
                            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text.ToUpper());
                            komut.Parameters.AddWithValue("@yas", Convert.ToInt32(yasTxt.Text));
                            komut.Parameters.AddWithValue("@tc", tcTxt.Text);
                            komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
                            komut.Parameters.AddWithValue("@yetki", yetkiTipi);
                            komut.Parameters.AddWithValue("@kullaniciAd", kAdTxt.Text);
                            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
                            MessageBox.Show("Artık Kütüphanemize Üyesiniz.");
                            komut.ExecuteNonQuery();
                            ge.baglanti.Close();
                            tabloOlustur();
                        }
                        else if (secenek == DialogResult.No)
                        {
                            MessageBox.Show("Bilgilerinizi Gözden Geçiriniz.");
                        }

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Kayıt Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Hide();
                }
                else
                    MessageBox.Show("Şifreler Uyuşmuyor");
                
            }
            else
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz.");
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

        private void tabloOlustur()
        {
            string tabloAd = "emanet" + adTxt.Text.ToUpper();
            ge.baglanti.Open();
            try
            {
                komut = new OleDbCommand("CREATE TABLE "+tabloAd+"(id int,ad char(50),yazar char(50),alimTarih date,teslimTarih date);", ge.baglanti);
                komut.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Kayıt Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            ge.baglanti.Close();
        }
      

    }
}
