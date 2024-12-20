
namespace NameValidation
{
    public class ValidateName
    {
        public static void ValidName(string name)
        {
            foreach (char c in name)
            {
                if (char.IsWhiteSpace(c) || char.IsDigit(c))
                {
                    throw new InvalidNameException("\nName Is Not Valid");
                }
            }
            Console.WriteLine("\nName Is Valid");
        }
    }
}
