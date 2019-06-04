using Pazzo_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pazzo_test.Controllers
{
    public class CustomersController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        //EF 快速開發
        // GET: Customers
        public ActionResult Index()
        {
            var result = db.Customers.ToList();

            //db.SaveChanges();
            return View(result);
        }

        public ActionResult Edit()
        {
            var result = db.Customers.ToList();

            //db.SaveChanges();
            return View(result);
        }
    }
}