using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Worksheet_4
{
    [DataContract(Namespace = "http://users.aber.ac.uk/m5640/paymentprocessor")]
    public class Address
    {
        [DataMember]
        public string HouseName;

        [DataMember]
        public string Street1;

        [DataMember]
        public string Street2;
    }
}
