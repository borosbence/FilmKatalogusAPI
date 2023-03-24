using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmKatalogusAPI.Models
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        [StringLength(60)]
        public string Cim { get; set; } = null!;
        public DateTime? BemutatoDatum { get; set; }

        [ForeignKey("Mufaj")]
        public int FilmMufajId { get; set; }
        public FilmMufaj? FilmMufaj { get; set; }
    }
}
