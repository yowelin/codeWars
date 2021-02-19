using System;

namespace ExesandOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.XO("xmo"));
            Console.WriteLine(Kata.XO("xxOo"));
            Console.WriteLine(Kata.XO("xxxm"));
            Console.WriteLine(Kata.XO("Oo"));
            Console.WriteLine(Kata.XO("ooom"));
            Console.ReadLine();
        }
    }
    public static class Kata
    {
        public static bool XO(string input)
        {
            int xCount = 0, oCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().ToLower() == "x".ToString())
                {
                    xCount++;
                }
                if (input[i].ToString().ToLower() == "o".ToString())
                {
                    oCount++;
                }
            }
            return xCount == oCount;
        }
    }
}
