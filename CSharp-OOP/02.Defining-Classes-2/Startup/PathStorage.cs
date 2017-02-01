namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class PathStorage
    {
        public static void StorePoints(Path paths)
        {
            using (StreamWriter writer = new StreamWriter("/Paths/points.txt", true))
            {
                foreach (var item in paths)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static IEnumerable<string> LoadPaths()
        {
            List<string> paths = new List<string>();
            using (StreamReader reader = new StreamReader("/Paths/points.txt", true))
            {
                paths.AddRange(reader.ReadToEnd().Trim().Split(new[] { '\n', '\r' }));
            }
            return paths;
        }
    }
}
