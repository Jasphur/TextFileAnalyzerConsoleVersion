using System;
using System.IO;

namespace TextAnalyzerConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    int charCount = 0;
                    int whiteSpaceCount = 0;
                    int lineCount = 0;
                    int wordCount = 0;
                    string Separators = ",. ?!";
                    string line;

                    // Reading the file
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineCount++;

                        foreach (var c in line)
                        {
                            // Character count
                            charCount++;

                            // Whitespace count, so character count without spaces can be calculated.
                            if (Char.IsWhiteSpace(c))
                                whiteSpaceCount++;

                            // Word counter
                            if (Separators.Contains(c))
                            {
                                wordCount++;
                            }
                        }

                        Console.WriteLine(line);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("The number of characters used: " + charCount);
                    Console.WriteLine("The number of characters used without space: " + (charCount - whiteSpaceCount));
                    Console.WriteLine("Number of words: " + wordCount);
                    Console.WriteLine("Number of lines: " + lineCount);
                }
            }
            catch (Exception e)
            { 
                // Error message when file cannot be read
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit..");
            Console.ReadLine();
        }
    }
}
