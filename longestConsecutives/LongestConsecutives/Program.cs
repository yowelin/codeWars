using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutives
{
    public class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            string consecString = "";
            int maxLength = 0;
            string maxString = "";
            for (int i = 0; i < strarr.Length - k + 1; i++)
            {
                consecString = "";
                for (int j = i; j < i + k; j++)
                {
                    consecString += strarr[j];
                }
                //Console.WriteLine(consecString);
                if (consecString.Length > maxLength)
                {
                    maxLength = consecString.Length;
                    maxString = consecString;
                }
            }
            return maxString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
            LongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1);
            LongestConsecutives.LongestConsec(new String[] { }, 3);
            LongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2);
            LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2);
            LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2);
            LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3);
            LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15);
            LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0);
        }
    }
}
