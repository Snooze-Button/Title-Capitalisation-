using System;
using System.Collections.Generic;
using System.Linq;

namespace TitleCaseTestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                //Lower Case Test
                /* 
                string testSentence = "AA THE TO AT IN WITH AND BUT OR";

                string makeItLowerCase = testSentence.Substring(1).ToLower();

                //Prediction: it will make the second A lowercase because (1) index
                //Result: all string is in lower Case

                Console.WriteLine(makeItLowerCase);*/

                //Take in Input
                Console.WriteLine("\nPlease enter your sentence to correct");
                string sentence = Console.ReadLine();

                //Split sentence on spaces(null)
                string[] wordFromSentence = sentence.Split(null);

                var lowerCaseSentences = new List <string> {"a", "the" , "to", "at" , "in", "with", "and", "but" , "or"};

                string correctedWords = "";
                int lastWord = wordFromSentence.Length - 1;

                //Converts bad words to LowerCase and First/Last/Other words to Uppercase 
                foreach (string word in wordFromSentence)
                { 
                    if(word == wordFromSentence[0])
                    {
                        correctedWords += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    }
                    else if(word == wordFromSentence[lastWord])
                    {
                        correctedWords += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    }
                   else if (lowerCaseSentences.Contains(word, StringComparer.OrdinalIgnoreCase)){
                        correctedWords += word.ToLower() + " ";
                    }
                   else
                    {
                        correctedWords += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    }
                }

                Console.WriteLine(correctedWords);

            }

        }
    }
}
