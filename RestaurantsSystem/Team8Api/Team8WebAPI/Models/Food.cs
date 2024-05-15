using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set;}
        public string Url { get; set; } = string.Empty;
        public string Category { get; set;} = string.Empty;
    }
}
