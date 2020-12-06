using AdminMVCCore.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminMVCCore.Dal
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        void Create(Customer cst);
        void Update(Customer cst);
        void Delete(int id);
        Customer Find(int id);
    }
}
