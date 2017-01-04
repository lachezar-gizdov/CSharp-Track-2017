namespace Points
{
    using System;
    using System.IO;

    class PathStorage
    {
        public static void StorePoints()
        {
            using (StreamWriter stream = new StreamWriter("paths.txt"))
            {
                stream.WriteLine();
            }
        }
    }
}
