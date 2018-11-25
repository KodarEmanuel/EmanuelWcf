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
    public class CustomerRepo
    {
        private string conn = "Data Source =./BookingDB.sqlite; Version = 3;";
        public CustomerRepo()
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"
                 CREATE TABLE IF NOT EXISTS [Custumer] (
                 [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                 [FName] NVARCHAR(25) NOT NULL,
                 [LName] NVARCHAR(128) NOT NULL,
                 [Phone] NVARCHAR(128) NOT NULL,
                 [Email] NVARCHAR(128) NOT NULL
                 )");
            }
        }

        public void Add(Customer custumer)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"INSERT INTO Custumer (FName, LName, Phone, Email)
                           VALUES(@Fname, @LName, @Phone, @Email)", custumer);
            }
        }

        public Customer GetById(int id)
        {
            Customer custumer;
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                custumer = db.Query<Customer>(string.Format("SELECT * FROM Custumer WHERE Id = {0}", id)).FirstOrDefault();
            }
            return custumer;
        }

        public List<Customer> GetAll()
        {
            List<Customer> custumer;
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                custumer = db.Query<Customer>(string.Format("SELECT * FROM Custumer")).ToList();
            }
            return custumer;
        }

        public void Update(Customer custumer)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"UPDATE Custumer SET FName = @FName, LName = @LName, Phone = @Phone, Email = @Email WHERE Id = @Id", custumer);
            }
        }

        public void Delete(Customer custumer)
        {
            using (var db = new SQLiteConnection(conn))
            {
                db.Open();
                db.Execute(@"DELETE FROM Custumer WEHRE Id = @Id", custumer);
            }
        }
    }
}
