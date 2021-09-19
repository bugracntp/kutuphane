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
    public partial class girisekranı : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = kutuphane.mdb");
        public string kullaniciAd;
        public girisekranı()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
            saat.Interval = 1000;
            saat.Enabled = true;
            SifreTxt.PasswordChar = '*';
        }
        private void girisBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            bool giris = false;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM kullaniciTablo", baglanti);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (calisanRad.Checked == true)
                {
                    if (reader["kullaniciAd"].ToString() == KAdTxt.Text && reader["sifre"].ToString() == SifreTxt.Text && reader["yetki"].ToString() == "Çalışan")
                    {
                        calisanekran ce = new calisanekran();
                        ce.calisanBtn.Enabled = false;
                        ce.yetkiLbl.Text = "Çalışan";
                        ce.dropTable = "emanet" + reader["ad"].ToString();
                        ce.adSoyadLbl.Text = reader["ad"].ToString() + " " + reader["soyad"].ToString();
                        this.Hide();
                        ce.Show();
                        giris = true;
                        break;
                    }

                }
                else if (uyeRad.Checked == true)
                {
                    if (reader["kullaniciAd"].ToString() == KAdTxt.Text && reader["sifre"].ToString() == SifreTxt.Text && reader["yetki"].ToString() == "Üye")
                    {
                        uyeEkran eu = new uyeEkran();
                        this.Hide();
                        eu.Show();
                        giris = true;
                        eu.tabloAdAtama = "emanet"+reader["ad"].ToString();
                        eu.adSoyadLbl.Text = reader["ad"].ToString() + " " + reader["soyad"].ToString();
                        break;
                    }
                }
                else if (yoneticiRad.Checked == true)
                {
                    if (reader["kullaniciAd"].ToString() == KAdTxt.Text && reader["sifre"].ToString() == SifreTxt.Text && reader["yetki"].ToString() == "Yönetici")
                    {
                        calisanekran ce = new calisanekran();
                        ce.yetkiLbl.Text = "Yönetici";
                        ce.adSoyadLbl.Text = reader["ad"].ToString() + " " + reader["soyad"].ToString();
                        this.Hide();
                        ce.Show();
                        giris = true;
                        break;
                    }
                }
                else
                {
                    giris = false;
                    break;
                }
            }
            if (!giris)
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            baglanti.Close();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MessageBox.Show(baglanti.State.ToString()) ;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gösterChckb.Checked)
            {
                //karakteri göster.
                SifreTxt.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                SifreTxt.PasswordChar = '*';
            }
        }

        private void üye_Click(object sender, EventArgs e)
        {
            uyeolma uo = new uyeolma();
            uo.Show();
        }
    }
}
