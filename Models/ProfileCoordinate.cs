using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ProfileCoordinate
    {
        [Key]
        public int ProfileCoordinatesID { get; set; }
        public int ProfileID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        [ForeignKey("ProfileID")]
        public Profile Profile { get; set; }
    }
}
