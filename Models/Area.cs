using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public string AreaDescription { get; set; }

        public ICollection<AreaCoordinate> AreaCoordinates { get; set; }
        public ICollection<AreaProfile> AreaProfiles { get; set; }
    }
}
