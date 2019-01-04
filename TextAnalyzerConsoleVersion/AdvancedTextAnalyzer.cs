using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace TextAnalyzerConsoleVersion
{
    class AdvancedTextAnalyzer
    {
        int uniqueWordCount;
        //string Separators = ",. ?!";
        string line;
        IEnumerable<string> wordQuery;

        public void UniqueWords(string UserFilePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(UserFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {

                        Regex reg_exp = new Regex("[^a-z A-Z 0-9]");
                        line = reg_exp.Replace(line, " ");

                        string[] words = line.Split(
                            new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries);

                        wordQuery = (from string word in words select word).Distinct();

                        foreach (var word in wordQuery)
                        {
                            uniqueWordCount++;
                        }
                    }
                }
                Console.WriteLine("Number of unique words: " + uniqueWordCount);
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
