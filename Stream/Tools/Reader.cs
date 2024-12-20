using Newtonsoft.Json;
using Stream.Fond;

namespace Stream.Tools
{
    public class Reader
    {
        public static void Read()
        {
            string json = File.ReadAllText(FolderCreater.path);
            var items = JsonConvert.DeserializeObject<List<object>>(json);

            foreach (var item in items!)
            {
                Console.WriteLine(item.ToString());
            }       
        }
        public static void FindStudentByName(string studentName,List<Student> students)
        {
            var student = students.FirstOrDefault(s => s.Name == studentName);
            if (student != null)
            {
                Console.WriteLine($"{student.Name} is studying at {student.UniversityName}.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
