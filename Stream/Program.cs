using Stream;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

FolderPath.Creat();

IEnumerable<Student> students = new List<Student>()
{
    new Student(){Id = 1,Name = "Պողոս", UniversityId = 1}
};

IEnumerable<University> universities = new List<University>()
{
    new University(){ Id = 1, Name = "National",City = "Yerevan"}
};

IEnumerable<Employee> employees = new List<Employee>()
{
    new Employee(){Id = 1,Name = "Պետրոս", UniversityId = 1}
};

List<object> allData = new List<object>();
allData.AddRange(students);
allData.AddRange(universities);
allData.AddRange(employees);

Writer.Write(allData);
Reader.Read();
