using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name:");
            string userDirectory = Console.ReadLine();

            string newdirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newdirectoryFullPath);

            bool directoryExists = Directory.Exists(newdirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exists in {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory(newdirectoryFullPath);
                Console.WriteLine($"Directory {userDirectory} has been created.");
            }

            
        }
    }
}
