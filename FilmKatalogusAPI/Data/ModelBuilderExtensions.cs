using FilmKatalogusAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FilmKatalogusAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Színészek
            modelBuilder.Entity<Szinesz>().HasData(
                   new Szinesz { Id = 1, Keresztnev = "Tom", Vezeteknev = "Hanks", Nemzetiseg = "USA", OscarNyertes = true, SzuletesiDatum = new DateTime(1956, 07, 09) }
            );

            modelBuilder.Entity<FilmMufaj>().HasData(
                new FilmMufaj { Id = 1, Nev = "Dráma", Korhatar = 12 }
                );

            // Filmek
            modelBuilder.Entity<Film>().HasData(
                new Film() { Id = 1, Cim = "Forrest Gump", BemutatoDatum = new DateTime(1994,06,23), FilmMufajId = 1 }
            );
        }
    }
}
