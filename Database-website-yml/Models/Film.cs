namespace Database_website_yml.Models
{
    public class Film
    {
        public string name;
        public string image;
        public string description;
        public int age;

        public Film(string name, string image, string description, int age)
        {
            this.name = name;
            this.image = image; 
            this.description = description;
            this.age = age;
        }
    }
}