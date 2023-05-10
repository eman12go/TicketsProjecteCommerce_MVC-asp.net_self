using System.ComponentModel.DataAnnotations;

namespace Tickets________.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Actor_Movies> Actor_Movies { get; set; }
    }
}
