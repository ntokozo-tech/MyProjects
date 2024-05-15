using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Card
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string CardholderName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string ExpDate { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
    }
}
