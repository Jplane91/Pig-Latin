using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what you want translated:");
            string english = Console.ReadLine();
            string pigLatin = "";
            string firstLetter;
            string restOfWord;
            string vowels = "AEIOUaeiou";
            int letterPos;
            foreach (string word in english.Split())
            {
                firstLetter = word.Substring(0, 1);
                restOfWord = word.Substring(1, word.Length - 1);
                letterPos = vowels.IndexOf(firstLetter);
                if (letterPos == -1)
                {
                    pigLatin = restOfWord + firstLetter + "ay";
                }
                else
                {
                    pigLatin = word + "way";
                }
                Console.Write(pigLatin + " ");
            }
        }
    }
}