namespace Stream.Tools
{
    public class FolderCreater
    {
        const string folderName = "Data";
        public const string fileName = "Data.json";
        public readonly static string path = Path.Combine(folderName, fileName);
       
        public static void Creat()
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            if (!File.Exists(path))
            {
                using (var StudentFile = File.Create(path)) { }
            }
        }

    }
}
