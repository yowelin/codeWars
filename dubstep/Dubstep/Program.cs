using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubstep
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            string currentChar;
            string resultString = "";
            bool isWordStarted = false;
            input = input.Replace("WUB", " ").Trim();
            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input.Substring(i, 1);
                if (currentChar != " ")
                {
                    isWordStarted = true;
                    resultString += currentChar;
                }
                if (currentChar == " " && isWordStarted == true)
                {
                    isWordStarted = false;
                    resultString += " ";
                }
            }
            return resultString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dubstep.SongDecoder("WUBWUBABCWUB"));
            Console.WriteLine(Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
