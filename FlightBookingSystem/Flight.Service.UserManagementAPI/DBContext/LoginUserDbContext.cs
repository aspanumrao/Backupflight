using Flight.Service.UserManagementAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.DBContext
{
    public class LoginUserDbContext :DbContext
    {
        public LoginUserDbContext(DbContextOptions<LoginUserDbContext> options):base(options)
        {

        }
        public DbSet<LoginTbl> loginTbls { get; set; }
        public DbSet<UserRoleTbl> userRoleTbls { get; set; }
    }
}
