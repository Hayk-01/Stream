

namespace EmailPassword
{
    public class CreateStudent
    {
        public static Student StudentCreate(string email, string password)
        {  
            Console.WriteLine("Student Added");
            return (new Student(email, password));
        }
    }
}
