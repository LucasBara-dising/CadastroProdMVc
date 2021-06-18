using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProdMVC01.Models;

namespace ProdMVC01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var prod = new Produto();
            return View(prod);
        }
        [HttpPost]

        public ActionResult Index(Produto prod)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", prod);
            }

            return View(prod);
        }

        public ActionResult Resultado(Produto prod)
        {
            return View(prod);
        }
    }
}