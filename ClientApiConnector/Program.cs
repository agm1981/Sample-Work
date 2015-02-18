using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using WcfContracts;

namespace ClientApiConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3698/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new  MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/GetInformation/34343");
                if (response.IsSuccessStatusCode)
                {

                    ComplexJsonObject product = await response.Content.ReadAsAsync<ComplexJsonObject>();
                    Console.WriteLine("{0}", product);
                }
            }
            Console.WriteLine("re");
            Console.ReadLine();
        }
    }
}
