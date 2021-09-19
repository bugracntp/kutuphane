
namespace kütüphane
{
    partial class uyeolma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gizleCmb = new System.Windows.Forms.CheckBox();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.onaylaBtn = new System.Windows.Forms.Button();
            this.sifreTxt = new System.Windows.Forms.MaskedTextBox();
            this.kAdTxt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.tcTxt = new System.Windows.Forms.MaskedTextBox();
            this.yasTxt = new System.Windows.Forms.MaskedTextBox();
            this.soyadTxt = new System.Windows.Forms.MaskedTextBox();
            this.adTxt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tekrarSifreTxt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tekrarSifreTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gizleCmb);
            this.groupBox1.Controls.Add(this.iptalBtn);
            this.groupBox1.Controls.Add(this.onaylaBtn);
            this.groupBox1.Controls.Add(this.sifreTxt);
            this.groupBox1.Controls.Add(this.kAdTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.telefonTxt);
            this.groupBox1.Controls.Add(this.tcTxt);
            this.groupBox1.Controls.Add(this.yasTxt);
            this.groupBox1.Controls.Add(this.soyadTxt);
            this.groupBox1.Controls.Add(this.adTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilerinizi Giriniz";
            // 
            // gizleCmb
            // 
            this.gizleCmb.AutoSize = true;
            this.gizleCmb.Checked = true;
            this.gizleCmb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gizleCmb.Location = new System.Drawing.Point(165, 386);
            this.gizleCmb.Name = "gizleCmb";
            this.gizleCmb.Size = new System.Drawing.Size(71, 24);
            this.gizleCmb.TabIndex = 15;
            this.gizleCmb.Text = "gizle";
            this.gizleCmb.UseVisualStyleBackColor = true;
            this.gizleCmb.CheckedChanged += new System.EventHandler(this.gizleCmb_CheckedChanged);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iptalBtn.Location = new System.Drawing.Point(355, 204);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(106, 60);
            this.iptalBtn.TabIndex = 14;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // onaylaBtn
            // 
            this.onaylaBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.onaylaBtn.Location = new System.Drawing.Point(355, 121);
            this.onaylaBtn.Name = "onaylaBtn";
            this.onaylaBtn.Size = new System.Drawing.Size(106, 60);
            this.onaylaBtn.TabIndex = 13;
            this.onaylaBtn.Text = "Onayla";
            this.onaylaBtn.UseVisualStyleBackColor = false;
            this.onaylaBtn.Click += new System.EventHandler(this.onaylaBtn_Click);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(165, 310);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(176, 27);
            this.sifreTxt.TabIndex = 12;
            // 
            // kAdTxt
            // 
            this.kAdTxt.Location = new System.Drawing.Point(165, 267);
            this.kAdTxt.Name = "kAdTxt";
            this.kAdTxt.Size = new System.Drawing.Size(176, 27);
            this.kAdTxt.TabIndex = 11;
            this.kAdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yazi_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı :";
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(165, 224);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(176, 27);
            this.telefonTxt.TabIndex = 9;
            this.telefonTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayi_KeyPress);
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(165, 181);
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(176, 27);
            this.tcTxt.TabIndex = 8;
            this.tcTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayi_KeyPress);
            // 
            // yasTxt
            // 
            this.yasTxt.Location = new System.Drawing.Point(165, 138);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(176, 27);
            this.yasTxt.TabIndex = 7;
            this.yasTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayi_KeyPress);
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(165, 95);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(176, 27);
            this.soyadTxt.TabIndex = 6;
            this.soyadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yazi_KeyPress);
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(165, 52);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(176, 27);
            this.adTxt.TabIndex = 5;
            this.adTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yazi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // tekrarSifreTxt
            // 
            this.tekrarSifreTxt.Location = new System.Drawing.Point(165, 353);
            this.tekrarSifreTxt.Name = "tekrarSifreTxt";
            this.tekrarSifreTxt.Size = new System.Drawing.Size(176, 27);
            this.tekrarSifreTxt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Şifre (Tekrar) :";
            // 
            // uyeolma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(514, 445);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "uyeolma";
            this.Text = "Üye Kayıt Formu";
            this.Load += new System.EventHandler(this.uyeolma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button onaylaBtn;
        private System.Windows.Forms.MaskedTextBox sifreTxt;
        private System.Windows.Forms.MaskedTextBox kAdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox telefonTxt;
        private System.Windows.Forms.MaskedTextBox tcTxt;
        private System.Windows.Forms.MaskedTextBox yasTxt;
        private System.Windows.Forms.MaskedTextBox soyadTxt;
        private System.Windows.Forms.MaskedTextBox adTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox gizleCmb;
        private System.Windows.Forms.MaskedTextBox tekrarSifreTxt;
        private System.Windows.Forms.Label label8;
    }
}