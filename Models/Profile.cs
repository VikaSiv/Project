using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Profile
    {
        [Key]
        public int ProfileID { get; set; }
        public string ProfileType { get; set; }

        public ICollection<ProfileCoordinate> ProfileCoordinates { get; set; }
        public ICollection<ProfilePicket> ProfilePickets { get; set; }
    }
}
