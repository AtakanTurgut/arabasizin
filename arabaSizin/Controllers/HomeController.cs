using arabaSizin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;
using PagedList.Mvc;

namespace arabaSizin.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index(int sayi=1)
        {
            var ilan = db.Ilans.Include(m => m.Model).ToList().ToPagedList(sayi, 3);
            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;

            return View(ilan);
        }

        public ActionResult MenuFilter(int id)
        {
            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;

            var filter = db.Ilans.Where(d => d.durumId == id).Include(m => m.Model).Include(m => m.Sehir).Include(m => m.Durum).ToList();

            return View(filter);
        }

        public ActionResult Filter(int min, int max, int sehirId, int durumId, int markaId, int modelId)
        {
            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;

            var filter = db.Ilans.Where(i => i.fiyat >= min && i.fiyat <= max && i.sehirId == sehirId
                                        && i.durumId == durumId && i.markaId == markaId && i.modelId == modelId)
                                        .Include(m => m.Model).Include(m => m.Durum).Include(m => m.Sehir).ToList();
            return View(filter);
        }

        public PartialViewResult PartialFilter()
        {
            ViewBag.markalist = new SelectList(MarkaGetir(), "markaId", "markaAd");

            ViewBag.durumId = new SelectList(db.Durums, "durumId", "durumAd");
            ViewBag.sehirId = new SelectList(db.Sehirs, "sehirId", "sehirAd");
            return PartialView();
        }

        public List<Marka> MarkaGetir() //
        {
            List<Marka> markalar = db.Markas.ToList();

            return markalar;
        }

        public ActionResult ModelGetir(int markaId)
        {
            List<Model> modellist = db.Models.Where(x => x.markaId == markaId).ToList();
            ViewBag.modellistesi = new SelectList(modellist, "modelId", "modelAd");

            return PartialView("ModelPartial");
        }

        public ActionResult Search(string q)
        {
            var img = db.Resims.ToList();
            ViewBag.imgs = img;
            var ara = db.Ilans.Include(m => m.Model);
            if (!String.IsNullOrEmpty(q))
            {
                ara = ara.Where(i => i.aciklama.Contains(q) || i.Model.modelAd.Contains(q));
            }

            return View(ara.ToList());
        }

        public ActionResult Detay(int id)
        {
            var ilan = db.Ilans.Where(i => i.ilanId == id).Include(m => m.Model).Include(d => d.Durum).Include(s => s.Sehir).FirstOrDefault();
            var imgs = db.Resims.Where(i => i.ilanId == id).ToList();
            ViewBag.imgs = imgs;

            return View(ilan);
        }

        public PartialViewResult Slider()
        {
            var ilan = db.Ilans.ToList().Take(5);
            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;

            return PartialView(ilan);
        }
    }
}