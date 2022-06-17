namespace OtoOtomasyonu
{
    partial class OtoBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtoBilgi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iLanEkle = new System.Windows.Forms.ToolStripButton();
            this.İlanDüzenle = new System.Windows.Forms.ToolStripButton();
            this.İlanSil = new System.Windows.Forms.ToolStripButton();
            this.dosyakaydet = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLanEkle,
            this.İlanDüzenle,
            this.İlanSil,
            this.dosyakaydet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // iLanEkle
            // 
            this.iLanEkle.Image = ((System.Drawing.Image)(resources.GetObject("iLanEkle.Image")));
            this.iLanEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iLanEkle.Name = "iLanEkle";
            this.iLanEkle.Size = new System.Drawing.Size(88, 24);
            this.iLanEkle.Text = "İlan Ekle";
            this.iLanEkle.Click += new System.EventHandler(this.iLanEkle_Click);
            // 
            // İlanDüzenle
            // 
            this.İlanDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("İlanDüzenle.Image")));
            this.İlanDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.İlanDüzenle.Name = "İlanDüzenle";
            this.İlanDüzenle.Size = new System.Drawing.Size(115, 24);
            this.İlanDüzenle.Text = "İlan Düzenle";
            this.İlanDüzenle.Click += new System.EventHandler(this.IlanDuzenle_Click);
            // 
            // İlanSil
            // 
            this.İlanSil.Image = ((System.Drawing.Image)(resources.GetObject("İlanSil.Image")));
            this.İlanSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.İlanSil.Name = "İlanSil";
            this.İlanSil.Size = new System.Drawing.Size(77, 24);
            this.İlanSil.Text = "İlan Sil";
            this.İlanSil.Click += new System.EventHandler(this.IlanSil_Click);
            // 
            // dosyakaydet
            // 
            this.dosyakaydet.Image = ((System.Drawing.Image)(resources.GetObject("dosyakaydet.Image")));
            this.dosyakaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dosyakaydet.Name = "dosyakaydet";
            this.dosyakaydet.Size = new System.Drawing.Size(135, 24);
            this.dosyakaydet.Text = "Dosyayı Kaydet";
            this.dosyakaydet.Click += new System.EventHandler(this.dosyakaydet_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.LabelEdit = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(0, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Scrollable = false;
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1020, 481);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İlan Tarihi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Markası";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Araç Modeli";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yıl";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Renk";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kimden";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İl/İlçe";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(858, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 240);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 273);
            this.textBox1.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Json dosyası|*.json|Xml dosyası|*.xml|Csv dosyası|*.csv|binary dosya|*.bin";
            // 
            // OtoBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OtoBilgi";
            this.Text = "OtoBilgi";
            this.Load += new System.EventHandler(this.OtoBilgi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton İlanEkle;
        private ToolStripButton dosyakaydet;
        private ToolStripButton İlanE;
        private ToolStripButton İlanDüzenle;
        private ToolStripButton İlanSil;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton iLanEkle;
    }
}