using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Data.Domains;

namespace Service
{
    [ServiceContract]
    interface IServiceBooking : IServiceGeneric<Booking>
    {
        [OperationContract]
        Booking[] GetAllBookingTimeSpan(DateTime startDate, DateTime endDate);

        [OperationContract]
        void ReturnCar(Booking booking);

        [OperationContract]
        Car[] GetAvailableCars(DateTime start, DateTime end);
    }
}
