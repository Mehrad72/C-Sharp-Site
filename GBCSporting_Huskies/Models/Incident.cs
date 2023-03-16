using System.ComponentModel.DataAnnotations;

namespace GBCSporting_Huskies.Models
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }

        [Required(ErrorMessage = "Please Enter a Customer")]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required(ErrorMessage = "Please Enter a Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Required(ErrorMessage = "Please Enter a Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please Enter a Description")]
        public string? Description { get; set; }

        public int TechnicianId { get; set; }
        public Technician? Technician { get; set; }

        [Required(ErrorMessage = "Please enter a Opened Date")]
        public DateTime? DateOp { get; set; }

        public DateTime? DateCl { get; set; }
    }
}
