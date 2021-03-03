namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrTC = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrTelefon = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrDogum = new System.Windows.Forms.Label();
            this.lblOgrBolum = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.lblOgrMail = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.lblOgrOdaNo = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.lblVeliAdSoyad = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliTelefon = new System.Windows.Forms.Label();
            this.lblVeliAdres = new System.Windows.Forms.Label();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.ForeColor = System.Drawing.Color.Black;
            this.lblOgrAd.Location = new System.Drawing.Point(140, 28);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(88, 18);
            this.lblOgrAd.TabIndex = 0;
            this.lblOgrAd.Text = "Öğrenci Ad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.MintCream;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.ForeColor = System.Drawing.Color.Black;
            this.TxtOgrAd.Location = new System.Drawing.Point(234, 25);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(233, 26);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.MintCream;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.ForeColor = System.Drawing.Color.Black;
            this.TxtOgrSoyad.Location = new System.Drawing.Point(234, 57);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(233, 26);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblOgrSoyad.Location = new System.Drawing.Point(118, 60);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(110, 18);
            this.lblOgrSoyad.TabIndex = 2;
            this.lblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // lblOgrTC
            // 
            this.lblOgrTC.AutoSize = true;
            this.lblOgrTC.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrTC.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrTC.ForeColor = System.Drawing.Color.Black;
            this.lblOgrTC.Location = new System.Drawing.Point(196, 88);
            this.lblOgrTC.Name = "lblOgrTC";
            this.lblOgrTC.Size = new System.Drawing.Size(32, 18);
            this.lblOgrTC.TabIndex = 4;
            this.lblOgrTC.Text = "TC:";
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.MintCream;
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.ForeColor = System.Drawing.Color.Black;
            this.MskTC.Location = new System.Drawing.Point(234, 89);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(233, 26);
            this.MskTC.TabIndex = 3;
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.Color.MintCream;
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTelefon.ForeColor = System.Drawing.Color.Black;
            this.MskOgrTelefon.Location = new System.Drawing.Point(234, 121);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(233, 26);
            this.MskOgrTelefon.TabIndex = 4;
            // 
            // lblOgrTelefon
            // 
            this.lblOgrTelefon.AutoSize = true;
            this.lblOgrTelefon.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrTelefon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblOgrTelefon.Location = new System.Drawing.Point(166, 121);
            this.lblOgrTelefon.Name = "lblOgrTelefon";
            this.lblOgrTelefon.Size = new System.Drawing.Size(62, 18);
            this.lblOgrTelefon.TabIndex = 6;
            this.lblOgrTelefon.Text = "Telefon:";
            // 
            // MskDogum
            // 
            this.MskDogum.BackColor = System.Drawing.Color.MintCream;
            this.MskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogum.ForeColor = System.Drawing.Color.Black;
            this.MskDogum.Location = new System.Drawing.Point(234, 153);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(233, 26);
            this.MskDogum.TabIndex = 5;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // lblOgrDogum
            // 
            this.lblOgrDogum.AutoSize = true;
            this.lblOgrDogum.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrDogum.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrDogum.ForeColor = System.Drawing.Color.Black;
            this.lblOgrDogum.Location = new System.Drawing.Point(121, 156);
            this.lblOgrDogum.Name = "lblOgrDogum";
            this.lblOgrDogum.Size = new System.Drawing.Size(107, 18);
            this.lblOgrDogum.TabIndex = 8;
            this.lblOgrDogum.Text = "Doğum Tarihi:";
            // 
            // lblOgrBolum
            // 
            this.lblOgrBolum.AutoSize = true;
            this.lblOgrBolum.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrBolum.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBolum.ForeColor = System.Drawing.Color.Black;
            this.lblOgrBolum.Location = new System.Drawing.Point(113, 190);
            this.lblOgrBolum.Name = "lblOgrBolum";
            this.lblOgrBolum.Size = new System.Drawing.Size(115, 18);
            this.lblOgrBolum.TabIndex = 10;
            this.lblOgrBolum.Text = "Öğrenci Bölüm:";
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.MintCream;
            this.CmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.ForeColor = System.Drawing.Color.Black;
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(234, 185);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(233, 26);
            this.CmbBolum.TabIndex = 6;
            // 
            // lblOgrMail
            // 
            this.lblOgrMail.AutoSize = true;
            this.lblOgrMail.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrMail.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrMail.ForeColor = System.Drawing.Color.Black;
            this.lblOgrMail.Location = new System.Drawing.Point(185, 224);
            this.lblOgrMail.Name = "lblOgrMail";
            this.lblOgrMail.Size = new System.Drawing.Size(43, 18);
            this.lblOgrMail.TabIndex = 12;
            this.lblOgrMail.Text = "Mail:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.MintCream;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.ForeColor = System.Drawing.Color.Black;
            this.TxtMail.Location = new System.Drawing.Point(234, 216);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(233, 26);
            this.TxtMail.TabIndex = 7;
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.MintCream;
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.ForeColor = System.Drawing.Color.Black;
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(234, 249);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(233, 26);
            this.CmbOdaNo.TabIndex = 8;
            // 
            // lblOgrOdaNo
            // 
            this.lblOgrOdaNo.AutoSize = true;
            this.lblOgrOdaNo.BackColor = System.Drawing.Color.MintCream;
            this.lblOgrOdaNo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrOdaNo.ForeColor = System.Drawing.Color.Black;
            this.lblOgrOdaNo.Location = new System.Drawing.Point(163, 256);
            this.lblOgrOdaNo.Name = "lblOgrOdaNo";
            this.lblOgrOdaNo.Size = new System.Drawing.Size(65, 18);
            this.lblOgrOdaNo.TabIndex = 14;
            this.lblOgrOdaNo.Text = "Oda No:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.MintCream;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(234, 281);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(233, 26);
            this.TxtVeliAdSoyad.TabIndex = 9;
            // 
            // lblVeliAdSoyad
            // 
            this.lblVeliAdSoyad.AutoSize = true;
            this.lblVeliAdSoyad.BackColor = System.Drawing.Color.MintCream;
            this.lblVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblVeliAdSoyad.Location = new System.Drawing.Point(124, 284);
            this.lblVeliAdSoyad.Name = "lblVeliAdSoyad";
            this.lblVeliAdSoyad.Size = new System.Drawing.Size(104, 18);
            this.lblVeliAdSoyad.TabIndex = 16;
            this.lblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.MintCream;
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelefon.ForeColor = System.Drawing.Color.Black;
            this.MskVeliTelefon.Location = new System.Drawing.Point(234, 315);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(233, 26);
            this.MskVeliTelefon.TabIndex = 10;
            // 
            // lblVeliTelefon
            // 
            this.lblVeliTelefon.AutoSize = true;
            this.lblVeliTelefon.BackColor = System.Drawing.Color.MintCream;
            this.lblVeliTelefon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblVeliTelefon.Location = new System.Drawing.Point(137, 318);
            this.lblVeliTelefon.Name = "lblVeliTelefon";
            this.lblVeliTelefon.Size = new System.Drawing.Size(91, 18);
            this.lblVeliTelefon.TabIndex = 18;
            this.lblVeliTelefon.Text = "Veli Telefon:";
            // 
            // lblVeliAdres
            // 
            this.lblVeliAdres.AutoSize = true;
            this.lblVeliAdres.BackColor = System.Drawing.Color.MintCream;
            this.lblVeliAdres.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdres.ForeColor = System.Drawing.Color.Black;
            this.lblVeliAdres.Location = new System.Drawing.Point(178, 355);
            this.lblVeliAdres.Name = "lblVeliAdres";
            this.lblVeliAdres.Size = new System.Drawing.Size(50, 18);
            this.lblVeliAdres.TabIndex = 20;
            this.lblVeliAdres.Text = "Adres:";
            // 
            // RchAdres
            // 
            this.RchAdres.BackColor = System.Drawing.Color.MintCream;
            this.RchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchAdres.ForeColor = System.Drawing.Color.Black;
            this.RchAdres.Location = new System.Drawing.Point(234, 352);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(233, 96);
            this.RchAdres.TabIndex = 11;
            this.RchAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(287, 463);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(139, 36);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MintCream;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(163, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 512);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.lblVeliAdres);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.lblVeliTelefon);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.lblVeliAdSoyad);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.lblOgrOdaNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.lblOgrMail);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.lblOgrBolum);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.lblOgrDogum);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.lblOgrTelefon);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.lblOgrTC);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.lblOgrAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrTC;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.Label lblOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label lblOgrDogum;
        private System.Windows.Forms.Label lblOgrBolum;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label lblOgrMail;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label lblOgrOdaNo;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label lblVeliAdSoyad;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.Label lblVeliTelefon;
        private System.Windows.Forms.Label lblVeliAdres;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label11;
    }
}

