namespace Stream.Fond
{
    public class University
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

        public University()
        {
            
        }

        public University(string? id, string? name, string? city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
