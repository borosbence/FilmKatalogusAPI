using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmKatalogusAPI.Models
{
    public class FilmMufaj : IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nev { get; set; }
        [Range(0,18)]
        public int? Korhatar { get; set; }

        public ICollection<Film> Filmek { get; set; }
    }
}
