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
    public interface IServiceCar : IServiceGeneric<Car>
    {

        [OperationContract]
        Customer ReadCurrentCustomer(Car entity);

        [OperationContract]
        Customer[] ReadAllPastCustomers(Car entity);

        [OperationContract]
        Booking ReadCurrentBooking(Car entity);

        [OperationContract]
        Booking[] ReadAllPastBookings(Car entity);
    }
}
