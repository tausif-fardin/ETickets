using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETickets.Models
{
    public class Actor
    {
        //unique identifier
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureUrl { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string  FullName { get; set; }
        [Required(ErrorMessage ="Bio is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
