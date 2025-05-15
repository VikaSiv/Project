using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ProfilePicket
    {
        [Key]
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public int PicketID { get; set; }

        [ForeignKey("ProfileID")]
        public Profile Profile { get; set; }
        [ForeignKey("PicketID")]
        public Picket Picket { get; set; }
    }
}
