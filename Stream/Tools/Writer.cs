using Newtonsoft.Json;


namespace Stream.Tools
{
    public class Writer
    {
        public static void SaveData(IEnumerable<object> items)
        {
            string json = JsonConvert.SerializeObject(items);

            File.WriteAllText(FolderCreater.path, json);
        }
    }
}
