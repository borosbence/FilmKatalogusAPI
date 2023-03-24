using System.ComponentModel.DataAnnotations;

namespace FilmKatalogusAPI.Models
{
    public class Film : IEntity
    {
        public Film()
        {
            Szineszek = new HashSet<Szinesz>();
        }
        public int Id { get; set; }
        [StringLength(60)]
        public string Cim { get; set; } = null!;
        public DateTime? BemutatoDatum { get; set; }
        public string Mufaj { get; set; }

        public ICollection<Szinesz> Szineszek { get; set; }
    }
}
