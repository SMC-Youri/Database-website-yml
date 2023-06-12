namespace Database_website_yml.Models
{
    public class Film
    {
        public string name;
        public string description;
        public int age;

        public Film(string name, string description, int age)
        {
            this.name = name;
            this.description = description;
            this.age = age;
        }
    }
}