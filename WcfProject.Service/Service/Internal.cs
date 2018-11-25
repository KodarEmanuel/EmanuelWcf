using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repos;
using Data.Domains;

namespace Service
{
    public class Internal
    {
        public void SeedDb(int customers, int cars,  int bookings)
        {
            var cr = new CustomerRepo();
            var ca = new CarRepo();
            var br = new BookingRepo();
            for (int i = 0; i < Math.Max(Math.Max(customers, cars), bookings); i++)
            {
                if (customers >= i || customers < 0) cr.Add(new Customer { FName = "Fname" + i, LName = "Lname" + i, Email = "mail" + i + "@mail.mail", Phone = ("07" + new Random().Next(0, 99999999)) });
                if (cars >= i || cars < 0) ca.Add(new Car {Brand="Volvo",Color="Red",RegNr="ABC000".Substring(0,6-i.ToString().Length)+i ,YearModel=(1995+i%23).ToString()});
                if (bookings >= i) br.BookCar(
                    new Booking
                    {
                        CustumerId = cr.GetById(new Random().Next(1, cr.GetAll().Count)).Id,
                        CarId = ca.GetById(new Random().Next(1, ca.GetAll().Count)).Id,
                        Start = new DateTime(2000, 03, 01).AddDays((i + 3)),
                        End = new DateTime(2000, 03, 03).AddDays((i + 3)),
                        Returned = false
                    });
              
            }
        }
    }
}

