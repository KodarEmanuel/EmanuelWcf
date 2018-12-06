using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domains
{
    [MessageContract(IsWrapped = true, WrapperName = "BookingRqObject", WrapperNamespace = "http://book.book/Booking")]
    public class BookingRequest
    {

        [MessageHeader(Namespace = "http://book.book/Booking")]
        public string LisenceKey { get; set; }

        [MessageBodyMember(Namespace = "http://book.book/Booking")]
        public int Id { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "BookingRqObject", WrapperNamespace = "http://book.book/Booking")]
    public class BookingInfo
    {

        public BookingInfo(Booking booking)
        {
            this.Id = booking.Id;
            this.CarId = booking.CarId;
            this.CustumerId = booking.CustumerId;
            this.Start = booking.Start;
            this.End = booking.End;
            this.Returned = booking.Returned;
        }


        [MessageBodyMember(Order = 1, Namespace = "http://book.book/Booking")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://book.book/Booking")]
        public int CustumerId { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://book.book/Booking")]
        public int CarId { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://book.book/Booking")]
        public DateTime Start { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://book.book/Booking")]
        public DateTime End { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://book.book/Booking")]
        public bool Returned { get; set; }
    }



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
