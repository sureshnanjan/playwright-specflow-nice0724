using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Assignment_2
    {
        public void EnsureDirectoryExists(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            // Check if the directory exists
            if (!directoryInfo.Exists)
            {
                // If not exists, create the directory
                directoryInfo.Create();
                Console.WriteLine("Directory created: "+directoryPath);
            }
            else
            {
                Console.WriteLine("Directory already exists: "+directoryPath);
            }
        }
        public void CreateTextFiles(string directoryPath)
        {
            string[] fileNames = { "Kiran.txt", "NICE.txt", "Pune.txt" };
            string[] fileContents = { "Kiran Hirulkar", "NICE", "Pune, Maharashtra" };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);
                File.WriteAllText(filePath, fileContents[i]);
                Console.WriteLine("File created: "+filePath);
            }
        }
        public void DisplayFileDetails(string directoryPath)
        {
            string[] fileNames = { "Kiran.txt", "NICE.txt", "Pune.txt" };

            foreach (string fileName in fileNames)
            {
                string filePath = Path.Combine(directoryPath, fileName);
                FileInfo fileInfo = new FileInfo(filePath);

                Console.WriteLine("\nFile Details:");
                Console.WriteLine("Full Name: "+fileInfo.FullName);
                Console.WriteLine("Creation Time: "+fileInfo.CreationTime);
                Console.WriteLine("Size: "+fileInfo.Length+" bytes");
            }
        }
    }
}
