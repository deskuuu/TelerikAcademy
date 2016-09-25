namespace _01._3D_Space
{
    using System;
    using System.IO;

    public class PathStorage
    {
        //    Create a static class PathStorage with static methods to save and load paths from a text file.
        public static void SavePath(Common.Path path, string storage)
        {
            StreamWriter sWriter = new StreamWriter(storage);
            using (sWriter)
            {
                for (int i = 0; i < path.Count(); i++)
                {
                    sWriter.WriteLine($"Point: {path[i]}");
                }
            }
        }

        public static void LoadPath(string storage)
        {
           // var storage = "..//..//Common/sample.txt";
            try
            {
                using (StreamReader sr = new StreamReader(storage))
                {
                    // Read the stream to a string, and write the string to the console.
                    var line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}