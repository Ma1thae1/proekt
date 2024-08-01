using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proekt.Model;

namespace proekt.Data
{
    public class proektContext : DbContext
    {
        public proektContext (DbContextOptions<proektContext> options)
            : base(options)
        {
        }

        public DbSet<proekt.Model.User> User { get; set; } = default!;
    }
}
