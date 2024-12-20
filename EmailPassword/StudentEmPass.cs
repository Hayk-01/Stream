

namespace EmailPassword
{
    public class Student
    {
        public string? Email { get; set; }
        public string? Password { get; set; }

        public Student()
        {
            
        }
        public Student(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
