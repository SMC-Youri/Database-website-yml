namespace Database_website_yml.Models
{
    public class Film
    {
        public string name;
        public string image;
        public string description;
        public string age;
        public string trailer;
        public string actor1;
        public string actor2;
        public string actor3;
        public string name1;
        public string name2;
        public string name3;

        public Film(string name, string image, string description, string age, string trailer, string actor1, string actor2, string actor3, string name1, string name2, string name3)
        {
            this.name = name;
            this.image = image; 
            this.description = description;
            this.age = age;
            this.trailer = trailer;
            this.actor1 = actor1;
            this.actor2 = actor2;
            this.actor3 = actor3;
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
        }
    }
}