using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.UserManagementAPI.Model
{
    public class LoginTbl
    {
        [Key]
        public Guid guid { get; set; }
        public string  username { get; set; }
        public string password { get; set; }

    }
   
       
}
