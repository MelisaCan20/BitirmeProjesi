using BitirmeProjesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace BitirmeProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(admin ad)
         
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullanıcıAdı == ad.kullanıcıAdı && x.sifre == ad.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullanıcıAdı, false);
                Session["kullancıAdı"] = bilgiler.kullanıcıAdı.ToString();
                return RedirectToAction("Index", "AdminPanel");

            }
            else { return View(); }
           

        }

        public ActionResult UyeLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeLogin(uye u)

        {
           
            var bilgiler = c.Uyeler.FirstOrDefault(x => x.Adı == u.Adı && x.sifre == u.sifre);
           

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Adı, false);
                Session["kullancıAdı"] = bilgiler.Adı.ToString();
                // var id = bilgiler.ID;
                // var a=id.ToString();
                uye data = new uye()
                {
                    ID = bilgiler.ID,
                    Adı=bilgiler.Adı,

                    
                };

                string url = string.Format("/Uye/Index?ID={0}&Adı={1}",
               data.ID,data.Adı);
                return Redirect(url);

               // return RedirectToAction("In", "Uye",data);
                

            }
            else { return View(); }

        }
      
         
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");


        }
        public ActionResult UyeLogout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("UyeLogin", "Login");


        }
    }
}