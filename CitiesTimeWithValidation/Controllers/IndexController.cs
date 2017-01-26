using CitiesTimeWithValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CitiesTimeWithValidation.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            CitiesDB cities = new CitiesDB();
            return View(cities);
        }

        [HttpPost]
        public ActionResult Index(CitiesDB cities)
        {
            return View(cities);
        }
    }
}