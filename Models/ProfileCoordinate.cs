using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
