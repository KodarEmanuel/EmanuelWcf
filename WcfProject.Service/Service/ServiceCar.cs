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
        public CarRepo carRepo = new CarRepo();

        public void Create(Car entity)
        {
            carRepo.Add(entity);
        }

        public void Delete(Car entity)
        {
            try
            {
                carRepo.Delete(entity);
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }
        }

        public Car[] ReadAll()
        {
            return carRepo.GetAll().ToArray();
        }

        public Booking[] ReadAllPastBookings(Car entity)
        {

            try
            {
                return new BookingRepo().GetBookings().Where(m=> m.CarId==entity.Id).ToArray();
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }

        }

        public Customer[] ReadAllPastCustomers(Car entity)
        {

            try
            {
                List <Customer> customers = new List<Customer>();
                var bookings = new BookingRepo().GetBookings().Where(m => m.CarId == entity.Id).ToArray();
                foreach (Booking booking in bookings)
                {
                    customers.Add(new CustomerRepo().GetById(booking.CustumerId));
                }
                return customers.ToArray();
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }


        }

        public Car ReadById(int id)
        {
            return carRepo.GetById(id);
        }

        public Booking ReadCurrentBooking(Car entity)
        {
            return new BookingRepo().GetBookings().Where(m => m.CarId == entity.Id && m.Start < DateTime.Now && m.End > DateTime.Now).FirstOrDefault();
        }

        public Customer ReadCurrentCustomer(Car entity)
        {
            try
            {
                return new CustomerRepo().GetById(new BookingRepo().GetBookings().Where(m => m.CarId == entity.Id && m.Start < DateTime.Now && m.End > DateTime.Now).FirstOrDefault().CustumerId);
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
