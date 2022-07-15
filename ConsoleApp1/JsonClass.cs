using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    public static class JsonClass
    {
        public static string RequestAPI_1()
        {
            string gelenJson = "";

            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://api.agify.io/?name=michael&country_id=us"); //URI  

                gelenJson = result.ToString();

            }

            var parcala = JObject.Parse(gelenJson);

            //Console.WriteLine($"gelen isim : {parcala["name"]}\n\rgelen yaş : {parcala["age"]}\n\rgelen count : {parcala["count"]}");

            return $"gelen isim : {parcala["name"]}\n\rgelen yaş : {parcala["age"]}\n\rgelen count : {parcala["count"]}";
        }

        public static string RequestAPI_2()
        {
            string URI = "https://api.agify.io/?name=michael&country_id=us";

            string gelenJson = "";

            using (WebClient client = new WebClient())
            {
                var pagesource = client.DownloadString(URI);
                Console.WriteLine(pagesource);
                gelenJson = pagesource;
            }

            var parcala = JObject.Parse(gelenJson);

            //Console.WriteLine($"gelen isim : {parcala["name"]}\n\rgelen yaş : {parcala["age"]}\n\rgelen count : {parcala["count"]}");

            return $"gelen isim : {parcala["name"]}\n\rgelen yaş : {parcala["age"]}\n\rgelen count : {parcala["count"]}";
        }

        public static string SendRequestAPI_GET()
        {
            string name = "Mevlut", age = "19";

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                var result = client.UploadString($"http://localhost/yukle.php?name={name}&age={age}", "GET");

                //Console.WriteLine("Gelen respose json'u : " + result);

                return $"Gelen respose json'u : {result}";
            }

        }

        public static string SendRequestAPI_POST()
        {
            string URI = "http://localhost/yukle.php";

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData =
                new NameValueCollection()
                {
                  { "name", "mev" },
                  { "age", "19"}
                };

                string pagesource = Encoding.UTF8.GetString(client.UploadValues(URI, postData));

                return $"Gelen respose json'u : {pagesource}";

            }

        }
    }
}