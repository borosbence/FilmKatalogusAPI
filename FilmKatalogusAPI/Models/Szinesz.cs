using System.ComponentModel.DataAnnotations;

namespace FilmKatalogusAPI.Models
{
    public class Szinesz : IEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Keresztnev { get; set; } = null!;
        [StringLength(30)]
        public string Vezeteknev { get; set; } = null!;
        [StringLength(30)]
        public string Nemzetiseg { get; set; } = null!;
        public DateTime SzuletesiDatum { get; set; }
        public bool OscarNyertes { get; set; }
        
        // Több a több kapcsolathoz:
        // https://www.entityframeworktutorial.net/efcore/configure-many-to-many-relationship-in-ef-core.aspx
    }
}
