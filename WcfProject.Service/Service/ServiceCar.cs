using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Data.Domains;
using Data.Repos;

namespace Service
{
    public class ServiceCar : IServiceCar
    {
        public void Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car[] ReadAll()
        {
            throw new NotImplementedException();
        }

        public Booking[] ReadAllPastBookings(Car entity)
        {
            throw new NotImplementedException();
        }

        public Customer[] ReadAllPastCustomers(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car[] ReadAvailableCars()
        {
            throw new NotImplementedException();
        }

        public Car ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public Booking ReadCurrentBooking(Car entity)
        {
            throw new NotImplementedException();
        }

        public Customer ReadCurrentCustomer(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
