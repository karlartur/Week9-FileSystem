using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "wishList";

            string newdirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newdirectoryFullPath);

            Directory.CreateDirectory(newdirectoryFullPath);
        }
    }
}
