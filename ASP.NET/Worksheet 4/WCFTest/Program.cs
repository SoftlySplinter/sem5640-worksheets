using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFTest.Payments;

namespace WCFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentDetails details = new PaymentDetails();
            details.Name = "Neil Taylor";
            details.Address = new Address();
            details.Address.HouseName = "Test";
            details.CreditCardNumber = "1234";

            PaymentServiceClient client = new PaymentServiceClient();
            string result = client.ProcessPayment(details);

            Console.WriteLine("Result Is: " + result);
            Console.ReadLine();
        }
    }
}
