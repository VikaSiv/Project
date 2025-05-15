using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Picket
    {
        [Key]
        public int PicketID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<Measurement> Measurements { get; set; }
        public ICollection<ProfilePicket> ProfilePickets { get; set; }
    }
}
