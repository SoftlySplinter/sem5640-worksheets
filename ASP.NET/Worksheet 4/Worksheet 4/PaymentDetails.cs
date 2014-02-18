using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Worksheet_4
{
    [DataContract(Namespace = "http://users.aber.ac.uk/m5640/paymentprocessor")]
    public class PaymentDetails
    {
        [DataMember]
        public string Name;

        [DataMember]
        public Address Address;

        [DataMember]
        public string CreditCardNumber;
    }
}
