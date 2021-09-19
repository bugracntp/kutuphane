
namespace kütüphane
{
    partial class girisekranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.girisPanel = new System.Windows.Forms.Panel();
            this.yoneticiRad = new System.Windows.Forms.RadioButton();
            this.gösterChckb = new System.Windows.Forms.CheckBox();
            this.üye = new System.Windows.Forms.Button();
            this.girisBtn = new System.Windows.Forms.Button();
            this.calisanRad = new System.Windows.Forms.RadioButton();
            this.uyeRad = new System.Windows.Forms.RadioButton();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.KAdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.girisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(572, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarih";
            // 
            // girisPanel
            // 
            this.girisPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisPanel.BackColor = System.Drawing.Color.LightBlue;
            this.girisPanel.Controls.Add(this.yoneticiRad);
            this.girisPanel.Controls.Add(this.gösterChckb);
            this.girisPanel.Controls.Add(this.üye);
            this.girisPanel.Controls.Add(this.girisBtn);
            this.girisPanel.Controls.Add(this.calisanRad);
            this.girisPanel.Controls.Add(this.uyeRad);
            this.girisPanel.Controls.Add(this.SifreTxt);
            this.girisPanel.Controls.Add(this.KAdTxt);
            this.girisPanel.Controls.Add(this.label3);
            this.girisPanel.Controls.Add(this.label2);
            this.girisPanel.Controls.Add(this.label1);
            this.girisPanel.Location = new System.Drawing.Point(254, 79);
            this.girisPanel.Name = "girisPanel";
            this.girisPanel.Size = new System.Drawing.Size(358, 346);
            this.girisPanel.TabIndex = 3;
            // 
            // yoneticiRad
            // 
            this.yoneticiRad.AutoSize = true;
            this.yoneticiRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiRad.Location = new System.Drawing.Point(243, 192);
            this.yoneticiRad.Name = "yoneticiRad";
            this.yoneticiRad.Size = new System.Drawing.Size(89, 24);
            this.yoneticiRad.TabIndex = 11;
            this.yoneticiRad.TabStop = true;
            this.yoneticiRad.Text = "Yönetici";
            this.yoneticiRad.UseVisualStyleBackColor = true;
            // 
            // gösterChckb
            // 
            this.gösterChckb.AutoSize = true;
            this.gösterChckb.Location = new System.Drawing.Point(281, 141);
            this.gösterChckb.Name = "gösterChckb";
            this.gösterChckb.Size = new System.Drawing.Size(70, 21);
            this.gösterChckb.TabIndex = 10;
            this.gösterChckb.Text = "göster";
            this.gösterChckb.UseVisualStyleBackColor = true;
            this.gösterChckb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // üye
            // 
            this.üye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üye.Location = new System.Drawing.Point(243, 261);
            this.üye.Name = "üye";
            this.üye.Size = new System.Drawing.Size(86, 50);
            this.üye.TabIndex = 9;
            this.üye.Text = "Üye Ol";
            this.üye.UseVisualStyleBackColor = true;
            this.üye.Click += new System.EventHandler(this.üye_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn.Location = new System.Drawing.Point(32, 261);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(89, 50);
            this.girisBtn.TabIndex = 8;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // calisanRad
            // 
            this.calisanRad.AutoSize = true;
            this.calisanRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanRad.Location = new System.Drawing.Point(139, 192);
            this.calisanRad.Name = "calisanRad";
            this.calisanRad.Size = new System.Drawing.Size(86, 24);
            this.calisanRad.TabIndex = 7;
            this.calisanRad.TabStop = true;
            this.calisanRad.Text = "Çalışan";
            this.calisanRad.UseVisualStyleBackColor = true;
            // 
            // uyeRad
            // 
            this.uyeRad.AutoSize = true;
            this.uyeRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeRad.Location = new System.Drawing.Point(62, 192);
            this.uyeRad.Name = "uyeRad";
            this.uyeRad.Size = new System.Drawing.Size(59, 24);
            this.uyeRad.TabIndex = 6;
            this.uyeRad.TabStop = true;
            this.uyeRad.Text = "Üye";
            this.uyeRad.UseVisualStyleBackColor = true;
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(160, 139);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(100, 22);
            this.SifreTxt.TabIndex = 5;
            // 
            // KAdTxt
            // 
            this.KAdTxt.Location = new System.Drawing.Point(160, 94);
            this.KAdTxt.Name = "KAdTxt";
            this.KAdTxt.Size = new System.Drawing.Size(100, 22);
            this.KAdTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Paneli";
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // girisekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(821, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.girisPanel);
            this.Name = "girisekranı";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giris_FormClosed);
            this.Load += new System.EventHandler(this.giris_Load);
            this.girisPanel.ResumeLayout(false);
            this.girisPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel girisPanel;
        private System.Windows.Forms.Button üye;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.RadioButton calisanRad;
        private System.Windows.Forms.RadioButton uyeRad;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.TextBox KAdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.CheckBox gösterChckb;
        private System.Windows.Forms.RadioButton yoneticiRad;
    }
}

