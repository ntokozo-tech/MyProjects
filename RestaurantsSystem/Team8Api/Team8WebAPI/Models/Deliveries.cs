using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Deliveries
    {
        [Key]
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int DriverID { get; set; }
        public string DeliveryAddress { get; set; } = string.Empty;

    }
}
