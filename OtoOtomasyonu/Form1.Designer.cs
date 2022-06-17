namespace OtoOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iptal = new System.Windows.Forms.PictureBox();
            this.lblilanNumarasi = new System.Windows.Forms.Label();
            this.lblSeriNumarasi = new System.Windows.Forms.Label();
            this.lblAracMarkasi = new System.Windows.Forms.Label();
            this.lblAracModeli = new System.Windows.Forms.Label();
            this.lblilanBasligi = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblYakitTuru = new System.Windows.Forms.Label();
            this.lblVites = new System.Windows.Forms.Label();
            this.lblKilometre = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKasaTipi = new System.Windows.Forms.Label();
            this.lblilanTarihi = new System.Windows.Forms.Label();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblIlIlce = new System.Windows.Forms.Label();
            this.lblKimden = new System.Windows.Forms.Label();
            this.dtpIlanTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIlanBasligi = new System.Windows.Forms.TextBox();
            this.txtYakitTuru = new System.Windows.Forms.TextBox();
            this.txtSeriNumarasi = new System.Windows.Forms.TextBox();
            this.txtIlanNumarasi = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtVites = new System.Windows.Forms.TextBox();
            this.txtAracMarkasi = new System.Windows.Forms.TextBox();
            this.txtAracModeli = new System.Windows.Forms.TextBox();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.cmbKimden = new System.Windows.Forms.ComboBox();
            this.txtKilometre = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtIlIlce = new System.Windows.Forms.TextBox();
            this.txtAracBilgi = new System.Windows.Forms.TextBox();
            this.İlanKaydet = new System.Windows.Forms.Button();
            this.ilankapat = new System.Windows.Forms.Button();
            this.İlanekleme = new System.Windows.Forms.Label();
            this.Sayfakapat = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.GroupBox();
            this.Linkkaldir = new System.Windows.Forms.LinkLabel();
            this.Linkekle = new System.Windows.Forms.LinkLabel();
            this.aracresim = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Bilgi = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iptal)).BeginInit();
            this.Resim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Bilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iptal.BackgroundImage")));
            this.iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iptal.Location = new System.Drawing.Point(-5, -15);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(1128, 742);
            this.iptal.TabIndex = 1;
            this.iptal.TabStop = false;
            // 
            // lblilanNumarasi
            // 
            this.lblilanNumarasi.AllowDrop = true;
            this.lblilanNumarasi.AutoEllipsis = true;
            this.lblilanNumarasi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblilanNumarasi.Enabled = false;
            this.lblilanNumarasi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblilanNumarasi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblilanNumarasi.Location = new System.Drawing.Point(42, 85);
            this.lblilanNumarasi.Name = "lblilanNumarasi";
            this.lblilanNumarasi.Size = new System.Drawing.Size(116, 29);
            this.lblilanNumarasi.TabIndex = 2;
            this.lblilanNumarasi.Text = "İlan Numarası";
            this.lblilanNumarasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeriNumarasi
            // 
            this.lblSeriNumarasi.AllowDrop = true;
            this.lblSeriNumarasi.AutoEllipsis = true;
            this.lblSeriNumarasi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSeriNumarasi.Enabled = false;
            this.lblSeriNumarasi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeriNumarasi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSeriNumarasi.Location = new System.Drawing.Point(42, 390);
            this.lblSeriNumarasi.Name = "lblSeriNumarasi";
            this.lblSeriNumarasi.Size = new System.Drawing.Size(116, 23);
            this.lblSeriNumarasi.TabIndex = 3;
            this.lblSeriNumarasi.Text = "Seri Numarası";
            this.lblSeriNumarasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAracMarkasi
            // 
            this.lblAracMarkasi.AllowDrop = true;
            this.lblAracMarkasi.AutoEllipsis = true;
            this.lblAracMarkasi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAracMarkasi.Enabled = false;
            this.lblAracMarkasi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAracMarkasi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAracMarkasi.Location = new System.Drawing.Point(42, 121);
            this.lblAracMarkasi.Name = "lblAracMarkasi";
            this.lblAracMarkasi.Size = new System.Drawing.Size(116, 26);
            this.lblAracMarkasi.TabIndex = 4;
            this.lblAracMarkasi.Text = "Araç Markası";
            this.lblAracMarkasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAracModeli
            // 
            this.lblAracModeli.AllowDrop = true;
            this.lblAracModeli.AutoEllipsis = true;
            this.lblAracModeli.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAracModeli.Enabled = false;
            this.lblAracModeli.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAracModeli.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAracModeli.Location = new System.Drawing.Point(42, 154);
            this.lblAracModeli.Name = "lblAracModeli";
            this.lblAracModeli.Size = new System.Drawing.Size(116, 26);
            this.lblAracModeli.TabIndex = 5;
            this.lblAracModeli.Text = "Araç Modeli";
            this.lblAracModeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblilanBasligi
            // 
            this.lblilanBasligi.AllowDrop = true;
            this.lblilanBasligi.AutoEllipsis = true;
            this.lblilanBasligi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblilanBasligi.Enabled = false;
            this.lblilanBasligi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblilanBasligi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblilanBasligi.Location = new System.Drawing.Point(42, 50);
            this.lblilanBasligi.Name = "lblilanBasligi";
            this.lblilanBasligi.Size = new System.Drawing.Size(116, 30);
            this.lblilanBasligi.TabIndex = 6;
            this.lblilanBasligi.Text = "İlan Başlığı";
            this.lblilanBasligi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYil
            // 
            this.lblYil.AllowDrop = true;
            this.lblYil.AutoEllipsis = true;
            this.lblYil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblYil.Enabled = false;
            this.lblYil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYil.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblYil.Location = new System.Drawing.Point(489, 9);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(117, 31);
            this.lblYil.TabIndex = 7;
            this.lblYil.Text = "Yıl";
            this.lblYil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYakitTuru
            // 
            this.lblYakitTuru.AllowDrop = true;
            this.lblYakitTuru.AutoEllipsis = true;
            this.lblYakitTuru.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblYakitTuru.Enabled = false;
            this.lblYakitTuru.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYakitTuru.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblYakitTuru.Location = new System.Drawing.Point(39, 646);
            this.lblYakitTuru.Name = "lblYakitTuru";
            this.lblYakitTuru.Size = new System.Drawing.Size(119, 24);
            this.lblYakitTuru.TabIndex = 8;
            this.lblYakitTuru.Text = "Yakıt Türü";
            this.lblYakitTuru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVites
            // 
            this.lblVites.AllowDrop = true;
            this.lblVites.AutoEllipsis = true;
            this.lblVites.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVites.Enabled = false;
            this.lblVites.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVites.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblVites.Location = new System.Drawing.Point(39, 502);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(119, 25);
            this.lblVites.TabIndex = 9;
            this.lblVites.Text = "Vites";
            this.lblVites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKilometre
            // 
            this.lblKilometre.AllowDrop = true;
            this.lblKilometre.AutoEllipsis = true;
            this.lblKilometre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKilometre.Enabled = false;
            this.lblKilometre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKilometre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblKilometre.Location = new System.Drawing.Point(39, 570);
            this.lblKilometre.Name = "lblKilometre";
            this.lblKilometre.Size = new System.Drawing.Size(119, 28);
            this.lblKilometre.TabIndex = 10;
            this.lblKilometre.Text = "Kilometre(KM)";
            this.lblKilometre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRenk
            // 
            this.lblRenk.AllowDrop = true;
            this.lblRenk.AutoEllipsis = true;
            this.lblRenk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRenk.Enabled = false;
            this.lblRenk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRenk.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblRenk.Location = new System.Drawing.Point(39, 463);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(119, 26);
            this.lblRenk.TabIndex = 11;
            this.lblRenk.Text = "Renk";
            this.lblRenk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AllowDrop = true;
            this.lblFiyat.AutoEllipsis = true;
            this.lblFiyat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFiyat.Enabled = false;
            this.lblFiyat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblFiyat.Location = new System.Drawing.Point(489, 50);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(117, 30);
            this.lblFiyat.TabIndex = 12;
            this.lblFiyat.Text = "Fiyat";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKasaTipi
            // 
            this.lblKasaTipi.AllowDrop = true;
            this.lblKasaTipi.AutoEllipsis = true;
            this.lblKasaTipi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKasaTipi.Enabled = false;
            this.lblKasaTipi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKasaTipi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblKasaTipi.Location = new System.Drawing.Point(39, 606);
            this.lblKasaTipi.Name = "lblKasaTipi";
            this.lblKasaTipi.Size = new System.Drawing.Size(119, 26);
            this.lblKasaTipi.TabIndex = 13;
            this.lblKasaTipi.Text = "Kasa Tipi";
            this.lblKasaTipi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblilanTarihi
            // 
            this.lblilanTarihi.AllowDrop = true;
            this.lblilanTarihi.AutoEllipsis = true;
            this.lblilanTarihi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblilanTarihi.Enabled = false;
            this.lblilanTarihi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblilanTarihi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblilanTarihi.Location = new System.Drawing.Point(42, 12);
            this.lblilanTarihi.Name = "lblilanTarihi";
            this.lblilanTarihi.Size = new System.Drawing.Size(116, 28);
            this.lblilanTarihi.TabIndex = 14;
            this.lblilanTarihi.Text = "İlan Tarihi";
            this.lblilanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurumu
            // 
            this.lblDurumu.AllowDrop = true;
            this.lblDurumu.AutoEllipsis = true;
            this.lblDurumu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDurumu.Enabled = false;
            this.lblDurumu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurumu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDurumu.Location = new System.Drawing.Point(39, 537);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(119, 24);
            this.lblDurumu.TabIndex = 16;
            this.lblDurumu.Text = "Durumu";
            this.lblDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIlIlce
            // 
            this.lblIlIlce.AllowDrop = true;
            this.lblIlIlce.AutoEllipsis = true;
            this.lblIlIlce.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblIlIlce.Enabled = false;
            this.lblIlIlce.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIlIlce.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIlIlce.Location = new System.Drawing.Point(489, 85);
            this.lblIlIlce.Name = "lblIlIlce";
            this.lblIlIlce.Size = new System.Drawing.Size(117, 29);
            this.lblIlIlce.TabIndex = 17;
            this.lblIlIlce.Text = "İl/İlçe";
            this.lblIlIlce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKimden
            // 
            this.lblKimden.AllowDrop = true;
            this.lblKimden.AutoEllipsis = true;
            this.lblKimden.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKimden.Enabled = false;
            this.lblKimden.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKimden.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblKimden.Location = new System.Drawing.Point(42, 428);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(116, 24);
            this.lblKimden.TabIndex = 18;
            this.lblKimden.Text = "Kimden";
            this.lblKimden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpIlanTarihi
            // 
            this.dtpIlanTarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpIlanTarihi.Location = new System.Drawing.Point(182, 11);
            this.dtpIlanTarihi.Name = "dtpIlanTarihi";
            this.dtpIlanTarihi.Size = new System.Drawing.Size(127, 27);
            this.dtpIlanTarihi.TabIndex = 19;
            // 
            // txtIlanBasligi
            // 
            this.txtIlanBasligi.Location = new System.Drawing.Point(182, 50);
            this.txtIlanBasligi.Multiline = true;
            this.txtIlanBasligi.Name = "txtIlanBasligi";
            this.txtIlanBasligi.Size = new System.Drawing.Size(127, 30);
            this.txtIlanBasligi.TabIndex = 20;
            // 
            // txtYakitTuru
            // 
            this.txtYakitTuru.Location = new System.Drawing.Point(182, 646);
            this.txtYakitTuru.Multiline = true;
            this.txtYakitTuru.Name = "txtYakitTuru";
            this.txtYakitTuru.Size = new System.Drawing.Size(127, 24);
            this.txtYakitTuru.TabIndex = 21;
            // 
            // txtSeriNumarasi
            // 
            this.txtSeriNumarasi.Location = new System.Drawing.Point(182, 390);
            this.txtSeriNumarasi.Multiline = true;
            this.txtSeriNumarasi.Name = "txtSeriNumarasi";
            this.txtSeriNumarasi.Size = new System.Drawing.Size(127, 23);
            this.txtSeriNumarasi.TabIndex = 22;
            // 
            // txtIlanNumarasi
            // 
            this.txtIlanNumarasi.Location = new System.Drawing.Point(182, 85);
            this.txtIlanNumarasi.Multiline = true;
            this.txtIlanNumarasi.Name = "txtIlanNumarasi";
            this.txtIlanNumarasi.Size = new System.Drawing.Size(127, 29);
            this.txtIlanNumarasi.TabIndex = 23;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(182, 606);
            this.txtKasaTipi.Multiline = true;
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(127, 26);
            this.txtKasaTipi.TabIndex = 25;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(182, 463);
            this.txtRenk.Multiline = true;
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(127, 26);
            this.txtRenk.TabIndex = 26;
            // 
            // txtVites
            // 
            this.txtVites.Location = new System.Drawing.Point(182, 501);
            this.txtVites.Multiline = true;
            this.txtVites.Name = "txtVites";
            this.txtVites.Size = new System.Drawing.Size(127, 26);
            this.txtVites.TabIndex = 27;
            // 
            // txtAracMarkasi
            // 
            this.txtAracMarkasi.Location = new System.Drawing.Point(182, 121);
            this.txtAracMarkasi.Multiline = true;
            this.txtAracMarkasi.Name = "txtAracMarkasi";
            this.txtAracMarkasi.Size = new System.Drawing.Size(127, 26);
            this.txtAracMarkasi.TabIndex = 30;
            // 
            // txtAracModeli
            // 
            this.txtAracModeli.Location = new System.Drawing.Point(182, 154);
            this.txtAracModeli.Multiline = true;
            this.txtAracModeli.Name = "txtAracModeli";
            this.txtAracModeli.Size = new System.Drawing.Size(127, 26);
            this.txtAracModeli.TabIndex = 31;
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Location = new System.Drawing.Point(182, 536);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(127, 28);
            this.cmbDurumu.TabIndex = 32;
            // 
            // cmbKimden
            // 
            this.cmbKimden.FormattingEnabled = true;
            this.cmbKimden.Location = new System.Drawing.Point(182, 429);
            this.cmbKimden.Name = "cmbKimden";
            this.cmbKimden.Size = new System.Drawing.Size(127, 28);
            this.cmbKimden.TabIndex = 33;
            // 
            // txtKilometre
            // 
            this.txtKilometre.Location = new System.Drawing.Point(182, 571);
            this.txtKilometre.Multiline = true;
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Size = new System.Drawing.Size(127, 28);
            this.txtKilometre.TabIndex = 34;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(612, 9);
            this.txtYil.Multiline = true;
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(139, 31);
            this.txtYil.TabIndex = 35;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(612, 50);
            this.txtFiyat.Multiline = true;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(139, 30);
            this.txtFiyat.TabIndex = 36;
            // 
            // txtIlIlce
            // 
            this.txtIlIlce.Location = new System.Drawing.Point(612, 86);
            this.txtIlIlce.Multiline = true;
            this.txtIlIlce.Name = "txtIlIlce";
            this.txtIlIlce.Size = new System.Drawing.Size(139, 28);
            this.txtIlIlce.TabIndex = 37;
            // 
            // txtAracBilgi
            // 
            this.txtAracBilgi.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAracBilgi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAracBilgi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAracBilgi.Location = new System.Drawing.Point(0, 28);
            this.txtAracBilgi.Multiline = true;
            this.txtAracBilgi.Name = "txtAracBilgi";
            this.txtAracBilgi.Size = new System.Drawing.Size(220, 135);
            this.txtAracBilgi.TabIndex = 41;
            // 
            // İlanKaydet
            // 
            this.İlanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İlanKaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.İlanKaydet.Image = ((System.Drawing.Image)(resources.GetObject("İlanKaydet.Image")));
            this.İlanKaydet.Location = new System.Drawing.Point(1029, 595);
            this.İlanKaydet.Name = "İlanKaydet";
            this.İlanKaydet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.İlanKaydet.Size = new System.Drawing.Size(46, 37);
            this.İlanKaydet.TabIndex = 42;
            this.İlanKaydet.UseVisualStyleBackColor = true;
            this.İlanKaydet.Click += new System.EventHandler(this.İlanKaydet_Click);
            // 
            // ilankapat
            // 
            this.ilankapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ilankapat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ilankapat.Image = ((System.Drawing.Image)(resources.GetObject("ilankapat.Image")));
            this.ilankapat.Location = new System.Drawing.Point(1029, 640);
            this.ilankapat.Name = "ilankapat";
            this.ilankapat.Size = new System.Drawing.Size(46, 37);
            this.ilankapat.TabIndex = 43;
            this.ilankapat.UseVisualStyleBackColor = true;
            this.ilankapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // İlanekleme
            // 
            this.İlanekleme.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.İlanekleme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.İlanekleme.ForeColor = System.Drawing.Color.Black;
            this.İlanekleme.Location = new System.Drawing.Point(963, 595);
            this.İlanekleme.Name = "İlanekleme";
            this.İlanekleme.Size = new System.Drawing.Size(60, 37);
            this.İlanekleme.TabIndex = 44;
            this.İlanekleme.Text = "İlan Ekle";
            this.İlanekleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sayfakapat
            // 
            this.Sayfakapat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sayfakapat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sayfakapat.Location = new System.Drawing.Point(963, 640);
            this.Sayfakapat.Name = "Sayfakapat";
            this.Sayfakapat.Size = new System.Drawing.Size(60, 37);
            this.Sayfakapat.TabIndex = 45;
            this.Sayfakapat.Text = "Kapat";
            this.Sayfakapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resim
            // 
            this.Resim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Resim.Controls.Add(this.Linkkaldir);
            this.Resim.Controls.Add(this.Linkekle);
            this.Resim.Controls.Add(this.aracresim);
            this.Resim.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Resim.Location = new System.Drawing.Point(42, 198);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(267, 174);
            this.Resim.TabIndex = 46;
            this.Resim.TabStop = false;
            this.Resim.Text = "Araç Görseli";
            // 
            // Linkkaldir
            // 
            this.Linkkaldir.AutoSize = true;
            this.Linkkaldir.LinkColor = System.Drawing.Color.White;
            this.Linkkaldir.Location = new System.Drawing.Point(149, 148);
            this.Linkkaldir.Name = "Linkkaldir";
            this.Linkkaldir.Size = new System.Drawing.Size(88, 21);
            this.Linkkaldir.TabIndex = 3;
            this.Linkkaldir.TabStop = true;
            this.Linkkaldir.Text = "Resim Sil";
            // 
            // Linkekle
            // 
            this.Linkekle.AutoSize = true;
            this.Linkekle.LinkColor = System.Drawing.Color.White;
            this.Linkekle.Location = new System.Drawing.Point(6, 148);
            this.Linkekle.Name = "Linkekle";
            this.Linkekle.Size = new System.Drawing.Size(102, 21);
            this.Linkekle.TabIndex = 2;
            this.Linkekle.TabStop = true;
            this.Linkekle.Text = "Resim Ekle";
            this.Linkekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResimSec);
            // 
            // aracresim
            // 
            this.aracresim.BackColor = System.Drawing.SystemColors.Control;
            this.aracresim.Location = new System.Drawing.Point(-3, 27);
            this.aracresim.Name = "aracresim";
            this.aracresim.Size = new System.Drawing.Size(270, 108);
            this.aracresim.TabIndex = 0;
            this.aracresim.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bilgi
            // 
            this.Bilgi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Bilgi.Controls.Add(this.txtAracBilgi);
            this.Bilgi.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Bilgi.Location = new System.Drawing.Point(888, 12);
            this.Bilgi.Name = "Bilgi";
            this.Bilgi.Size = new System.Drawing.Size(220, 175);
            this.Bilgi.TabIndex = 48;
            this.Bilgi.TabStop = false;
            this.Bilgi.Text = "Bilgi";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 717);
            this.Controls.Add(this.Bilgi);
            this.Controls.Add(this.İlanKaydet);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.Sayfakapat);
            this.Controls.Add(this.İlanekleme);
            this.Controls.Add(this.ilankapat);
            this.Controls.Add(this.txtIlIlce);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtKilometre);
            this.Controls.Add(this.cmbKimden);
            this.Controls.Add(this.cmbDurumu);
            this.Controls.Add(this.txtAracModeli);
            this.Controls.Add(this.txtAracMarkasi);
            this.Controls.Add(this.txtVites);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtKasaTipi);
            this.Controls.Add(this.txtIlanNumarasi);
            this.Controls.Add(this.txtSeriNumarasi);
            this.Controls.Add(this.txtYakitTuru);
            this.Controls.Add(this.txtIlanBasligi);
            this.Controls.Add(this.dtpIlanTarihi);
            this.Controls.Add(this.lblKimden);
            this.Controls.Add(this.lblIlIlce);
            this.Controls.Add(this.lblDurumu);
            this.Controls.Add(this.lblilanTarihi);
            this.Controls.Add(this.lblKasaTipi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblKilometre);
            this.Controls.Add(this.lblVites);
            this.Controls.Add(this.lblYakitTuru);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblilanBasligi);
            this.Controls.Add(this.lblAracModeli);
            this.Controls.Add(this.lblAracMarkasi);
            this.Controls.Add(this.lblSeriNumarasi);
            this.Controls.Add(this.lblilanNumarasi);
            this.Controls.Add(this.iptal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iptal)).EndInit();
            this.Resim.ResumeLayout(false);
            this.Resim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Bilgi.ResumeLayout(false);
            this.Bilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox iptal;
        private Label lblilanNumarasi;
        private Label lblSeriNumarasi;
        private Label lblAracMarkasi;
        private Label lblAracModeli;
        private Label lblilanBasligi;
        private Label lblYil;
        private Label lblYakitTuru;
        private Label lblVites;
        private Label lblKilometre;
        private Label lblRenk;
        private Label lblFiyat;
        private Label lblKasaTipi;
        private Label lblilanTarihi;
        private Label lblDurumu;
        private Label lblIlIlce;
        private Label lblKimden;
        private DateTimePicker dtpIlanTarihi;
        private TextBox txtIlanBasligi;
        private TextBox txtYakitTuru;
        private TextBox txtSeriNumarasi;
        private TextBox txtIlanNumarasi;
        private TextBox txtKasaTipi;
        private TextBox txtRenk;
        private TextBox txtVites;
        private TextBox txtAracMarkasi;
        private TextBox txtAracModeli;
        private ComboBox cmbDurumu;
        private ComboBox cmbKimden;
        private TextBox txtKilometre;
        private TextBox txtYil;
        private TextBox txtFiyat;
        private TextBox txtIlIlce;
        private TextBox txtAracBilgi;
        private Button İlanKaydet;
        private Button ilankapat;
        private Label İlanekleme;
        private Label Sayfakapat;
        private GroupBox Resim;
        private PictureBox aracresim;
        private LinkLabel Linkkaldir;
        private LinkLabel Linkekle;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private GroupBox Bilgi;
        private NotifyIcon notifyIcon1;
    }
}