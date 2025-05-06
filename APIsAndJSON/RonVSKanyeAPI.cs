using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public string GetRonQuote()
        {
            var client = new HttpClient(); // declare httpclient
            string ronResponse = client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;
            //dispose after the request to keep connection less cluttered
            client.Dispose();
            return JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            
        }

        public string GetKanyeQuote()
        {
            var client = new HttpClient(); // new instance for requests
            string kanyeResponse = client.GetStringAsync("https://api.kanye.rest/").Result;
            client.Dispose(); // dispose after request 
            return JObject.Parse(kanyeResponse)["quote"].ToString();
        }
        
        
    }
}
