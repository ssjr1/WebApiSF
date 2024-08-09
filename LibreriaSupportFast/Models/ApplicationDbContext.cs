using Microsoft.EntityFrameworkCore;

namespace LibreriaSupportFast.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=SupportFast;Integrated Security=True;TrustServerCertificate=True;");
        //}

        public DbSet<Tecnicos> Tecnicos { get; set; }
        public DbSet<Gestiones> Gestiones { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<SubCategorias> SubCategorias { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Soluciones> Soluciones { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Perfiles> Perfiles { get; set; }
    }
}