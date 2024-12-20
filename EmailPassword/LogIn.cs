using EmailPassword.Exceptions;

namespace EmailPassword
{
    public class LogIn
    {
        public static void Log_In(string email, string password, List<Student> students)
        {
            var student = students.Find(s => s.Email == email);

            if (student == null || student!.Password != password)
            {
                throw new LogPassException("Wrong Email Or Password");
            }
            Console.WriteLine("Successful Login");
        }
    }
}
