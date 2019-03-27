using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using AnimalRegistration.Models;

namespace AnimalRegistration.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Animal()
        {
           
            return View();


        }


        public ActionResult Birds()
        {

            
            return View();


        }

        public ActionResult Mammals()
        {
            ViewBag.Message = "about the animal page.";

            return View();
        }

        public ActionResult AnimalFacts()
        {
            ViewBag.Message = "animal fact page.";
            animal an = new animal();
            
            an.Aname = "Lion";
            an.AType = "Mammal";
            an.Pop = 2500;
            an.ADietry = "Carnivore";
            return View("Animal", an);
        }
    }
}