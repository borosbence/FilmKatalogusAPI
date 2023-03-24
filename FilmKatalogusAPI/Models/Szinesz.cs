using System.ComponentModel.DataAnnotations;

namespace FilmKatalogusAPI.Models
{
    public class Szinesz : IEntity
    {
        public Szinesz()
        {
            Filmek = new HashSet<Film>();
        }
        public int Id { get; set; }
        [StringLength(30)]
        public string Keresztnev { get; set; } = null!;
        [StringLength(30)]
        public string Vezeteknev { get; set; } = null!;
        [StringLength(30)]
        public string Nemzetiseg { get; set; } = null!;
        public DateTime SzuletesiDatum { get; set; }
        public bool OscarNyertes { get; set; }

        public ICollection<Film> Filmek { get; set; }
    }
}
