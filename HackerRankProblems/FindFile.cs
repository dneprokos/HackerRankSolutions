using System.IO;


namespace HackerRankProblems
{
    public class FindFile
    {
        public static string GetFileByRootDirectory(string fileName, string rootDirectory)
        {          
            string filePath = Path.Combine(rootDirectory, fileName);
            if (File.Exists(filePath)) return filePath;

            foreach (var directory in Directory.GetDirectories(rootDirectory))
            {
                var result = GetFileByRootDirectory(fileName, directory);
                if (result != null) return result;
            }

            return null;            
        }
    }
}
