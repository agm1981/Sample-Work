using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Runtime.Serialization.Json;
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

                ComplexJsonObject objToPost = new ComplexJsonObject
                                              {
                                                  Name = "asd",
                                                  Value = "fdfd"
                                              };

                //Now serialize the object inso json
                StringContent theContent = ConvertContent(objToPost);

                response = await client.PostAsync("api/PutInformation", theContent);
                if (response.IsSuccessStatusCode)
                {

                    WrapperObject product = await response.Content.ReadAsAsync<WrapperObject>();
                    Console.WriteLine("{0}", product.Value);
                }
            }
            Console.WriteLine("re");
            Console.ReadLine();
        }

        private static StringContent ConvertContent (ComplexJsonObject value)
        {
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(ComplexJsonObject));

            // use the serializer to write the object to a MemoryStream 
            MemoryStream ms = new MemoryStream();
            jsonSer.WriteObject(ms, value);
            ms.Position = 0;

            //use a Stream reader to construct the StringContent (Json) 
            StreamReader sr = new StreamReader(ms);
            // Note if the JSON is simple enough you could ignore the 5 lines above that do the serialization and construct it yourself 
            // then pass it as the first argument to the StringContent constructor 
            return new StringContent(sr.ReadToEnd(), Encoding.UTF8, "application/json"); 
}
    }
}
