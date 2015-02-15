using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfContracts;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IPaymentService> channelFactory = new ChannelFactory<IPaymentService>("ClientConf");
            IPaymentService paymentRequest =  channelFactory.CreateChannel();
            
            Console.WriteLine(paymentRequest.ApplyPayment());
            Console.ReadLine();
        }
    }
}
