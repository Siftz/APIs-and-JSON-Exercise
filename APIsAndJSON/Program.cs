using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*//Exercise 1 notes from class
            
            // create an instance of a class called "HTTPCLient", this is what is used to call the api 
            
            var client = new HttpClient();
            
            // build an api url
            var kanyeUrl = "https://api.kanye.rest/";
            
            // using the HttpCLient instance send a GET request to the url created.

            var kanyeResponseJson = client.GetStringAsync(kanyeUrl).Result;
            
            // parse the Json response string into Jobject, allows access to certain parts of the Json (converts it to object)
            
            //var kanyeQuote = JObject.Parse(kanyeResponseJson)["quote"].ToString();
            var kanyeQuote = JObject.Parse(kanyeResponseJson).GetValue("quote").ToString();
            
            Console.WriteLine(kanyeQuote);*/
            
            // calling from RonVSKanye  API class
            var api = new RonVSKanyeAPI();
            for (int i = 0; i < 5; i++)
            {
                string ronQuote = api.GetRonQuote();
                string kanyeQuote = api.GetKanyeQuote();

                Console.WriteLine($"Ron Swanson; {ronQuote}");
                Console.WriteLine($"Kanye West; {kanyeQuote}");
                Console.WriteLine(); // blank line
            }
          


        }
    }
}
