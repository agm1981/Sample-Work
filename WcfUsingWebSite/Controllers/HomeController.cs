using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WcfContracts;
using WcfUsingWebSite.Models;

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

        [AllowAnonymous]
        [HttpPost]
        [ActionName("SubmitToServer")]
        public ActionResult SubmitValues(ComplexJsonObject values)
        {
            // here we connect to the other side WCF and return the value
            ChannelFactory<IPaymentService> channelFactory = new ChannelFactory<IPaymentService>("ApitoWCF");
            IPaymentService paymentRequest = channelFactory.CreateChannel();
            WrapperObject asd = paymentRequest.PutInformation(values);
            PostResult rs = new PostResult();
            rs.Value = asd.Value;
            return PartialView("PostResultView", rs);
        }
    }
}
