using seldin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seldin.Controllers
{
    public class ApartmentController : Controller
    {
        // GET: Apartment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewApartment(int id)
        {
            var apartment = new Apartment();
            var apartments = apartment.GetApartments();
            var models = apartments.Where(x => x.Id == id).FirstOrDefault();

            ViewBag.Models = models;

            return View(models);
        }

    }
}