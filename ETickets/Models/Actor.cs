using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETickets.Models
{
    public class Actor
    {
        //unique identifier
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string  FullName { get; set; }
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
