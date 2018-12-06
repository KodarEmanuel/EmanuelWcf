using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using Data.Domains;

namespace Service
{
    [ServiceContract]
    public interface IServiceCar : IServiceGeneric<Car>
    {

        [OperationContract]
        [WebGet(UriTemplate = "customeroncar",RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        Customer ReadCurrentCustomer(Car entity);

        [OperationContract]
        [WebGet(UriTemplate = "customeroncar", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        Customer[] ReadAllPastCustomers(Car entity);

        [OperationContract]
        Booking ReadCurrentBooking(Car entity);

        [OperationContract]
        Booking[] ReadAllPastBookings(Car entity);
    }
}
