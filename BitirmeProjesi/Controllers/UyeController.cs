using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using BitirmeProjesi.Models.Siniflar;


namespace BitirmeProjesi.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        Context c = new Context();
       
        public ActionResult Index()
        {

            uye data = new uye();
            data.ID = int.Parse(Request.QueryString["ID"]);
          
           ViewBag.deger = data.ID;
            
            
         
            return View();
        }
        public PartialViewResult SonHaber()
        {
            var sonhaber = c.Haberler.OrderByDescending(x => x.ID).Take(3).ToList();
            ViewBag.first = sonhaber[0].ID;
            return PartialView(sonhaber);
        }
        [HttpGet]
        public ActionResult KayıtForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayıtForm(uye u)
        {
            c.Uyeler.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index","Default");
           
        }

        public ActionResult Haber ()
        {
           
            return View();
        }
        public ActionResult HaberDetay(int id)
        {
            var hy = c.Haberler.Where(x=>x.ID==id).ToList();
          
            return View(hy);
        } 
       public ActionResult Milanos()
        {
            var hy = c.Haberler.Where(x => x.Kategori.ID == 1).ToList();
            return View(hy);
        }
        public ActionResult Istanbul()
        {
            var hy = c.Haberler.Where(x => x.Kategori.ID == 2).ToList();
            return View(hy);
        }
        public ActionResult Roma()
        {
            var hy = c.Haberler.Where(x => x.Kategori.ID == 3).ToList();
            return View(hy);
        }



        public PartialViewResult PartialView1(int id) {


           var hy = c.Yorumlar.Where(x => x.HaberId == id).ToList();
            return PartialView(hy);
        }
        [HttpGet]
        public PartialViewResult PartialYorum(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialYorum(yorum yr)
        {
            c.Yorumlar.Add(yr);
            c.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public ActionResult SikayetKutusu(int id)
        {
            ViewBag.d = id;

            return View();

        }
        [HttpPost]
        public ActionResult SikayetKutusu(Sikayet s)
        {
            c.Sikayets.Add(s);
            c.SaveChanges();
            return View();
           
        }



    }
}