using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.Models
{
    public class AreaProfile
    {
        [Key]
        public int ID { get; set; }
        public int AreaID { get; set; }
        public int ProfileID { get; set; }

        [ForeignKey("AreaID")]
        public Area Area { get; set; }
        [ForeignKey("ProfileID")]
        public Profile Profile { get; set; }
    }
}
