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
        [Required(ErrorMessage = "Gelieve uw emailadres in te vullen")]
        public string email { get; set; }
        [Phone(ErrorMessage = "Geen geldig telefoonnummer")]
        [Required(ErrorMessage = "Gelieve uw telefoonnummer in te vullen")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Gelieve uw adres in te vullen")]
        public string address { get; set; }
        [Required(ErrorMessage = "Gelieve een bericht achter te laten")]
        public string message { get; set; }
    }
}