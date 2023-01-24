using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace arabaSizin.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var sehirler = new List<Sehir>()
            {
                new Sehir() { sehirAd = "İSTANBUL" },
                new Sehir() { sehirAd = "ANKARA" },
                new Sehir() { sehirAd = "İZMİR" }
            };

            foreach (var sehir in sehirler)
            {
                context.Sehirs.Add(sehir);
            }

            context.SaveChanges();

            var durumlar = new List<Durum>()
            {
                new Durum() { durumAd = "KİRALIK" },
                new Durum() { durumAd = "SATILIK" }
            };

            foreach (var durum in durumlar)
            {
                context.Durums.Add(durum);
            }

            context.SaveChanges();

            var markalar = new List<Marka>()
            {
                new Marka() { markaAd = "ASTON MARTİN" },
                new Marka() { markaAd = "BENTLEY MULLİNER" },
                new Marka() { markaAd = "BUGATTİ" },
                new Marka() { markaAd = "POLESTAR" }
            };

            foreach (var marka in markalar)
            {
                context.Markas.Add(marka);
            }

            context.SaveChanges();

            var modeller = new List<Model>()
            {
                new Model() { modelAd = "Vantage V12", markaId = 1 },
                new Model() { modelAd = "Batur", markaId = 2 },
                new Model() { modelAd = "Chiron Super Sport", markaId = 3 },
                new Model() { modelAd = "Veyron EB", markaId = 3 },
            };

            foreach (var model in modeller)
            {
                context.Models.Add(model);
            }

            context.SaveChanges();

            var ilanlar = new List<Ilan>()
            {
                new Ilan() { markaId = 1, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 5, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
                new Ilan() { markaId = 2, aciklama = "Sıfır araba", ilanNo = "A002", fiyat = 40500000, tarih = "01/01/2023", kilometre = 0, modelYili = 2023,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 2, modelId = 6, userName = "samilyildirim", sehirId = 2, telefon = "212121212"},
                new Ilan() { markaId = 3, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 7, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
                new Ilan() { markaId = 5, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 9, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
                new Ilan() { markaId = 6, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 10, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
                new Ilan() { markaId = 7, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 11, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
                new Ilan() { markaId = 8, aciklama = "Temiz araba", ilanNo = "A001", fiyat = 2500, tarih = "17/01/2023", kilometre = 60500, modelYili = 2012,
                             yakitTuru = "Benzin", vitesTuru = "Otomatik", durumId = 1, modelId = 12, userName = "atakanturgut", sehirId = 1, telefon = "212122323"},
            };

            foreach (var ilan in ilanlar)
            {
                context.Ilans.Add(ilan);
            }

            context.SaveChanges();

            var resimler = new List<Resim>()
            {
                new Resim() { resimAd = "Aston Martin Vantage V12 Zagato 2012.jpg", ilanId = 1 },
                new Resim() { resimAd = "Aston Martin Vantage inside.jpg", ilanId = 1 },
                new Resim() { resimAd = "Bentley Mulliner Batur 2023.jpg", ilanId = 2 },
                new Resim() { resimAd = "Bentley Mulliner Batur inside.jpg", ilanId = 2 }
            };

            foreach (var resim in resimler)
            {
                context.Resims.Add(resim);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}