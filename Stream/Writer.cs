using System;
using System.Collections.Generic;


namespace Stream
{
    public class Writer
    {
        public static void Write<T>(IEnumerable<T> items)
        {
            using (StreamWriter writer = new StreamWriter(FolderPath.path))
            {
                foreach (var item in items)
                {
                    Type type = item!.GetType();
                    string line = $"{type.FullName}";
                    foreach (var prop in type.GetProperties())
                    {
                        line += $",{prop.GetValue(item)}";
                    }
                    writer.WriteLine($"{line} | ");
                }
            }

        }
    }
}
