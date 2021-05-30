namespace PromosyonTakip.UI.Muısteri
{
    partial class anaEkran
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
            this.GPMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEMailAdres = new System.Windows.Forms.TextBox();
            this.checkEPostaOnay = new System.Windows.Forms.CheckBox();
            this.checkSMSOnay = new System.Windows.Forms.CheckBox();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.HediyePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GPMusteriBilgileri.SuspendLayout();
            this.HediyePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPMusteriBilgileri
            // 
            this.GPMusteriBilgileri.Controls.Add(this.btnIptal);
            this.GPMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.GPMusteriBilgileri.Controls.Add(this.checkSMSOnay);
            this.GPMusteriBilgileri.Controls.Add(this.checkEPostaOnay);
            this.GPMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.GPMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.GPMusteriBilgileri.Controls.Add(this.label5);
            this.GPMusteriBilgileri.Controls.Add(this.label8);
            this.GPMusteriBilgileri.Controls.Add(this.label2);
            this.GPMusteriBilgileri.Controls.Add(this.txtTelefonNo);
            this.GPMusteriBilgileri.Controls.Add(this.txtTCKimlikNo);
            this.GPMusteriBilgileri.Controls.Add(this.label4);
            this.GPMusteriBilgileri.Controls.Add(this.txtEMailAdres);
            this.GPMusteriBilgileri.Controls.Add(this.label7);
            this.GPMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.GPMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.GPMusteriBilgileri.Controls.Add(this.label3);
            this.GPMusteriBilgileri.Controls.Add(this.label6);
            this.GPMusteriBilgileri.Controls.Add(this.txtIsim);
            this.GPMusteriBilgileri.Controls.Add(this.label1);
            this.GPMusteriBilgileri.Location = new System.Drawing.Point(515, 12);
            this.GPMusteriBilgileri.Name = "GPMusteriBilgileri";
            this.GPMusteriBilgileri.Size = new System.Drawing.Size(457, 667);
            this.GPMusteriBilgileri.TabIndex = 0;
            this.GPMusteriBilgileri.TabStop = false;
            this.GPMusteriBilgileri.Text = "Müşteri Bilgileri";
            this.GPMusteriBilgileri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(178, 100);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(232, 24);
            this.txtIsim.TabIndex = 1;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(178, 70);
            this.txtTCKimlikNo.Mask = "00000000000";
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(232, 24);
            this.txtTCKimlikNo.TabIndex = 0;
            this.txtTCKimlikNo.ValidatingType = typeof(int);
            this.txtTCKimlikNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTCKimlikNo_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TC Kimlik Numara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(178, 130);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(232, 24);
            this.txtSoyisim.TabIndex = 2;
            this.txtSoyisim.TextChanged += new System.EventHandler(this.txtSoyisim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(178, 163);
            this.txtDogumTarih.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(232, 24);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.ValueChanged += new System.EventHandler(this.txtDogumTarih_ValueChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(178, 194);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(232, 26);
            this.cmbCinsiyet.TabIndex = 4;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(178, 226);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(232, 24);
            this.txtMeslek.TabIndex = 5;
            this.txtMeslek.TextChanged += new System.EventHandler(this.txtMeslek_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail Adres";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEMailAdres
            // 
            this.txtEMailAdres.Location = new System.Drawing.Point(178, 256);
            this.txtEMailAdres.Name = "txtEMailAdres";
            this.txtEMailAdres.Size = new System.Drawing.Size(232, 24);
            this.txtEMailAdres.TabIndex = 6;
            this.txtEMailAdres.TextChanged += new System.EventHandler(this.txtEMailAdres_TextChanged);
            // 
            // checkEPostaOnay
            // 
            this.checkEPostaOnay.AutoSize = true;
            this.checkEPostaOnay.Location = new System.Drawing.Point(178, 287);
            this.checkEPostaOnay.Name = "checkEPostaOnay";
            this.checkEPostaOnay.Size = new System.Drawing.Size(233, 22);
            this.checkEPostaOnay.TabIndex = 7;
            this.checkEPostaOnay.Text = "E-Mail Bildirim Almak İstiyorum";
            this.checkEPostaOnay.UseVisualStyleBackColor = true;
            this.checkEPostaOnay.CheckedChanged += new System.EventHandler(this.checkEPostaOnay_CheckedChanged);
            // 
            // checkSMSOnay
            // 
            this.checkSMSOnay.AutoSize = true;
            this.checkSMSOnay.Location = new System.Drawing.Point(178, 347);
            this.checkSMSOnay.Name = "checkSMSOnay";
            this.checkSMSOnay.Size = new System.Drawing.Size(224, 22);
            this.checkSMSOnay.TabIndex = 9;
            this.checkSMSOnay.Text = "SMS Bildirim Almak İstiyorum";
            this.checkSMSOnay.UseVisualStyleBackColor = true;
            this.checkSMSOnay.CheckedChanged += new System.EventHandler(this.checkSMSOnay_CheckedChanged);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(178, 317);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(232, 24);
            this.txtTelefonNo.TabIndex = 8;
            this.txtTelefonNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefonNo_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefon Numara";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(178, 375);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(232, 39);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(178, 420);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(232, 39);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // HediyePanel
            // 
            this.HediyePanel.Controls.Add(this.pictureBox1);
            this.HediyePanel.Location = new System.Drawing.Point(12, 12);
            this.HediyePanel.Name = "HediyePanel";
            this.HediyePanel.Size = new System.Drawing.Size(497, 667);
            this.HediyePanel.TabIndex = 11;
            this.HediyePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HediyePanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.HediyePanel);
            this.Controls.Add(this.GPMusteriBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı";
            this.GPMusteriBilgileri.ResumeLayout(false);
            this.GPMusteriBilgileri.PerformLayout();
            this.HediyePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPMusteriBilgileri;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox checkSMSOnay;
        private System.Windows.Forms.CheckBox checkEPostaOnay;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
        private System.Windows.Forms.MaskedTextBox txtTCKimlikNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEMailAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel HediyePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}