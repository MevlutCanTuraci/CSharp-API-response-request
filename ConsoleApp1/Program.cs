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

            var data = JsonClass.RequestAPI();

            Console.WriteLine(data);


            /*----------------------------------------------------------*/
            Console.WriteLine("\r\n\n");
            /*----------------------------------------------------------*/


            // Api'ye veri göndermek

            var dataResponse = JsonClass.SendRequestAPI();

            Console.WriteLine(dataResponse);


            Console.Read();
        }
    }
}