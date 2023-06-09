using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitirmeProjesi.Models.Siniflar;

namespace BitirmeProjesi.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Haberler.ToList();
            return View(degerler);
        }
        public ActionResult Kategori()
        {
            var k = c.Kategoriler.ToList();
            return View(k);
        }
        [HttpGet]
        public ActionResult YeniHaber()
        {
         
            return View();


        }
        [HttpPost]
        public ActionResult YeniHaber(haberler h)
        {
            if (h.kategoriId <= 6)
            {
                c.Haberler.Add(h);
                c.SaveChanges();
                return RedirectToAction("Index");
            }

            else { return View(); }
        }
        public ActionResult HaberSil(int id)
        {
            var b = c.Haberler.Find(id);
            c.Haberler.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult HaberiBul(int id)
        {
            var b1 = c.Haberler.Find(id);
            return View("HaberiBul", b1);
        }
        public ActionResult HaberGuncelle(haberler h)
        {
            var hbr = c.Haberler.Find(h.ID);
            hbr.icerik = h.icerik;
            hbr.Tarih = h.Tarih;
            hbr.FotoUrl = h.FotoUrl;
            hbr.Baslik = h.Baslik;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YorumListele()
        {
            var yorumlar = c.Yorumlar.ToList();
            return View(yorumlar);

        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlar.Find(id);
            c.Yorumlar.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListele");
        }

        public ActionResult YorumBul(int id)
        {
            var yrm = c.Yorumlar.Find(id);
            return View("YorumBul", yrm);
        }
        public ActionResult YorumGuncelle(yorum y)
        {
            var yr= c.Yorumlar.Find(y.ID);
            yr.acıklama =y.acıklama;
           
            c.SaveChanges();
            return RedirectToAction("YorumListele");

        }
        public ActionResult SikayetListele()
        {
            var sikayetler = c.Sikayets.ToList();
            return View(sikayetler);

        }
        public ActionResult SikayetSil(int id)
        {
            var b = c.Sikayets.Find(id);
            c.Sikayets.Remove(b);
            c.SaveChanges();
            return RedirectToAction("SikayetListele");
        }



    }
}