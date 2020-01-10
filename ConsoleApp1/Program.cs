using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = IMSPaymentService.Helper.GetClient(@"https://countyprocessing.com/paymentAPI/service/", "testing", "testing");
            var resp = client.getPaymentForm("b7243b35-b07b-404f-a90c-ec880cb79f32", 123.45f, "");
            Console.WriteLine(resp);
            Console.ReadLine();
        }
    }
}
