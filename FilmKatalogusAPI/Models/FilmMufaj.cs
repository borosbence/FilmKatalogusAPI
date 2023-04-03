using System.ComponentModel.DataAnnotations;

namespace FilmKatalogusAPI.Models
{
    public class FilmMufaj : IEntity
    {
        public int Id { get; set; }
        [StringLength(60)]
        public string Nev { get; set; } = null!;
        [Range(1,18)]
        public int Korhatar { get; set; }
    }
}
