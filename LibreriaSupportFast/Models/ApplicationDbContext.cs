using Microsoft.EntityFrameworkCore;

namespace LibreriaSupportFast.Models
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SupportFast;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Tecnicos> Tecnicos { get; set; }
        public DbSet<Gestiones> Gestiones { get; set; }
    }
}

