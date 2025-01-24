using EmailPassword;
using EmailPassword.Exceptions;

namespace Stream.EmailPassword.Tests

{
    public class CreateStudentTests
    {
        [Fact]
        public void StudentCreate_ShouldReturnStudent_WhenValidEmailAndPassword()
        {
            // Arrange
            string email = "t@gmail.com";
            string password = "pass123";

            // Act
            var student = CreateStudent.StudentCreate(email, password);

            // Assert
            Assert.NotNull(student);
            Assert.Equal(email, student.Email);
            Assert.Equal(password, student.Password);
        }
    }

    public class LogInTests
    {
        [Fact]
        public void LogIn_ShouldSucceed_WhenValidCredentials()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student("t@gmail.com", "pass123")
            };
            string email = "t@gmail.com";
            string password = "pass123";

            // Act & Assert
            var exception = Record.Exception(() => LogIn.Log_In(email, password, students));
            Assert.Null(exception); // No exception should be thrown
        }

        [Fact]
        public void LogIn_ShouldThrowLogPassException_WhenInvalidEmail()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student("t@gmail.com", "pass123")
            };
            string email = "t@gmail.com";
            string password = "pass123";

            // Act & Assert
            var exception = Assert.Throws<LogPassException>(() => LogIn.Log_In(email, password, students));
            Assert.Equal("Wrong Email Or Password", exception.Message);
        }

        [Fact]
        public void LogIn_ShouldThrowLogPassException_WhenInvalidPassword()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student("t@gmail.com", "pass123")
            };
            string email = "t@gmail.com";
            string password = "pass123";

            // Act & Assert
            var exception = Assert.Throws<LogPassException>(() => LogIn.Log_In(email, password, students));
            Assert.Equal("Wrong Email Or Password", exception.Message);
        }

        [Fact]
        public void LogIn_ShouldThrowLogPassException_WhenEmailDoesNotExist()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student("t@gmail.com", "pass123")
            };
            string email = "t@gmail.com.com";
            string password = "pass123";

            // Act & Assert
            var exception = Assert.Throws<LogPassException>(() => LogIn.Log_In(email, password, students));
            Assert.Equal("Wrong Email Or Password", exception.Message);
        }
    }
}
