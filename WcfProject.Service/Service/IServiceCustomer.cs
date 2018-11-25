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
    public interface IServiceCustomer : IServiceGeneric<Customer>
    {
        [OperationContract]
        Booking GetCurrentBooking(Customer customer);

        [OperationContract]
        Booking[] GetAllPastBookings(Customer customer);
    }
}
