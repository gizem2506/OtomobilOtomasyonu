using OtoAlımDDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace OtoOtomasyonu
{
    public partial class OtoBilgi : Form
    {
        public OtoBilgi()
        {
            InitializeComponent();
        }
        private void IlanDuzenle_Click(object sender, EventArgs e)
        {
                if (listView1.SelectedItems.Count == 0)
                    return;

                Oto otomobil = listView1.SelectedItems[0].Tag as Oto;
                Form1 form1 = new Form1()
                {
                    Text = "İlan Güncelle",
                };
                form1.OtoBilgileriniYükle(otomobil);

                if (form1.ShowDialog() == DialogResult.OK)
                {

                Oto oto = Araclar.Otomobiller.Find(x => x.ID == otomobil.ID);
                oto.IlanTarihi = form1.otomobil.IlanTarihi;
                oto.IlanBasligi = form1.otomobil.IlanBasligi;
                oto.IlanNumarasi = form1.otomobil.IlanNumarasi;
                oto.AracMarkasi = form1.otomobil.AracMarkasi;
                oto.AracModeli = form1.otomobil.AracModeli;
                oto.SeriNumarasi = form1.otomobil.SeriNumarasi;
                oto.YakitTuru = form1.otomobil.YakitTuru;
                oto.Vites = form1.otomobil.Vites;
                oto.Durumu = form1.otomobil.Durumu;
                oto.Renk = form1.otomobil.Renk;
                oto.Yil = form1.otomobil.Yil;
                oto.Kimden = form1.otomobil.Kimden;
                oto.Kilometre = form1.otomobil.Kilometre;
                oto.KasaTipi = form1.otomobil.KasaTipi;
                oto.Fiyat = form1.otomobil.Fiyat;
                oto.IlIlce = form1.otomobil.IlIlce;
                oto.Resim = form1.otomobil.Resim;


                ListeGuncelle();

                }
            
        }

        private void IlanSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (MessageBox.Show(
                "Silinsin mi",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
                return;

            Oto otomobil = listView1.SelectedItems[0].Tag as Oto;
            Oto oto = Araclar.Otomobiller.Find(x => x.ID == otomobil.ID);
            Araclar.Otomobiller.Remove(oto);

            ListeGuncelle();
        }
        private void dosyakaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya = saveFileDialog1.FileName;

                XmlSerializer xml = new XmlSerializer(typeof(List<Oto>));
                StreamWriter sw = new StreamWriter(dosya);
                xml.Serialize(sw, Araclar.Otomobiller);

                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }

        private void OtoBilgi_Load(object sender, EventArgs e)
        {

        }

        private void iLanEkle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1() { Text = "İlan Ekle" }; ;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                Araclar.Otomobiller.Add(form1.otomobil);

                ListeGuncelle();
            }
        }

        private void AracEkle(Oto otomobil)
        {
            ListViewItem k = new ListViewItem(new string[]
            {
                otomobil.IlanTarihi.ToString(),
                otomobil.AracMarkasi,
                otomobil.AracModeli,
                otomobil.Yil,
                otomobil.Renk,
                otomobil.Kimden,
                otomobil.IlIlce,
            });

            k.Tag = otomobil;
            listView1.Items.Add(k);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                pictureBox1.Image = null;
                textBox1.Text = "";
                return;
            }

            Oto otomobil = listView1.SelectedItems[0].Tag as Oto;
            if (!string.IsNullOrEmpty(otomobil.Resim))
                pictureBox1.Load(otomobil.Resim);
        }

        private void ListeGuncelle()
        {
            listView1.Items.Clear();
            foreach (var kişi in Araclar.Otomobiller)
            {
                AracEkle(kişi);
            }
        }
    }

}

