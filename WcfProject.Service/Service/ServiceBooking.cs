using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domains;
using Data.Repos;

namespace Service
{
    public class ServiceBooking : IServiceBooking
    {
        private BookingRepo bookingRepo = new BookingRepo();
        public void Create(Booking entity)
        {
            bookingRepo.BookCar(entity);
        }

        public void Delete(Booking entity)
        {
            bookingRepo.RemoveBooking(entity);
        }

        public Booking[] GetAllBookingTimeSpan(DateTime startDate, DateTime endDate)
        {
            return bookingRepo.GetBookings().Where(m => m.Start >= startDate && m.End <= endDate).ToArray();
        }

        public Booking[] ReadAll()
        {
            return bookingRepo.GetBookings().ToArray();
        }

        public Booking ReadById(int id)
        {
            return bookingRepo.GetBookingById(id);
        }

        public void ReturnCar(Booking booking)
        {
            bookingRepo.ReturnCar(booking);
        }

        public void Update(Booking entity)
        {
            bookingRepo.ReturnCar(entity);
        }

        public Car[] GetAvailableCars(DateTime start, DateTime end)
        {
            return bookingRepo.GetAvailableCars(start, end).ToArray();
        }
    }
}
