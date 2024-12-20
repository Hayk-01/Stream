using NameValidation;

while (true)
{
    Console.WriteLine("Write Name To Check");
    string? input = Console.ReadLine();
    try
    {
        ValidateName.ValidName(input!);
    }
    catch (InvalidNameException ex)
    {
        Console.WriteLine(ex.Message);
    }
}