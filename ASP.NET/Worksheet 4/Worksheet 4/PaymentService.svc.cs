using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Worksheet_4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PaymentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PaymentService.svc or PaymentService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace = "http://users.aber.ac.uk/m5640/paymentprocessor")]
    public class PaymentService : IPaymentService
    {

        public string ProcessPayment(PaymentDetails paymentDetails)
        {
            if (paymentDetails.CreditCardNumber == "1234")
            {
                return "PP1234";
            }

            return "Failure";
        }
    }
}
