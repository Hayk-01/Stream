

namespace Stream
{
    public class FolderPath
    {
        const string folderName = "Data";
        const string fileName = "DataInfo.txt";
        public readonly static string path = Path.Combine(folderName, fileName);
        public static void Creat()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(folderName);
            }
            if (!File.Exists(path))
            {
                using (var e = File.Create(path)) { }
            }
        }

    }
}
