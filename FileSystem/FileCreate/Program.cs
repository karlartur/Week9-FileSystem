using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishList";
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();
            string fullfilePath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullfilePath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exixtsin {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"WishList directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            else
            {
                File.Exists(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
        }
            
            

        
    }
}
