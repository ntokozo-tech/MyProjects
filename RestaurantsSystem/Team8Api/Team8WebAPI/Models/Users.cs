using System.ComponentModel.DataAnnotations;

namespace Team8WebAPI.Models
{
    public class Users
    {
        [Key]
        public int U_ID { get; set; }
        public string U_name { get; set; } = string.Empty;
        public string U_Email { get; set; } = string.Empty;
        public string U_CellNumber { get; set; } = string.Empty;
        public string U_username { get; set; } = string.Empty;
        public string U_Password { get; set; } = string.Empty;
        public string U_type { get; set; } = string.Empty;
        public DateTime R_Date { get; set; }
    }
}
