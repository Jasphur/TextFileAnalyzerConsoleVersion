using System;
using System.IO;

namespace TextAnalyzerConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking user for a file to analyze
            Console.WriteLine("Enter the complete path of the file you would like to analyze, including the file name: ");
            var UserFilePath = Console.ReadLine();

            var UserFile = new BasicTextAnalyzer();

            // Displaying basic analyzing results
            UserFile.UserFileReader(UserFilePath);

            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit..");
            Console.ReadLine();
        }
    }
}
