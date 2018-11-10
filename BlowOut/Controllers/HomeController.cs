using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Trumpet()
        {
            ViewBag.Image = "/Content/trumpet.jpg";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Trumpet";
            return View("Instrument");
        }

        public ActionResult Trombone()
        {
            ViewBag.Image = "/Content/trombone.jpg";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Trombone";
            return View("Instrument");
        }

        public ActionResult Tuba()
        {
            ViewBag.Image = "/Content/tuba.jpg";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Tuba";
            return View("Instrument");
        }

        public ActionResult Flute()
        {
            ViewBag.Image = "/Content/flute.jpg";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Flute";
            return View("Instrument");
        }

        public ActionResult Clarinet()
        {
            ViewBag.Image = "/Content/clarinet.jpg";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Clarinet";
            return View("Instrument");
        }

        public ActionResult Saxophone()
        {
            ViewBag.Image = "/Content/saxophone.png";
            ViewBag.usedCost = "$25";
            ViewBag.newCost = "$55";
            ViewBag.Name = "Saxophone";
            return View("Instrument");
        }
    }
}