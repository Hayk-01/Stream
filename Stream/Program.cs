using Stream.Fond;
using Stream.Tools;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

FolderCreater.Creat();
List<Student> students = new List<Student>();
List<Employee> employees = new List<Employee>();
List<University> universities = new List<University>();
List<Address> addresses = new List<Address>();
List<object>  Data = new List<object>();
Data.Add(students);
Data.Add(employees);
Data.Add(universities);
Data.Add(addresses);

while (true)
{
    Console.WriteLine("Select an option:\n" +
                      "1. Add Student\n" +
                      "2. Add Employee\n" +
                      "3. Add University\n" +
                      "4. Add Address\n" +
                      "5. Find Student By Name\n" +
                      "6. Save All Data\n" +
                      "7. Read All Data\n");
    int.TryParse(Console.ReadLine(), out int option);
    switch (option)
    {
        case 1:
            AddStudent();
            break;
        case 2:
            AddEmployee();
            break;
        case 3:
            AddUniversity();
            break;
        case 4:
            AddAddress();
            break;
        case 5:
            Console.WriteLine("Enter Student Name:");
            string? studentNameFoSearch = Console.ReadLine();
            Reader.FindStudentByName(studentNameFoSearch!, students);
            break;
        case 6:
            Writer.SaveData(Data);
            break;
        case 7:
            Reader.Read();
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}

void AddStudent()
{
    Console.WriteLine("Enter Student Id:");
    string? studentId = Console.ReadLine();
    Console.WriteLine("Enter Student Name:");
    string? studentName = Console.ReadLine();
    Console.WriteLine("Enter Student UniversityId:");
    string? studentUniversityId = Console.ReadLine();
    Console.WriteLine("Enter Student University Name:");
    string? studentUniversityName = Console.ReadLine();
    students.Add(new Student(studentId, studentName, studentUniversityId,
        studentUniversityName));
}
void AddEmployee()
{
    Console.WriteLine("Enter Employee Id:");
    string? employeeId = Console.ReadLine();
    Console.WriteLine("Enter Employee Name:");
    string? employeeName = Console.ReadLine();
    Console.WriteLine("Enter Employee UniversityId:");
    string? employeeUniversityId = Console.ReadLine();
    Console.WriteLine("Enter Employee University Name:");
    string? employeeUniversityName = Console.ReadLine();
    employees.Add(new Employee(employeeId, employeeName,
        employeeUniversityId, employeeUniversityName));
}
void AddUniversity()
{
    Console.WriteLine("Enter University Id:");
    string? universityId = Console.ReadLine();
    Console.WriteLine("Enter University Name:");
    string? universityName = Console.ReadLine();
    Console.WriteLine("Enter University City:");
    string? universityCity = Console.ReadLine();
    universities.Add(new University(universityId, universityName, universityCity));
}
void AddAddress()
{
    Console.WriteLine("Enter Address Id:");
    string? addressId = Console.ReadLine();
    Console.WriteLine("Enter Address Country:");
    string? addressCountry = Console.ReadLine();
    Console.WriteLine("Enter Address CityOrTown:");
    string? addressCityOrTown = Console.ReadLine();
    Console.WriteLine("Enter Address Street:");
    string? addressStreet = Console.ReadLine();
    Console.WriteLine("Enter Address Apartment:");
    string? addressApartment = Console.ReadLine();
    Console.WriteLine("Enter Address PostalCode:");
    string? addressPostalCode = Console.ReadLine();
    addresses.Add(new Address(addressId, addressCountry, addressCityOrTown,
        addressStreet, addressApartment, addressPostalCode));
}