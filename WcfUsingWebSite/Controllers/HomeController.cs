using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfContracts;

namespace WcfUsingWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ComplexJsonObject startignVlaue = new ComplexJsonObject
                                              {
                                                  
                                              };
            return View("Index", startignVlaue);
        }
    }
}
