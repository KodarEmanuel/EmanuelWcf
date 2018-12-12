using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ServiceModel;
using Service;
using Data.Domains;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {

            //Seed
            if (!File.Exists("./BookingDB.sqlite"))
            {
               new Internal().SeedDb(cars: 10, customers: 50, bookings: 80);
                Console.WriteLine("Db is Seeded");
            }
            new ServiceBooking().GetBookingInfo(new BookingRequest {LisenceKey="key1", Id =1 });

          
            ServiceHost[] hosts = new ServiceHost[]
            {
                new ServiceHost(typeof(ServiceCar)),
                new ServiceHost(typeof(ServiceCustomer)),
                new ServiceHost(typeof(ServiceBooking))
            };

            for (int i = 0; i < hosts.Length; i++)
            {
                hosts[i].Open();
                Console.WriteLine(string.Format("@{0} Service: {1} is {2}",DateTime.Now, hosts[i].Description.Name,  hosts[i].State));
            }
                
                Console.ReadLine();
            
        }
    }
}
