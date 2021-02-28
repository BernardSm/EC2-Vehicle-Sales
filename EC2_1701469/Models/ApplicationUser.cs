using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC2_1701469.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
