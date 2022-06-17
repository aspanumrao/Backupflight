using Flight.Service.UserManagementAPI.DBContext;
using Flight.Service.UserManagementAPI.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginUserDbContext _logonuserdbcontext;
       
        
        public LoginRepository(LoginUserDbContext loginUserDbContext)
        {
            _logonuserdbcontext = loginUserDbContext;     
        }
        public void RegisterUser(LoginTbl loginTbl)
        {
            Guid newguid = Guid.NewGuid();
            loginTbl.guid = newguid;
            _logonuserdbcontext.loginTbls.Add(loginTbl);
            _logonuserdbcontext.SaveChanges();
            
        }
       public void RoleAssignment(UserRoleTbl userRoleTbl)
        {
            //what is the username  find the guid 
            //Guid existingguid  = _logonuserdbcontext.loginTbls.Where(a => a.username == loginTbl.username).Select(a=>a.guid).SingleOrDefault();
            //userRoleTbl.guid = existingguid;
            _logonuserdbcontext.userRoleTbls.Add(userRoleTbl);
            _logonuserdbcontext.SaveChanges();
        }
        public bool AuthenticationUser(LoginTbl loginTbl)
        {
            if (!_logonuserdbcontext.loginTbls.Where(a => a.username == loginTbl.username && a.password == loginTbl.password).Any())
            {
                return false;
            }
            
            // Guid guid=_logonuserdbcontext
            return true;
        }
    }
}
