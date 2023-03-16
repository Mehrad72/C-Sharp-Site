using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GBCSporting_Huskies.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter first Name")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please Enter State")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please Enter Postalcode")]
        [StringLength(20, ErrorMessage = "Name must be between 1 and less than 21 characters")]
        public string? Postalcode { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        
        public string CountryId { get; set; }
        public Country? Country{ get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        [StringLength(51, ErrorMessage = "Name must be between 1 and less than 51 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email")]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number")]
        public string? Phone { get; set; }

        public string FullName => Firstname?.ToString() +  " " + Lastname?.ToString();
        public String Slug => Firstname?.Replace(' ', '-').ToLower()
            + '-' + Lastname?.Replace(' ', '-').ToLower() + '-' + Email?.ToString() + '-' +City?.ToString();
    }
}
