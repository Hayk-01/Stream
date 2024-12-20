

namespace Events
{
    public class UniversityEv
    {
        public static List<StudentEv> Students { get; set; } = new List<StudentEv>();

        public static event Action<StudentEv> OnAdd;
        public static event Action<StudentEv> OnRemove;

        public static void AddStudent(StudentEv student)
        {
            Students.Add(student);
            OnAdd?.Invoke(student);
        }

        public static void RemoveStudent(string name)
        {
            var studentToRemove = Students.Find(s => s.Name == name);
            if (studentToRemove != null)
            {
                Students.Remove(studentToRemove);
                OnRemove?.Invoke(studentToRemove);
            }
            else
            {
                Console.WriteLine("Student Not Found.");
            }       
        }

        public static void DisplayStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No Students In The List.");
            }

            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Name}\n{student.Age}");
            }
        }
    }
}
