using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Data.Domains;
using System.Net.Security;

namespace Service
{
    [ServiceContract]
    public interface IServiceCustomer : IServiceGeneric<Customer>
    {
        [OperationContract(ProtectionLevel=ProtectionLevel.EncryptAndSign)]
        Booking GetCurrentBooking(Customer customer);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        Booking[] GetAllPastBookings(Customer customer);
    }
}
