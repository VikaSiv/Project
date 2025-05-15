using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class AreaCoordinate
    {
        [Key]
        public int AreaCoordinatesID { get; set; }
        public int AreaID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        [ForeignKey("AreaID")]
        public Area Area { get; set; }
    }
}
