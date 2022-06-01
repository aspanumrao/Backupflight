using Flight.Service.UserManagementAPI.Model;
using Flight.Service.UserManagementAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using auth=Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XAct.Security;
using Flight.Service.UserManagementAPI.JWT;
using Microsoft.Extensions.Configuration;

namespace Flight.Service.UserManagementAPI.Controllers
{
  [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly ILoginRepository _ILoginRepository;
     
        private IConfiguration _configuration;
        public UserLoginController(ILoginRepository loginRepository,IConfiguration configuration)
        {
            _ILoginRepository = loginRepository;
            _configuration = configuration;


        }
        //public UserLoginController(ILoginRepository loginRepository)
        //{
        //    _ILoginRepository = loginRepository;
        //}
        [HttpGet]
        public IEnumerable<string> get()
        {
            return new string[] { "Username", "Password" };
        }

        [HttpPost]
        [Route("new")]
        public void NewUserRegistration([FromBody] LoginTbl loginTbl)
        {
            _ILoginRepository.RegisterUser(loginTbl);

        }


        [HttpPost]
        [Route("role")]
        public void RoleAssign([FromBody] UserRoleTbl userRoleTbl)
        {
            _ILoginRepository.RoleAssignment(userRoleTbl);

        }
       [auth.AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginTbl loginTbl)
        {
           
           IActionResult response = Unauthorized();
          var token=  _ILoginRepository.AuthenticationUser(loginTbl);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                JWTAuth _jWTAuth = new JWTAuth(_configuration);
                var TokenString = _jWTAuth.GenrateWebToken(loginTbl);
                response = Ok(new { token, TokenString });
                   
            }
            return Ok(response);
        }
        [Route("hello")]
        public string hello()
        {
            return "Hi ";
        }

    }
}
