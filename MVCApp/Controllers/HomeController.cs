using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.DataAccess.SQLData;
using static DataLibrary.DataAccess.JsonData;
using Newtonsoft.Json;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Prikaz liste proizvoda iz baze
        public ActionResult ProductList()
        {
            ViewBag.Message = "List of products";

            var data = ShowProducts();
            List<ProizvodModel> proizvodi = new List<ProizvodModel>();

            foreach (var item in data)
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

        //Prikaz liste proizvoda iz JSON file-a
        public ActionResult ProductListJson()
        {
            ViewBag.Message = "List of products";

            var json = GetJson();
            var proizvodi = JsonConvert.DeserializeObject<RootObject>(json);

            return View(proizvodi.Proizvodi);
        }

        //Dodavaje novog proizvoda
        public ActionResult AddProduct()
        {
            ViewBag.Message = "Add product to list";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(ProizvodModel model)
        {
            if (ModelState.IsValid)
            {
                int dataCreated = CreateProduct(model.Naziv, model.Opis, model.Kategorija,
                    model.Proizvodjac, model.Dobavljac, model.Cena);

                return RedirectToAction("Index");
            }

            return View();
        }

        //Izmena proizvoda
        public ActionResult EditProduct()
        {
            ViewBag.Message = "Edit product from list";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(ProizvodModel model)
        {
            if (ModelState.IsValid)
            {
                int dataUpdated = UpdateProduct(model.Naziv, model.Opis, model.Kategorija,
                    model.Proizvodjac, model.Dobavljac, model.Cena);

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}