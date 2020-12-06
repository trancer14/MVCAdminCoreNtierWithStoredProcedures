using AdminMVCCore.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminMVCCore.BL
{
    public interface IAdminManager
    {
        int Login(Admin admn);
        void Logout();
    }
}
