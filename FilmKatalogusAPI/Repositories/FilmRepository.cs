using FilmKatalogusAPI.Data;
using FilmKatalogusAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmKatalogusAPI.Repositories
{
    public class FilmRepository : EfCoreRepository<Film, FilmContext>
    {
        public FilmRepository(FilmContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
