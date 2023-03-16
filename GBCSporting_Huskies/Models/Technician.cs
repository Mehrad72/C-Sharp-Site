using System.ComponentModel.DataAnnotations;

namespace GBCSporting_Huskies.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string? Email { get; set; }

        public string FullName => Firstname?.ToString() + " " + Lastname?.ToString();

        public string Slug => Firstname?.Replace(' ', '-').ToLower()
            + "-" + Lastname?.Replace(' ', '-').ToLower();
    }
}
