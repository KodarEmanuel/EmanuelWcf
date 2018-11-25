using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domains;
using Data.Repos;

namespace Service
{
    public class ServiceCustomer : IServiceCustomer
    {
        public CustomerRepo customerRepo = new CustomerRepo();
        

        public void Create(Customer entity)
        {
            customerRepo.Add(entity);
        }

        public void Delete(Customer entity)
        {
            customerRepo.Delete(entity);
        }

        public Booking[] GetAllPastBookings(Customer customer)
        {
            return new BookingRepo().GetBookings().ToArray();
        }

        public Booking GetCurrentBooking(Customer customer)
        {
            return new BookingRepo().GetBookings().ToArray().Where(m=> m.CustumerId == customer.Id).FirstOrDefault();
        }

        public Customer[] ReadAll()
        {
            return customerRepo.GetAll().ToArray();
        }

        public Customer ReadById(int id)
        {
            return customerRepo.GetById(id);
        }

        public void Update(Customer entity)
        {
            customerRepo.Update(entity);
        }

    }
}
