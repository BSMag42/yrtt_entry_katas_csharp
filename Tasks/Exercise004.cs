using System;
using System.Text.RegularExpressions;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            string[] words = str.Split(' ');
            string pigPhrase = "";

            foreach (var word in words)
            {
                string firstLetter = word.Substring(0, 1);
                string secondWord = word.Substring(1, word.Length - 1);
                //match any word followed by !
                string pattern = "(\\w+)(!+)$";

                MatchCollection matchWords = Regex.Matches(secondWord, pattern);    
                if (matchWords.Count > 0)
                {
                    foreach (Match match in matchWords)
                    {
                        pigPhrase += (match.Groups[1] + firstLetter + "ay" + match.Groups[2]);
                    }
                }
                else 
                {
                    pigPhrase += (secondWord + firstLetter + "ay ");
                }
            }

            pigPhrase = pigPhrase.Trim(' ');
            return pigPhrase;
        }
    }
}

