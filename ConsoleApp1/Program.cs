using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Api'den veri çekmek için;

            var data = JsonClass.RequestAPI_2();

            Console.WriteLine(data);


            /*----------------------------------------------------------*/
            Console.WriteLine("\r\n\n");
            /*----------------------------------------------------------*/


            // Api'ye veri göndermek

            var dataResponse = JsonClass.SendRequestAPI_POST(); // post yöntemi ile veri gönderme

            Console.WriteLine($"Post -> {dataResponse}");


            /*----------------------------------------------------------*/
            Console.WriteLine("\r\n\n");
            /*----------------------------------------------------------*/


            // Api'ye veri göndermek

            var dataResponseGet = JsonClass.SendRequestAPI_GET(); // get yöntemi ile veri gönderme

            Console.WriteLine($"Get -> {dataResponseGet}");


            Console.Read();
        }
    }
}