using System;

namespace codeWars_1
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            char[] ch = { };
            ch = str.ToCharArray();
            str = String.Empty;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '-' || ch[i] == '_')
                {
                    str += ch[i + 1].ToString().ToUpper();
                    i++;
                }
                else
                {
                    str += ch[i].ToString();
                }
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("the_stealth_warrior"));
            Console.WriteLine(Kata.ToCamelCase("The-Stealth-Warrior"));
            Console.ReadLine();
        }
    }
}