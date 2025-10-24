using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Namespace
{
    public class DbThingy : IdentityDbContext<User>
    {
        public DbThingy(DbContextOptions options)
            : base(options) { }
            
        public DbSet<Stoka> Stoki { get; set; }
        public DbSet<Animal> Animal { get; set; }
    }
}