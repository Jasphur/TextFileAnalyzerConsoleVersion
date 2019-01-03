using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextAnalyzerConsoleVersion
{
    class BasicTextAnalyzer
    {
        int charCount = 0;
        int whiteSpaceCount = 0;
        int wordCount = 0;
        string Separators = ",. ?!";
        string line;

        public void UserFileReader(string UserFilePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(UserFilePath))
                {
                    // Reading the file
                    while ((line = sr.ReadLine()) != null)
                    {
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
                    }
                    // returning basic anaylazing results
                    Console.WriteLine("");
                    Console.WriteLine("The number of characters used: " + charCount);
                    Console.WriteLine("The number of characters used without space: " + (charCount - whiteSpaceCount));
                    Console.WriteLine("Number of words: " + wordCount);
                }
            }
            catch (Exception e)
            {
                // Error message when file cannot be read
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

