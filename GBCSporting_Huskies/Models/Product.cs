using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBCSporting_Huskies.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a product code")]
        public string? Code { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a yearly price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? YearPr { get; set; }

        [Required(ErrorMessage = "Please enter a release date")]
        public DateTime? RelDate { get; set; }

        public string Slug
        {
            get
            {
                if (Name == null)
                    return "";
                else
                    return Name.Replace(' ', '-');
            }
        }


    }
}
