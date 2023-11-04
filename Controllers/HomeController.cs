using CHC1.edmx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace CHC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(tblContactmemb x)
        {
            CHCEntities1 db = new CHCEntities1();
            db.spContact(x.FullName, x.Email, x.Phone, x.Message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Programs()
        {
            return View();
        }
        public ActionResult Program_details()
        {
            return View();
        }
        public ActionResult Program_details2()
        {
            return View();
        }
        public ActionResult Register()
        {
            


            ViewBag.Message = "Successfully Submitted";

            return View();
        }


        [HttpPost]
        public ActionResult Register(tblPrgmRegistration x)
        {
            CHCEntities1 db = new CHCEntities1();
            db.spRegister(x.Name, x.Email, x.Phone, x.AgeGroup, x.Country, x.City, x.Message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Hope_ministries()
        {
            return View();
        }
        public ActionResult Trainingprg()
        {
            return View();
        }
        public ActionResult Comunitycon()
        {
            return View();
        }
        public ActionResult spekerone()
        {
            return View();
        }
        public ActionResult spekertwo()
        {
            return View();
        }
        public ActionResult spekerthree()
        {
            return View();
        }
    }
}