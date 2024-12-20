
namespace Events
{
    public class StudentEv
    {
        public string? Name { get; set; }
        public string? Age { get; set; }

        public StudentEv()
        {
            
        }
        public StudentEv(string name, string age)
        {
            Name = name;
            Age = age;
            
        }
    }
}
