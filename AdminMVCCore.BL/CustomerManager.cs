using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using AdminMVCCore.Dal;
using AdminMVCCore.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdminMVCCore.BL
{
    public class CustomerManager : ICustomerManager
    {

        private readonly ICustomerRepository _repository;
        public CustomerManager(ICustomerRepository repository)
        {
           
            _repository = repository;
        }

        public void Create(Customer cst)
        {
            _repository.Create(cst);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Customer> Get()
        {
            return _repository.Get();
        }

        public void Update(Customer cst)
        {
            _repository.Update(cst);
            
        }
        public Customer Find(int id)
        {
           Customer finded= _repository.Find(id);
            return finded;
        }
    }
}
