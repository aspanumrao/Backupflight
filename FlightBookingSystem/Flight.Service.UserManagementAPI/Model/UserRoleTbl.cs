using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.Model
{
    public class UserRoleTbl
    {

        [Key]
        public int roleid { get; set; }
        public string rolename { get; set; }
        [ForeignKey("LoginTbl")]
        public Guid guid { get; set; }
    
    }
}
