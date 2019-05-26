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

        // GET: Customers
        public ActionResult Index()
        {
            var result = db.Customers.ToList();
            return View(result);
        }
    }
}