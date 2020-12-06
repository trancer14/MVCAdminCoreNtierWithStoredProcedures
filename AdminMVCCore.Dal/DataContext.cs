using AdminMVCCore.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminMVCCore.Dal
{
    public class DataContext:DbContext
    {
        

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

       
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Customer> Customers { get; set; }

        
         
    }
}
