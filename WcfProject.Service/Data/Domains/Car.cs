using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Data.Domains
{
    [DataContract(Namespace = "http://carservice/Employee")]
    public class Car
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public string RegNr { get; set; }

        public string SerialNumber { get; set; }

        [DataMember(Order = 3)]
        public string Color { get; set; }

        [DataMember(Order = 4)]
        public string Brand { get; set; }

        [DataMember(Order = 5)]
        public string YearModel { get; set; }
    }
}
