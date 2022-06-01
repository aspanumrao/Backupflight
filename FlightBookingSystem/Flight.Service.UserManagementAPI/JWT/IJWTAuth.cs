using Flight.Service.UserManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.JWT
{
    public interface IJWTAuth
    {
        string GenrateWebToken(LoginTbl usermodel);
    }
}
