using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmKatalogusAPI.Data
{
    public class SzineszRepository : EfCoreRepository<Szinesz, FilmContext>
    {
        public SzineszRepository(FilmContext context) : base(context)
        {

        }
    }
}
