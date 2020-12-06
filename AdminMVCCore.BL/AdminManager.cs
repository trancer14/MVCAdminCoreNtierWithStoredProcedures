using System;
using System.Collections.Generic;
using System.Text;
using AdminMVCCore.Dal;
using AdminMVCCore.Entities.Tables;

namespace AdminMVCCore.BL
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepository _repository;
        public AdminManager(IAdminRepository repository)
        {

            _repository = repository;
        }

        public int Login(Admin admn)
        {

            int id = _repository.Login(admn);
           
            return id;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
