namespace Stream.Fond
{
    public class Student
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? UniversityId { get; set; }
        public string? UniversityName { get; set; }

        public Student()
        {
                
        }

        public Student(string? id, string? name, string? universityId, string? universityName)
        {
            Id = id;
            Name = name;
            UniversityId = universityId;
            UniversityName = universityName;
        }
    }
}
