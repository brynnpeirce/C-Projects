using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();


        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }
    }
}