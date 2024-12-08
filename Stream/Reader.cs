

namespace Stream
{
    public class Reader
    {
      public static void  Read()
        {
            using (StreamReader reader = new StreamReader(FolderPath.path))
            {
                while (true)
                {
                    string? Line = reader.ReadLine();
                    if (Line is null)
                    {
                        break;
                    }
                    string[] parameters = Line!.Split("|");
                    foreach (string parameter in parameters)
                    {
                        Console.WriteLine(parameter);
                    }                  
                }
            }
        }
    }
}
