using System.ComponentModel.DataAnnotations;

namespace Database_website_yml.Models
{

    public class Order
    {
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string EMAIL { get; set; }
        public string TIME { get; set; }
        public string MOVIE { get; set; }
        public string DATE { get; set; }
        public string SEAT { get; set; }
    }
}