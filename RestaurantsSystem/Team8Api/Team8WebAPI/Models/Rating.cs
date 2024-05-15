using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int OrderRating { get; set; }
        public int DeliveryRating { get; set; }
        public int ServiceRating { get; set; }
        public string feedback { get; set; } = string.Empty;
    }
}
