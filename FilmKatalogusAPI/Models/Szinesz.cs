using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmKatalogusAPI.Models
{
    public class Szinesz : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Keresztnev { get; set; }

        [Required]
        [StringLength(30)]
        public string Vezeteknev { get; set; }

        [Required]
        [StringLength(30)]
        public string Nemzetiseg { get; set; }

        [DataType(DataType.Date)]
        public DateTime SzuletesiDatum { get; set; }

        public bool OscarNyertes { get; set; }
    }
}
