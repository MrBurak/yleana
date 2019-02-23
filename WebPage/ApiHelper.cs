using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebPage
{
    public class ApiHelper
    {
        public  string GetRequest(string routing)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var apibaseurl= configuration.GetSection("ApiSettings:Url").Value;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apibaseurl + routing);
            request.Method = "Get";
            request.KeepAlive = true;
            request.ContentType = "appication/json";
            request.Headers.Add("Content-Type", "appication/json");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string myResponse = "";
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                myResponse = sr.ReadToEnd();
            }
            return myResponse;
        }
    }
}
