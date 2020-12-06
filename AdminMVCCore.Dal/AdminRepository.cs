using System;
using System.Collections.Generic;
using System.Text;
using AdminMVCCore.Entities.Tables;
using System.Linq;

namespace AdminMVCCore.Dal
{

    public class AdminRepository : IAdminRepository
    {
        private DataContext _db;

        public AdminRepository(DataContext db)
        {
            _db = db;
        }

        public int Login(Admin admn)
        {
            var loginstate = from n1 in _db.Admins where n1.AdminName == admn.AdminName && n1.AdminPass == admn.AdminPass select n1.Id;
            if (loginstate==null)
            {
                return 0;
                
            }      else

                return loginstate.SingleOrDefault();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
