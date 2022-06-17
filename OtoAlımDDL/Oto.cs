using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OtoAlımDDL
{
    public class Oto
    {
        [XmlIgnore]
        [JsonIgnore]
        public Guid ID { get; set; }
        public DateTime IlanTarihi { get; set; }
        public string IlanBasligi { get; set; }
        public string IlanNumarasi { get; set; }
        public string AracMarkasi { get; set; }
        public string AracModeli { get; set; }
        public string SeriNumarasi { get; set; }
        public string YakitTuru { get; set; }
        public string Vites { get; set; }
        public string Durumu { get; set; }
        public string Renk { get; set; }
        public string Yil { get; set; }
        public string Kimden { get; set; }
        public string Kilometre { get; set; }
        public string KasaTipi{ get; set; }
        public string Fiyat { get; set; }
        public string IlIlce { get; set; }
        public string Resim { get; set; }
        public string Bilgi { get; set; }
    }
    public static class Araclar
    {
        public static List<Oto> Otomobiller = new List<Oto>();
    }
}
