using System.ComponentModel.DataAnnotations;

namespace Database_website_yml.Models
{

    public class Order
    {
        [Required]
        public string FIRSTNAME { get; set; }
        [Required]
        public string LASTNAME { get; set; }
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string TIME { get; set; }
        [Required]
        public string MOVIE { get; set; }
        [Required]
        public string DATE { get; set; }
    }
}