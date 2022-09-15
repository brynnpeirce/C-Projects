using CarInsurance2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Admin()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insuree = new List<Insuree>();
                foreach(var x in insurees)
                {
                    var insureess = new Insuree();
                    insureess.FirstName = x.FirstName;
                    insureess.LastName = x.LastName;
                    insureess.Quote = x.Quote;
                    insuree.Add(x);
                }

                return View(insuree);
            }
           
        }

           
        

       
    }
}