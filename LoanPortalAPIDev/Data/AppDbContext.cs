using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoanPortalAPIDev.Data
{
    public class AppDbContext : IdentityDbContext<MyUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
