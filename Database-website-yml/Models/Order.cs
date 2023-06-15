using System.ComponentModel.DataAnnotations;

namespace Database_website_yml.Models
{

    public class Order
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen.")]
        [Display(Name = "Voornaam:")]
        public string FIRSTNAME { get; set; }
        [Required(ErrorMessage = "Gelieve uw achternaam in te vullen.")]
        [Display(Name = "Achternaam:")]
        public string LASTNAME { get; set; }
        [EmailAddress(ErrorMessage = "Geen geldig Emailadres.")]
        [Required(ErrorMessage = "Gelieve uw emailadres in te vullen")]
        [Display(Name = "E-mail:")]
        public string EMAIL { get; set; }
        [Phone(ErrorMessage = "Geen geldig telefoonnummer")]
        [Required(ErrorMessage = "Gelieve uw telefoonnummer in te vullen")]
        [Display(Name = "Telefoon:")]
        public string TIME { get; set; }
        [Required(ErrorMessage = "Gelieve uw adres in te vullen")]
        [Display(Name = "Film:")]
        public string MOVIE { get; set; }
        [Required(ErrorMessage = "Gelieve een bericht achter te laten")]
        [Display(Name = "Bericht:")]
        public string DATE { get; set; }
    }
}