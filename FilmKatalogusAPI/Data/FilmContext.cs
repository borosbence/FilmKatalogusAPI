using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmKatalogusAPI.Models;

namespace FilmKatalogusAPI.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext (DbContextOptions<FilmContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Filmek { get; set; }
        public DbSet<Szinesz> Szineszek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;database=filmkatalogus", ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
