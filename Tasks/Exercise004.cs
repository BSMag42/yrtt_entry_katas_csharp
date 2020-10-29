using System;

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
                var first = word.Substring(0, 1);
                var second = word.Substring(1, word.Length-1);
                pigPhrase += (second + first + "ay ");
            }
            pigPhrase = pigPhrase.Trim(' ');
            return pigPhrase;
        }
    }
}

