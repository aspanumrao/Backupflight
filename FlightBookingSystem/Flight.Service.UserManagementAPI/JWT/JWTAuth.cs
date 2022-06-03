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

namespace Flight.Service.UserManagementAPI.JWT
{
    public class JWTAuth : IJWTAuth
    {
        private IConfiguration _config  { get; }
       // private IJWTAuth _authobj;
       
        public JWTAuth(IConfiguration configuration)
        {
            _config = configuration;
        }
       
        public string GenrateWebToken(LoginTbl loginTbl){

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_config["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {

                    new Claim(ClaimTypes.Name,loginTbl.username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
