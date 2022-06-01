using Flight.Service.UserManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.Repository
{
  public  interface ILoginRepository
    {
        void RegisterUser(LoginTbl loginTbl);
        void RoleAssignment(UserRoleTbl userRoleTbl);
        string AuthenticationUser(LoginTbl loginTbl);
    }
}
