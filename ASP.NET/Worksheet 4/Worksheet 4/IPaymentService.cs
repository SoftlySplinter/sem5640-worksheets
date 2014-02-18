using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Worksheet_4
{
    [ServiceContract(Namespace = "http://users.aber.ac.uk/m5640/paymentprocessor")]
    public interface IPaymentService
    {
        [OperationContract]
        string ProcessPayment(PaymentDetails paymentDetails);
    }
}
