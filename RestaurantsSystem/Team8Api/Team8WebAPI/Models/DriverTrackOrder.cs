using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class DriverTrackOrder
    {
        [Key]
        public int Del_ID { get; set; }
        public int U_ID { get; set; }
        public string Order_Status { get; set; } = string.Empty;
    }
}
