using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class Ilan
    {
        public int ilanId { get; set; }
        public string ilanNo { get; set; }
        public string aciklama { get; set; }
        public int fiyat { get; set; }
        public string tarih { get; set; }
        public int kilometre { get; set; }
        public int modelYili { get; set; }
        public string yakitTuru { get; set; }
        public string vitesTuru { get; set; }
        public string userName { get; set; }
        public string telefon { get; set; }

        public int durumId { get; set; }
        public Durum Durum { get; set; }

        public int markaId { get; set; }
        public int modelId { get; set; }
        public Model Model { get; set; }

        public int sehirId { get; set; }
        public Sehir Sehir { get; set; }

        public List<Resim> Resims { get; set; }

    }
}