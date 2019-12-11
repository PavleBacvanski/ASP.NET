using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.DataAccess.SQLData;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductList()
        {
            ViewBag.Message = "List of products";

            var data = ShowProducts();
            List<ProizvodModel> proizvodi = new List<ProizvodModel>();

            foreach(var item in data)
            {
                proizvodi.Add(new ProizvodModel
                {
                    Naziv = item.Naziv,
                    Opis = item.Opis,
                    Kategorija = item.Kategorija,
                    Proizvodjac = item.Proizvodjac,
                    Dobavljac = item.Dobavljac,
                    Cena = item.Cena
                });
            }

            return View(proizvodi);
        }

    }
}