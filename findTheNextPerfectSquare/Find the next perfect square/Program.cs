using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_next_perfect_square
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            double sqrtOfParam = Math.Sqrt(num);
            int integralSqrtOfParam;
            if (int.TryParse(sqrtOfParam.ToString(), out integralSqrtOfParam))
            {
                return (long)Math.Pow(integralSqrtOfParam + 1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindNextSquare(155));
            Console.WriteLine(Kata.FindNextSquare(121));
            Console.WriteLine(Kata.FindNextSquare(625));
            Console.WriteLine(Kata.FindNextSquare(319225));
            Console.WriteLine(Kata.FindNextSquare(15241383936));
        }
    }
}
