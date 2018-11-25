using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domains
{
    public class Booking
    {
        public int Id { get; set; }

        public int CustumerId { get; set; }

        public int CarId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public bool Returned { get; set; }
    }
}
