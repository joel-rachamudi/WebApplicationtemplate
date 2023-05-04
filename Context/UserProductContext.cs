using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplicationtemplate.Data;
using WebApplicationtemplate.Models;

namespace WebApplicationtemplate.Context
{
    public class UserProductContext: DbContext
    {    public UserProductContext()
            : base()
        {

        }
        public virtual DbSet<UserProduct> UserProducts{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=TaskDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

    }
}
