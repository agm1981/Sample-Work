using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WcfContracts;

namespace WcfServerWrapper
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PaymentService" in both code and config file together.
    public class PaymentService : IPaymentService
    {
        public void DoWork()
        {
        }

        public int ApplyPayment()
        {
            //create a factory and apply payment
            return 3;
        }

        public int ApplyVoid()
        {
            //create a factory and apply Void
            return 1;

        }

        public int ApplyRefund()
        {
            //create a factory and apply payment
            return 2;
        }

        public ComplexJsonObject GetInformation(string value)
        {
            

            return new ComplexJsonObject
                   {
                       Name = value,
                       Value = value

                   };

        }

        public WrapperObject PutInformation(ComplexJsonObject value)
        {
            if (value == null)
            {
                return new WrapperObject("0");
            }
            return new WrapperObject((value.Name.GetHashCode() * value.Value.GetHashCode()).ToString(CultureInfo.InvariantCulture));
        }
    }

    
}
