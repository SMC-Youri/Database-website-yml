using System.ComponentModel.DataAnnotations;

namespace Database_website_yml.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen.")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Gelieve uw achternaam in te vullen.")]
        public string lastname { get; set; }
        [EmailAddress(ErrorMessage = "Geen geldig Emailadres.")]
        [Required(ErrorMessage = "Gelieve uw Emailadres in te vullen")]
        public string email { get; set; }
        [Required(ErrorMessage = "Gelieve uw telefoonnummer in te vullen")]
        public string phone { get; set; }
        public string address { get; set; }
        public string description { get; set; }
    }
}