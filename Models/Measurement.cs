using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Measurement
    {
        [Key]
        public int MeasurementID { get; set; }
        public int PicketID { get; set; }
        public DateTime MeasurementDate { get; set; }
        public string MeasurementType { get; set; }
        public string ElectrodeType { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }

        [ForeignKey("PicketID")]
        public Picket Picket { get; set; }
    }
}
