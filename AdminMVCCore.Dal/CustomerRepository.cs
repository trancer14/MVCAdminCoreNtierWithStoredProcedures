using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AdminMVCCore.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdminMVCCore.Dal
{
    public class CustomerRepository : ICustomerRepository 
    {
        private DataContext _db;

        public CustomerRepository(DataContext db)
        {
            _db = db;
        }

       

        public void Create(Customer cst)
        {
            var parameters = new List<SqlParameter>
                 {
                     new SqlParameter("@FirstName", cst.CustomerFirstName),
                     new SqlParameter("@LastName", cst.CustomerLastName),
                     new SqlParameter("@City", cst.CustomerCity),
                     new SqlParameter("@TC", cst.CustomerIdentityNumber),
                     new SqlParameter("@Phone", cst.CustomerPhone)
                 };
            _db.Database.ExecuteSqlCommand($"exec CreateCustomer @FirstName,@LastName,@City,@TC,@Phone", parameters.ToArray());
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            SqlParameter u = new SqlParameter("@Id", id);
            _db.Database.ExecuteSqlCommand($"exec DeleteCustomer @Id", u);
            _db.SaveChanges();
        }

        public List<Customer> Get()
        {
            return _db.Customers.ToList();
        }

        public void Update(Customer cst)
        {
            var parameters = new List<SqlParameter>
                 {
                     new SqlParameter("@CustomerId",cst.Id),
                     new SqlParameter("@FirstName", cst.CustomerFirstName),
                     new SqlParameter("@LastName", cst.CustomerLastName),
                     new SqlParameter("@City", cst.CustomerCity),
                     new SqlParameter("@TC", cst.CustomerIdentityNumber),
                     new SqlParameter("@Phone", cst.CustomerPhone)
                 };
            _db.Database.ExecuteSqlCommand($"exec UpdateCustomers @CustomerId,@FirstName,@LastName,@City,@TC,@Phone", parameters.ToArray());
            _db.SaveChanges();
            
        }
        public Customer Find(int id)
        {
            Customer finded=_db.Customers.Find(id);
            return finded;
        }
    }
}
