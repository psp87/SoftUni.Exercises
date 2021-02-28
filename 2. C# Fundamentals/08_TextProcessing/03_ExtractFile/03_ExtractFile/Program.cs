using System;

namespace _03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int indexFileName = input.LastIndexOf('\\') + 1;
            int indexFileExtension = input.LastIndexOf('.');

            string fileName = input.Substring(indexFileName, indexFileExtension-indexFileName);
            string fileExtension = input.Substring(indexFileExtension + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
