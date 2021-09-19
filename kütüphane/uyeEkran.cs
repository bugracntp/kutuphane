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
    public partial class uyeEkran : Form
    {
        girisekranı ge = new girisekranı();
        
        private OleDbCommand komut;
        private OleDbDataReader dr;
        string ad, yazarAd;
        int idlist;
        public string tabloAdAtama;

        public uyeEkran()
        {
            InitializeComponent();
        }

        private void uyeEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uyeEkran_Load(object sender, EventArgs e)
        {
            teslimBtn.Visible = false;
            emanetListesi.Visible = false;
            kitapListesi.Visible = true;
            tablolbl.Text = "Kitap Listesi";
            saat.Enabled = true;
            saat.Interval = 1000;
            saatlbl.Text = DateTime.Now.ToString();
            listeleme();
        }
        private void listeleme()
        {
            komut = new OleDbCommand();
            if (kitapListesi.Visible == true)
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

            }
            else if (emanetListesi.Visible == true)
            {
                ge.baglanti.Open();
                emanetListesi.Items.Clear();
                komut.CommandText = "SELECT * FROM "+tabloAdAtama;
                komut.Connection = ge.baglanti;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem liste = new ListViewItem(dr["id"].ToString());
                    liste.SubItems.Add(dr["ad"].ToString());
                    liste.SubItems.Add(dr["yazar"].ToString());
                    liste.SubItems.Add(dr["alimTarih"].ToString());
                    liste.SubItems.Add(dr["teslimTarih"].ToString());
                    emanetListesi.Items.Add(liste);
                }
            }
            dr.Close();
            ge.baglanti.Close();
        }
        private void emanetListesiBtn_Click(object sender, EventArgs e)
        {
            emanetListesi.Visible = true;
            kitapListesi.Visible = false;
            teslimBtn.Visible = true;
            tablolbl.Text = "Emanet Listesi";
            listeleme();
        }

        private void kitapAlBtn_Click(object sender, EventArgs e)
        {
            emanetListesi.Visible = false;
            kitapListesi.Visible = true;
            teslimBtn.Visible = false;
            tablolbl.Text = "Kitap Listesi";
            listeleme();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToString();
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            ge.baglanti.Open();
            try
            {
                string alimTarih = alimTrh.Text;
                string teslimTarih = teslimTrh.Text;
                idlist = Convert.ToInt32(kitapListesi.SelectedItems[0].Text);
                komut = new OleDbCommand("INSERT INTO "+tabloAdAtama+"(id,ad,yazar,alimTarih,teslimTarih) VALUES (@id,@ad,@yazar,@alimTarih,@teslimTarih)", ge.baglanti);
                komut.Parameters.AddWithValue("@id", idlist);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@yazar", yazarAd);
                komut.Parameters.AddWithValue("@alimTarih", alimTarih);
                komut.Parameters.AddWithValue("@teslimTarih", teslimTarih);
                MessageBox.Show("Kitabımız size emanettir.");
                komut.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "kütüphane programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ge.baglanti.Close();
        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            bool bulundu = false;
            aramaekran arama = new aramaekran();
            ge.baglanti.Open();
            kitapListesi.Items.Clear();
            komut = new OleDbCommand("SELECT * FROM kitapTablo", ge.baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ad"].ToString() == aramaTxt.Text)
                {
                    arama.AdLbl.Text = dr["ad"].ToString();
                    arama.yazarLbl.Text = dr["yazar"].ToString();
                    arama.sayfaSayisiLbl.Text = dr["sayfaS"].ToString();
                    arama.turLbl.Text = dr["tur"].ToString();
                    arama.kategoriLbl.Text = dr["kategori"].ToString();
                    bulundu = true;
                    arama.Show();
                    break;
                }
            }
            if (!bulundu)
                MessageBox.Show("Bulunamadı");
            dr.Close();
            ge.baglanti.Close();
            listeleme();
        }

        private void teslimBtn_Click(object sender, EventArgs e)
        {
            ge.baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = ge.baglanti;
            if (emanetListesi.SelectedItems.Count == 0)
                MessageBox.Show("En az bir öğe seçiniz");
            else
            {
                int id = Convert.ToInt32(emanetListesi.SelectedItems[0].Text);
                komut.CommandText = "DELETE FROM "+ tabloAdAtama + " WHERE id="+id;
                MessageBox.Show("Teslim edildi");
                komut.ExecuteNonQuery();
            }
            ge.baglanti.Close();
            listeleme();
        }

        private void kitapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in kitapListesi.SelectedItems)
            {
                idlist = Convert.ToInt32(kitapListesi.SelectedItems[0].SubItems[0].Text);
                ad = kitapListesi.SelectedItems[0].SubItems[1].Text;
                yazarAd = kitapListesi.SelectedItems[0].SubItems[2].Text;
            }
        }
        
    }
}
