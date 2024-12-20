

using Events;

UniversityEv.OnAdd += student => Console.WriteLine("Student Added");
UniversityEv.OnRemove += student => Console.WriteLine("Student Removed");

while (true)
{
    Console.WriteLine("Select an option:\n" +
                      "1. Add Student\n" +
                      "2. Remove Student\n" +
                      "3. View Students List");
    int.TryParse(Console.ReadLine(), out int option);
    switch (option)
    {
        case 1:
            StudentAdd();
            break;
        case 2:
            StudentRemove();
            break;
        case 3:
            UniversityEv.DisplayStudents();
            break;
        default:
            break;
    }
}
void StudentAdd()
{
    Console.WriteLine("Enter Student Name");
    string? studentName = Console.ReadLine();
    Console.WriteLine("Enter Student Age");
    string? studentAge = Console.ReadLine();
    UniversityEv.AddStudent(new StudentEv(studentName!, studentAge!));
}
void StudentRemove()
{
    Console.WriteLine("Enter Student Name");
    string? studentNameR = Console.ReadLine();
    UniversityEv.RemoveStudent(studentNameR!);
}