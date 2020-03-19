using System.IO;


namespace HackerRankProblems
{
    public static class FileHelper
    {
        public static string GetFilePath(string fileName, string rootDirectory)
        {          
            string filePath = Path.Combine(rootDirectory, fileName);
            if (File.Exists(filePath))
                return filePath;

            foreach (string directory in Directory.GetDirectories(rootDirectory))
            {
                string result = GetFilePath(fileName, directory);
                if (result != null)
                    return result;
            }

            return null;            
        }
    }
}
