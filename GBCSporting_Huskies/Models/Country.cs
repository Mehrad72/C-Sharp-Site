using System.ComponentModel.DataAnnotations;
namespace GBCSporting_Huskies.Models
{
    public class Country
    {
        [Key]
        public string CountryId { get; set;}
        public string? Name { get; set; }
    }
}
