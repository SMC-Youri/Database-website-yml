namespace Database_website_yml.Models
{
    public class Film
    {
        public string name;
        public string image;
        public string description;
        public string age;
        public string trailer;

        public Film(string name, string image, string description, string age, string trailer)
        {
            this.name = name;
            this.image = image; 
            this.description = description;
            this.age = age;
            this.trailer = trailer;
        }
    }
}