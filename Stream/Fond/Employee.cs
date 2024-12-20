namespace Stream.Fond
{
    public class Employee
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? UniversityId { get; set; }
        public string? UniversityName { get; set; }

        public Employee()
        {
            
        }

        public Employee(string? id, string? name, string? universityId, string? universityName)
        {
            Id = id;
            Name = name;
            UniversityId = universityId;
            UniversityName = universityName;
        }
    }
}
