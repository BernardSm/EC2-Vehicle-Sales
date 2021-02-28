using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EC2_1701469.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EC2_1701469.Data
{
    public class EC2_1701469Context : IdentityDbContext<ApplicationUser>
    {
        public EC2_1701469Context (DbContextOptions<EC2_1701469Context> options)
            : base(options)
        {
        }

        public DbSet<EC2_1701469.Models.Vehicle> Vehicle { get; set; }
    }
}
