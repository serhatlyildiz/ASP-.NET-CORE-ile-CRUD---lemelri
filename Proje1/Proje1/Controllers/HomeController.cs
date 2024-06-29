using Microsoft.AspNetCore.Mvc;
using Proje1.Models;
using System.Collections.Generic;
using Proje1.Models;
using System.Runtime.InteropServices;

namespace Proje1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public int Index3()
        {
            return 81;
        }

        public string Index4()
        {
            return "Düzce";
        }

        public IActionResult Kitap()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap() { ID = 1, KitapAdi="C# Kitabı", Yazar="Sinan TOKLU"},
                new Kitap() { ID = 2, KitapAdi = "VB.NET Kitabı", Yazar = "Ayhan ERDEM" },
                new Kitap() { ID = 3, KitapAdi = "JS Kitabı", Yazar = "Mahmut EKREM" },
                new Kitap() { ID = 3, KitapAdi = "Öğrenci Olmak Kitabı", Yazar = "Serhat YILDIZ" }
            };

            return View(ktp);
        }

        public IActionResult Index5()
        {
            ViewBag.deg1 = "81 Nolu Plaka Düzceye aittir";
            ViewBag.deg2 = 6;

            return View();
        }

        public IActionResult Index6()
        {
            return View();
        }

        public IActionResult Index7()
        {
            return View();
        }

        public IActionResult Index8()
        {
            return View();
        }

        public IActionResult Index9()
        {
            return View();
        }
    }
}
