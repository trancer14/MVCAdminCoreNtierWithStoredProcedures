using AdminMVCCore.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminMVCCore.Dal
{
    public interface IAdminRepository
    {
        int Login(Admin admn);
        void Logout();
    }
}
