namespace Aula13CredPeopleEF.Models
{
    public class City
    {
        public City() { }

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int id { get; set; }
        public string name { get; set; }
    }
}