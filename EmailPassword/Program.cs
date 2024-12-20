using EmailPassword;
using EmailPassword.Exceptions;

List<Student> students = new List<Student>();

while (true)
{
    Console.WriteLine("Select an option:\n" +
                      "1. Create New Student\n" +
                      "2. Log In");
    int.TryParse(Console.ReadLine(), out int option);
    switch (option)
    {
        case 1:
            Option1();
            break;
        case 2:
            Option2();
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}
void Option1()
{
    Console.WriteLine("New Student Email:");
    string? email = Console.ReadLine();
    Console.WriteLine("New Student Password:");
    string? password = Console.ReadLine();
    students.Add(CreateStudent.StudentCreate(email!, password!));
}
void Option2()
{
    Console.WriteLine("Enter Your Email");
    string? loginEmail = Console.ReadLine();
    Console.WriteLine("Enter You Password");
    string? loginPassword = Console.ReadLine();
    try
    {
        LogIn.Log_In(loginEmail!, loginPassword!, students);
    }
    catch (LogPassException ex)
    {
        Console.WriteLine(ex.Message);
    }
}