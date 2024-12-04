using Stream;

string path = "MyClass";
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}
using (StreamWriter writer = new StreamWriter(Path.Combine(path, "MyClassFile.txt")))
{
    writer.WriteLine(new University());
    writer.WriteLine(new Employee());
    writer.WriteLine(new Student());
}
using (StreamReader reader = new StreamReader(Path.Combine(path, "MyClassFile.txt")))
{
    string? data = reader.ReadToEnd();
    Console.WriteLine(data);
}