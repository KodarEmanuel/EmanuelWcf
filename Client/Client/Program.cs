using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Web.Script.Serialization;
using Client.ProxyHttpCar;
using Client.ProxyHttpBooking;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            using (var proxy = new ProxyHttpBooking.ServiceBookingClient("WSHttpBinding_IServiceBooking"))
            {
                var cars = proxy.GetAvailableCars(new DateTime(2000, 05, 18), new DateTime(2000, 05, 29)).ToArray();
                //var a = infoAsync(proxy);

            }
            using (var proxy = new ProxyHttpCar.ServiceCarClient("WSHttpBinding_IServiceCar"))
            {
                var a = proxy.ReadAll();
            }
            using (var proxy = new ProxyHttpCustomer.ServiceCustomerClient("WSHttpBinding_IServiceCustomer"))
            {
                var a = proxy.ReadAll();
            }
        }



        private static async Task<BookingInfo> infoAsync(ServiceBookingClient client)
        {
            return await client.GetBookingInfoAsync(new BookingRequest("key", 1));
        }
    }
}



