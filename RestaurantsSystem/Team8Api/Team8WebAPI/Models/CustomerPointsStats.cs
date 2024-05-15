using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class CustomerPointsStats
    {
        [Key]
        public int UserID { get; set; }
        public decimal TotalCost { get; set; }
        public string Month { get; set; }
        public decimal PointsEarned { get; set; }
    }
}
