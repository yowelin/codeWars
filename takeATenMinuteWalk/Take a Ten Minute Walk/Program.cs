using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_a_Ten_Minute_Walk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            int[] start = new int[] { 0, 0 };
            int[] end = new int[] { 0, 0 }; ;
            if (walk.Length == 10)
            {
                for (int i = 0; i < walk.Length; i++)
                {
                    if (walk[i] == "n")
                    {
                        end[1] += 1;
                    }
                    if (walk[i] == "s")
                    {
                        end[1] -= 1;
                    }
                    if (walk[i] == "w")
                    {
                        end[0] -= 1;
                    }
                    if (walk[i] == "e")
                    {
                        end[0] += 1;
                    }
                }
                if (start[0] == end[0] && start[1] == end[1])
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Console.WriteLine(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            Console.WriteLine(Kata.IsValidWalk(new string[] { "w" }));
            Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }
    }
}
