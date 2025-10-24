using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CodeRefactoring.Data.Entities;

namespace CodeRefactoring.Database
{
    public class CodeRefactorDbContext : IdentityDbContext<User>
    {
        public CodeRefactorDbContext(DbContextOptions options)
            : base(options) { }
            
        public DbSet<Product> Products { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<User> Users { get; set; }
    }
}