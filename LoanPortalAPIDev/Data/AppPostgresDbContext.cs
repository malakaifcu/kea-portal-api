using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoanPortalAPIDev.Data
{
    public class AppPostgresDbContext:DbContext
    {
        public DbSet<PQLC_Loan> PQLC_Loans { get; set; }
        protected readonly IConfiguration Configuration;

        public AppPostgresDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PQLC_Loan>(f => {
                f.HasKey(e => e.ID);
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
            
        }

        
    }
}
