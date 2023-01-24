using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using arabaSizin.Models;

namespace arabaSizin.Controllers
{
    public class IlanController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Ilan
        public ActionResult Index()
        {
            var userName = User.Identity.Name;

            var ilans = db.Ilans.Where(i => i.userName == userName).Include(i => i.Durum).Include(i => i.Model).Include(i => i.Sehir);
            return View(ilans.ToList());
        }

        public List<Marka> MarkaGetir() //
        {
            List<Marka> markalar = db.Markas.ToList();

            return markalar;
        }

        public ActionResult ModelGetir(int markaId)
        {
            List<Model> modeller = db.Models.Where(x => x.markaId == markaId).ToList();
            ViewBag.modellistesi = new SelectList(modeller, "modelId", "modelAd");

            return PartialView("ModelPartial");
        }

        // GET: Ilan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilan ilan = db.Ilans.Find(id);
            if (ilan == null)
            {
                return HttpNotFound();
            }
            return View(ilan);
        }

        // GET: Ilan/Create
        public ActionResult Create()    // 
        {
            ViewBag.markalist = new SelectList(MarkaGetir(), "markaId", "markaAd");

            ViewBag.durumId = new SelectList(db.Durums, "durumId", "durumAd");
            ViewBag.sehirId = new SelectList(db.Sehirs, "sehirId", "sehirAd");
            return View();
        }

        public ActionResult Images(int id)
        {
            var ilan = db.Ilans.Where(i => i.ilanId == id).ToList();
            var img = db.Resims.Where(i => i.ilanId == id).ToList();
            ViewBag.img = img;
            ViewBag.ilan = ilan;

            return View();
        }

        [HttpPost]
        public ActionResult Images(int id, HttpPostedFileBase file)
        {
            string path = Path.Combine("/Content/images/" + file.FileName);
            file.SaveAs(Server.MapPath(path));
            Resim rsm = new Resim();
            rsm.resimAd = file.FileName.ToString();
            rsm.ilanId = id;
            db.Resims.Add(rsm);
            db.SaveChanges();   

            return RedirectToAction("Index");
        }

        // POST: Ilan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ilanId,ilanNo,aciklama,fiyat,tarih,kilometre,modelYili,yakitTuru,vitesTuru,userName,telefon,durumId,markaId,modelId,sehirId")] Ilan ilan)
        {
            if (ModelState.IsValid)
            {
                ilan.userName = User.Identity.Name;

                db.Ilans.Add(ilan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.durumId = new SelectList(db.Durums, "durumId", "durumAd", ilan.durumId);
            ViewBag.markalist = new SelectList(MarkaGetir(), "markaId", "markaAd");
            ViewBag.sehirId = new SelectList(db.Sehirs, "sehirId", "sehirAd", ilan.sehirId);
            return View(ilan);
        }

        // GET: Ilan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilan ilan = db.Ilans.Find(id);
            if (ilan == null)
            {
                return HttpNotFound();
            }

            ViewBag.markalist = new SelectList(MarkaGetir(), "markaId", "markaAd");
            ViewBag.durumId = new SelectList(db.Durums, "durumId", "durumAd", ilan.durumId);
            ViewBag.modelId = new SelectList(db.Models, "modelId", "modelAd", ilan.modelId);
            ViewBag.sehirId = new SelectList(db.Sehirs, "sehirId", "sehirAd", ilan.sehirId);
            return View(ilan);
        }

        // POST: Ilan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ilanId,ilanNo,aciklama,fiyat,tarih,kilometre,modelYili,yakitTuru,vitesTuru,userName,telefon,durumId,markaId,modelId,sehirId")] Ilan ilan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ilan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.durumId = new SelectList(db.Durums, "durumId", "durumAd", ilan.durumId);
            ViewBag.markalist = new SelectList(MarkaGetir(), "markaId", "markaAd");
            ViewBag.sehirId = new SelectList(db.Sehirs, "sehirId", "sehirAd", ilan.sehirId);
            return View(ilan);
        }

        // GET: Ilan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilan ilan = db.Ilans.Find(id);
            if (ilan == null)
            {
                return HttpNotFound();
            }
            return View(ilan);
        }

        // POST: Ilan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ilan ilan = db.Ilans.Find(id);
            db.Ilans.Remove(ilan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
