using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    public static class JsonClass
    {
        public static string RequestAPI()
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

        public static string SendRequestAPI()
        {
            string name = "Mevlut", age = "19";

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                
                var result = client.UploadString($"http://localhost/yukle.php?name={name}&age={age}", "");
                
                //Console.WriteLine("Gelen respose json'u : " + result);

                return $"Gelen respose json'u : {result}";
            }

        }
    }
}
