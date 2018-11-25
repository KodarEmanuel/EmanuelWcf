using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using Data.Domains;

namespace Data.Repos
{
    public class BookingRepo
    {
        private string conn = "Data Source =./BookingDB.sqlite; Version = 3;";
        public BookingRepo()
        {

            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"
                 CREATE TABLE IF NOT EXISTS [Booking] (
                 [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                 [CustumerId] INTEGER NOT NULL,
                 [CarId] INTEGER NOT NULL,
                 [Start] TIMESTAMP NOT NULL,
                 [End] TIMESTAMP NOT NULL,
                 [Returned] BOOLEAN NOT NULL,
                 FOREIGN KEY(CarId) REFERENCES Car(Id),
                 FOREIGN KEY(CustumerId) REFERENCES artist(Id)
                 )");
            }
        }

        public List<Booking> GetBookings()
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                return db.Query<Booking>("SELECT * FROM Booking WHERE 1=1").ToList();
            }
        }

        public Booking GetBookingById(int id)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                return db.Query<Booking>("SELECT * FROM Booking WHERE id = @id").FirstOrDefault();
            }
        }


        public void BookCar(Booking booking)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute("INSERT INTO Booking (CustumerId, CarId, Start, End, Returned) VALUES(@CustumerId, @CarId, @Start, @End, @Returned)", booking);
            }
        }

        public void RemoveBooking(Booking booking)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"DELETE FROM Booking WHERE id = @id", booking);
            }
        }

        public void ReturnCar(Booking booking)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"UPDATE Booking SET CustumerId = @CustumerId, CarId = @CarId, Start = @Start, End = @End, Returned = @Returned", booking);
            }
        }

        public List<Car> GetAvailableCars(DateTime start, DateTime end)
        {
            var cars = new CarRepo().GetAll();
            var booking = new BookingRepo().GetBookings().Where(m => m.Start >= start && m.End <= end).ToList();
            for (int i = 0; i < booking.Count; i++)
            {
                cars.RemoveAll(m=>m.Id==booking[i].CarId);
            }

            return cars;
        }
    }
}
