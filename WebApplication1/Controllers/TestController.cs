using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        private readonly SirketDbContext _db;

        public TestController(SirketDbContext db)
        {
            _db = db;
        }
        public IActionResult BirinciSayfa()
        {
            return View();
        }

        public IActionResult İkinciSayfa()
        {
            return View("BirinciSayfa");
        }

        public IActionResult ÜcüncüSayfa()
        {
            return View();
        }

        public IActionResult RazorOrnek()
        {
            return View();
        }

        public IActionResult HtmlOrnek()
        {
            return View();
        }

       // public IActionResult FormOrnek => View();

        //public IActionResult FormOrnek()
        //{
        //    if (Request.Method == "POST")
        //    {
        //        //adsoyad ve doğum bilgilerini al
        //        var adsoyad = Request.Form["adsoyad"];
        //        var dogum = DateTime.Parse(Request.Form["dogum"]);

        //        //bu bilgileri db'ye kaydet
        //    }
        //    else
        //        return View();

            [HttpGet]
            public IActionResult FormOrnek()
            {
                return View();
            }

            [HttpPost]
            public IActionResult FormOrnek(string adsoyad, DateTime dogum)
            {
                // return RedirectToAction("BirinciSayfa");

                ViewBag.adsoyad = adsoyad; //viewData
                ViewBag.Dogum = dogum;
                return View();
            }

            [HttpGet]
        public IActionResult FormOrnek2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormOrnek2(string adsoyad, DateTime dogum)
        {
            // return RedirectToAction("BirinciSayfa");
            Personel p = new Personel
            {
                Adsoyad = adsoyad,
                Dogum = dogum
            };
            return View(p);

            ViewBag.adsoyad = adsoyad; //viewData
            ViewBag.Dogum = dogum;
            return View();
        }


        [HttpGet]
        public IActionResult FormOrnek3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormOrnek3([Bind("AdSoyad,Doğum")]Personel personel)
        {
            if(ModelState.IsValid)
            {
                //Bu bilgileri db'ye kaydet
                //Db'ye kayıt ettikten sonra başka sayfaya yönlendirebilirim
                //return RedirectToAction("BirinciSayfa");
                _db.Add(personel);
                _db.SaveChanges();
                //return RedirectToAction(nameof(BirinciSayfa));//kayıt başarılıysa birincisayfaya git
                return RedirectToAction(nameof(Index),"Personels");
            }
            // return RedirectToAction("BirinciSayfa");
           
            return View(personel);
        }
    }
}
