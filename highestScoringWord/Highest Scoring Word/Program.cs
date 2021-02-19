using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Scoring_Word
{
    public class Kata
    {
        public static string High(string s)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string[] splittedS = s.Split(' ');
            int maxScore = 0;
            string maxScoreWord = "";
            foreach (string word in splittedS)
            {
                int wordScore = 0;
                foreach (char ch in word)
                {
                    wordScore += letters.IndexOf(ch) + 1;
                }
                if (wordScore > maxScore)
                {
                    maxScore = wordScore;
                    maxScoreWord = word;
                }
            }
            return maxScoreWord;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.High("man i need a taxi up to ubud"));
            Console.WriteLine(Kata.High("what time are we climbing up to the volcano"));
            Console.WriteLine(Kata.High("take me to semynak"));
        }
    }
}
