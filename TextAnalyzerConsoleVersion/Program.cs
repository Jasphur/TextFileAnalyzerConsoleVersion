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
            //var UserFilePath = Console.ReadLine();
            var UserFilePath = @"C:\Users\Jasper\Desktop\TestFile.txt";

            var UserFile = new BasicTextAnalyzer();
            var UserFileAdvanced = new AdvancedTextAnalyzer();

            // Displaying basic analyzing results
            UserFile.UserFileReader(UserFilePath);

            UserFileAdvanced.UniqueWords(UserFilePath);
            

            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit..");
            Console.ReadLine();
        }
    }
}
