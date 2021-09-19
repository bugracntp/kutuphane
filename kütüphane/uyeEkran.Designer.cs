
namespace kütüphane
{
    partial class uyeEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeEkran));
            this.saatlbl = new System.Windows.Forms.Label();
            this.tablolbl = new System.Windows.Forms.Label();
            this.emanetPanel = new System.Windows.Forms.Panel();
            this.teslimBtn = new System.Windows.Forms.Button();
            this.alimTrh = new System.Windows.Forms.DateTimePicker();
            this.teslimTrh = new System.Windows.Forms.DateTimePicker();
            this.onaylaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aramaTxt = new System.Windows.Forms.TextBox();
            this.kitapAlBtn = new System.Windows.Forms.Button();
            this.emanetListesiBtn = new System.Windows.Forms.Button();
            this.kitapListesi = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sayfaSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitapTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emanetListesi = new System.Windows.Forms.ListView();
            this.ide = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kAde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yazare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.emanetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saatlbl
            // 
            this.saatlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saatlbl.AutoSize = true;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.Location = new System.Drawing.Point(810, 627);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(46, 17);
            this.saatlbl.TabIndex = 20;
            this.saatlbl.Text = "Tarih";
            // 
            // tablolbl
            // 
            this.tablolbl.AutoSize = true;
            this.tablolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablolbl.Location = new System.Drawing.Point(13, 179);
            this.tablolbl.Name = "tablolbl";
            this.tablolbl.Size = new System.Drawing.Size(97, 17);
            this.tablolbl.TabIndex = 19;
            this.tablolbl.Text = "Kitap Listesi";
            // 
            // emanetPanel
            // 
            this.emanetPanel.Controls.Add(this.teslimBtn);
            this.emanetPanel.Controls.Add(this.alimTrh);
            this.emanetPanel.Controls.Add(this.teslimTrh);
            this.emanetPanel.Controls.Add(this.onaylaBtn);
            this.emanetPanel.Controls.Add(this.label2);
            this.emanetPanel.Controls.Add(this.label1);
            this.emanetPanel.Location = new System.Drawing.Point(209, 50);
            this.emanetPanel.Name = "emanetPanel";
            this.emanetPanel.Size = new System.Drawing.Size(512, 115);
            this.emanetPanel.TabIndex = 18;
            // 
            // teslimBtn
            // 
            this.teslimBtn.BackColor = System.Drawing.Color.LightBlue;
            this.teslimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimBtn.Location = new System.Drawing.Point(394, 55);
            this.teslimBtn.Name = "teslimBtn";
            this.teslimBtn.Size = new System.Drawing.Size(92, 30);
            this.teslimBtn.TabIndex = 7;
            this.teslimBtn.Text = "Teslim Et";
            this.teslimBtn.UseVisualStyleBackColor = false;
            this.teslimBtn.Click += new System.EventHandler(this.teslimBtn_Click);
            // 
            // alimTrh
            // 
            this.alimTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alimTrh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.alimTrh.Location = new System.Drawing.Point(176, 18);
            this.alimTrh.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.alimTrh.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.alimTrh.Name = "alimTrh";
            this.alimTrh.Size = new System.Drawing.Size(200, 27);
            this.alimTrh.TabIndex = 6;
            // 
            // teslimTrh
            // 
            this.teslimTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimTrh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.teslimTrh.Location = new System.Drawing.Point(176, 53);
            this.teslimTrh.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.teslimTrh.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.teslimTrh.Name = "teslimTrh";
            this.teslimTrh.Size = new System.Drawing.Size(200, 27);
            this.teslimTrh.TabIndex = 5;
            // 
            // onaylaBtn
            // 
            this.onaylaBtn.BackColor = System.Drawing.Color.LightBlue;
            this.onaylaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaBtn.Location = new System.Drawing.Point(394, 19);
            this.onaylaBtn.Name = "onaylaBtn";
            this.onaylaBtn.Size = new System.Drawing.Size(92, 30);
            this.onaylaBtn.TabIndex = 4;
            this.onaylaBtn.Text = "Emanet Al";
            this.onaylaBtn.UseVisualStyleBackColor = false;
            this.onaylaBtn.Click += new System.EventHandler(this.onaylaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son Teslim Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teslim Alım Tarihi : ";
            // 
            // aramaTxt
            // 
            this.aramaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaTxt.Location = new System.Drawing.Point(754, 50);
            this.aramaTxt.Multiline = true;
            this.aramaTxt.Name = "aramaTxt";
            this.aramaTxt.Size = new System.Drawing.Size(234, 37);
            this.aramaTxt.TabIndex = 16;
            // 
            // kitapAlBtn
            // 
            this.kitapAlBtn.BackColor = System.Drawing.Color.LightBlue;
            this.kitapAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAlBtn.Location = new System.Drawing.Point(16, 111);
            this.kitapAlBtn.Name = "kitapAlBtn";
            this.kitapAlBtn.Size = new System.Drawing.Size(116, 54);
            this.kitapAlBtn.TabIndex = 13;
            this.kitapAlBtn.Text = "Kitap Al";
            this.kitapAlBtn.UseVisualStyleBackColor = false;
            this.kitapAlBtn.Click += new System.EventHandler(this.kitapAlBtn_Click);
            // 
            // emanetListesiBtn
            // 
            this.emanetListesiBtn.BackColor = System.Drawing.Color.LightBlue;
            this.emanetListesiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetListesiBtn.Location = new System.Drawing.Point(16, 40);
            this.emanetListesiBtn.Name = "emanetListesiBtn";
            this.emanetListesiBtn.Size = new System.Drawing.Size(116, 54);
            this.emanetListesiBtn.TabIndex = 12;
            this.emanetListesiBtn.Text = "Emanet Listesi";
            this.emanetListesiBtn.UseVisualStyleBackColor = false;
            this.emanetListesiBtn.Click += new System.EventHandler(this.emanetListesiBtn_Click);
            // 
            // kitapListesi
            // 
            this.kitapListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kitapListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.kAd,
            this.yazar,
            this.sayfaSayisi,
            this.kitapTürü,
            this.kategori});
            this.kitapListesi.FullRowSelect = true;
            this.kitapListesi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.kitapListesi.HideSelection = false;
            this.kitapListesi.Location = new System.Drawing.Point(16, 209);
            this.kitapListesi.Name = "kitapListesi";
            this.kitapListesi.Size = new System.Drawing.Size(1015, 415);
            this.kitapListesi.TabIndex = 14;
            this.kitapListesi.UseCompatibleStateImageBehavior = false;
            this.kitapListesi.View = System.Windows.Forms.View.Details;
            this.kitapListesi.SelectedIndexChanged += new System.EventHandler(this.kitapListesi_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // kAd
            // 
            this.kAd.Text = "Kitap Adı";
            this.kAd.Width = 250;
            // 
            // yazar
            // 
            this.yazar.Text = "Yazar";
            this.yazar.Width = 250;
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.Text = "Sayfa Sayısı";
            this.sayfaSayisi.Width = 162;
            // 
            // kitapTürü
            // 
            this.kitapTürü.Text = "Kitap Türü";
            this.kitapTürü.Width = 200;
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori";
            this.kategori.Width = 136;
            // 
            // emanetListesi
            // 
            this.emanetListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emanetListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ide,
            this.kAde,
            this.yazare,
            this.aTarih,
            this.sTT});
            this.emanetListesi.FullRowSelect = true;
            this.emanetListesi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.emanetListesi.HideSelection = false;
            this.emanetListesi.Location = new System.Drawing.Point(16, 209);
            this.emanetListesi.Name = "emanetListesi";
            this.emanetListesi.Size = new System.Drawing.Size(1015, 415);
            this.emanetListesi.TabIndex = 15;
            this.emanetListesi.UseCompatibleStateImageBehavior = false;
            this.emanetListesi.View = System.Windows.Forms.View.Details;
            // 
            // ide
            // 
            this.ide.Text = "ID";
            // 
            // kAde
            // 
            this.kAde.Text = "Kitap Adı";
            this.kAde.Width = 250;
            // 
            // yazare
            // 
            this.yazare.Text = "Yazar";
            this.yazare.Width = 281;
            // 
            // aTarih
            // 
            this.aTarih.Text = "Alım tarihi";
            this.aTarih.Width = 200;
            // 
            // sTT
            // 
            this.sTT.Text = "Son teslim Tarihi";
            this.sTT.Width = 200;
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(994, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.kitapAraBtn_Click);
            // 
            // adSoyadLbl
            // 
            this.adSoyadLbl.AutoSize = true;
            this.adSoyadLbl.Location = new System.Drawing.Point(16, 13);
            this.adSoyadLbl.Name = "adSoyadLbl";
            this.adSoyadLbl.Size = new System.Drawing.Size(52, 17);
            this.adSoyadLbl.TabIndex = 22;
            this.adSoyadLbl.Text = "label3";
            // 
            // uyeEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1045, 653);
            this.Controls.Add(this.adSoyadLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.tablolbl);
            this.Controls.Add(this.emanetPanel);
            this.Controls.Add(this.aramaTxt);
            this.Controls.Add(this.kitapAlBtn);
            this.Controls.Add(this.emanetListesiBtn);
            this.Controls.Add(this.kitapListesi);
            this.Controls.Add(this.emanetListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "uyeEkran";
            this.Text = "Üye Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uyeEkran_FormClosed);
            this.Load += new System.EventHandler(this.uyeEkran_Load);
            this.emanetPanel.ResumeLayout(false);
            this.emanetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Label tablolbl;
        private System.Windows.Forms.Panel emanetPanel;
        private System.Windows.Forms.Button onaylaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aramaTxt;
        private System.Windows.Forms.Button kitapAlBtn;
        private System.Windows.Forms.Button emanetListesiBtn;
        private System.Windows.Forms.ListView kitapListesi;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader kAd;
        private System.Windows.Forms.ColumnHeader yazar;
        private System.Windows.Forms.ColumnHeader sayfaSayisi;
        private System.Windows.Forms.ColumnHeader kitapTürü;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.ListView emanetListesi;
        private System.Windows.Forms.ColumnHeader ide;
        private System.Windows.Forms.ColumnHeader kAde;
        private System.Windows.Forms.ColumnHeader yazare;
        private System.Windows.Forms.ColumnHeader aTarih;
        private System.Windows.Forms.ColumnHeader sTT;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.DateTimePicker alimTrh;
        private System.Windows.Forms.DateTimePicker teslimTrh;
        private System.Windows.Forms.Button teslimBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label adSoyadLbl;
    }
}