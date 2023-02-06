using System.Text;

namespace Game_2048
{
    public class FileProvider
    {
        public static void Replace(string path, string value)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string Get(string path)
        {
            return File.ReadAllText(path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
