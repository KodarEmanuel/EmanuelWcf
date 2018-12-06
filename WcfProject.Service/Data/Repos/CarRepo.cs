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
    public class CarRepo
    {
        private string conn = "Data Source =./BookingDB.sqlite; Version = 3;";

        public CarRepo()
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"
                 CREATE TABLE IF NOT EXISTS [Car] (
                 [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                 [RegNr] NVARCHAR(7) NOT NULL,
                 [SerialNumber] NVARCHAR(15) NOT NULL,
                 [Color] NVARCHAR(128) NOT NULL,
                 [Brand] NVARCHAR(128) NOT NULL,
                 [YearModel] INTEGER NOT NULL
                 )");
            }
        }

        public void Add(Car entity)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"
                INSERT INTO Car (RegNr, Color, Brand, YearModel)
                VALUES (@RegNr, @Color, @Brand, @YearModel)",
                entity);
            }
        }

        public Car GetById(int id)
        {
            Car car;
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                car = db.Query<Car>(string.Format("SELECT * FROM Car WHERE Id = {0}", id)).FirstOrDefault();
            }
            return car;
        }

        public List<Car> GetAll()
        {
            List<Car> car;
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                car = db.Query<Car>("SELECT * FROM Car").ToList();
            }
            return car;
        }


        public void Delete(Car entity)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"
                DELETE FROM Car WHERE id = @id", entity);
            }
        }
    }
}
