using Microsoft.EntityFrameworkCore;
using FilmKatalogusAPI.Models;

namespace FilmKatalogusAPI.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext()
        {
            
        }

        public FilmContext (DbContextOptions<FilmContext> options)
            : base(options)
        {
        }

        public DbSet<FilmMufaj> FilmMufajok { get; set; } = null!;
        public DbSet<Film> Filmek { get; set; } = null!;
        public DbSet<Szinesz> Szineszek { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string localDb = "server=localhost;user id=root;database=filmkatalogus";
                optionsBuilder.UseMySql(localDb, ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
