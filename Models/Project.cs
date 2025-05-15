using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public int CustomerID { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }

        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
        public ICollection<ProjectArea> ProjectAreas { get; set; }
    }
}
