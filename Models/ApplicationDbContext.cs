using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace StackClone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<Answer> Answers { get; set; }
    }
}