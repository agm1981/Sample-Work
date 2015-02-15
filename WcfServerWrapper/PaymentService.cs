using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
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
    }
}
