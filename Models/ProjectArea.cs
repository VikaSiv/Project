using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ProjectArea
    {
        [Key]
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int AreaID { get; set; }

        [ForeignKey("ProjectID")]
        public Models.Project Project { get; set; }
        [ForeignKey("AreaID")]
        public virtual Area Area { get; set; }
    }
}
