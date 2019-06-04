using Pazzo_test.Models;
using System.Web.Mvc;

namespace Pazzo_test.Utility
{
    public class BaseController : Controller
    {
        protected NorthwindEntities db = null;
        public BaseController()
        {
            db = (NorthwindEntities)System.Web.HttpContext.Current.Items["db"];
        }
    }
}