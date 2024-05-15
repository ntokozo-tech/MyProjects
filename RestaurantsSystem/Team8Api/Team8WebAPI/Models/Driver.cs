using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DriverPassword { get; set; } = string.Empty;
        public string DriverEmail { get; set; } = string.Empty;
        public string DriverPictureUrl { get; set; } = string.Empty;
        public int DriverRating { get; set; }
        public int DriverCompletedTrips { get; set; }
        public string DriverAddress { get; set; } = string.Empty;
        public string DriverLanguages { get; set; } = string.Empty;
    }
}