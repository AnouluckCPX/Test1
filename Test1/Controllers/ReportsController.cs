using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;
using Test1.Models;

namespace Test1.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Stock()
        {
            var result = new ReportStockModel();

            var application = new ApplicationDbContext();
            var db = new PharmacyEntities();
            var users = application.Users.ToList();
            var products = db.Products.ToList();

            result.Users = users;
            result.Products = products;
            return View(result);
        }

        [HttpPost]
        public ActionResult Stock(string User, string StartDate, string EndDate, string Product)
        {
            var result = new ReportStockModel();

            var application = new ApplicationDbContext();
            var db = new PharmacyEntities();
            var users = application.Users.ToList(); 
            var products = db.Products.ToList();

            result.Users = users;
            result.Products = products;

                 

            return View(result);
        }
    }


}