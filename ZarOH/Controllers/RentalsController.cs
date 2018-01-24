using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZarOH.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult NewRentalForm()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}