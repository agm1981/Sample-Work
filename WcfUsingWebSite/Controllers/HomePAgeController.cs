using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Web.Http;
using WcfContracts;

namespace WcfUsingWebSite.Controllers
{
    public class HomePageController : ApiController
    {
        [Route("api/GetDropDown")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetDrowdownValues()
        {
            // here we connect to the other side WCF and return the value
            ChannelFactory<IPaymentService> channelFactory = new ChannelFactory<IPaymentService>("ApitoWCF");
            IPaymentService paymentRequest = channelFactory.CreateChannel();
            var asd = paymentRequest.GetDropDown();
            return Ok(asd);

        }
    }
}
