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

        public BookingInfo GetBookingInfo(BookingRequest bookingRequest)
        {

            return new BookingInfo(bookingRepo.GetBookingById(bookingRequest.Id));
        }

        public void Create(Booking entity)
        {
            bookingRepo.BookCar(entity);
        }

        public void Delete(Booking entity)
        {
            try
            {
                bookingRepo.RemoveBooking(entity);
            }
            catch

            {
                throw new Exception(message: "Entity not found");
            }
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
            try
            {
                return bookingRepo.GetBookingById(id);
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }
        }

        public void ReturnCar(Booking booking)
        {
            try
            {
                bookingRepo.ReturnCar(booking);
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }
        }

        public void Update(Booking entity)
        {

            try
            {
                bookingRepo.ReturnCar(entity);
            }
            catch
            {
                throw new Exception(message: "Entity not found");
            }
        }

        public Car[] GetAvailableCars(DateTime start, DateTime end)
        {
            return bookingRepo.GetAvailableCars(start, end).ToArray();
        }
    }
}
