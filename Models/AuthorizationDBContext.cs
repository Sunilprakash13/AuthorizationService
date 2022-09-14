using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Models
{
    public class AuthorizationDBContext:DbContext
    {
        public AuthorizationDBContext(DbContextOptions<AuthorizationDBContext> options) : base(options) { }

        public DbSet<Authenticate> authenticates { get; set; }

    }
}
