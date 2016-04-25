using Microsoft.AspNet.Identity.EntityFramework;

namespace StackClone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}