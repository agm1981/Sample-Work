using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfMetadata.PaymentServiceWcf;

namespace WcfMetadata
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();

            
        }

        private static async Task RunAsync()
        {
            ChannelFactory<IPaymentService> channelFactory = new ChannelFactory<IPaymentService>("BasicBinding3698");
            IPaymentService paymentRequest = channelFactory.CreateChannel();

            int t = await paymentRequest.ApplyPaymentAsync();
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
