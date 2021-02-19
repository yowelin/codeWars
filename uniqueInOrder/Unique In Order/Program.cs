using System;
using System.Collections.Generic;

namespace Unique_In_Order
{
    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var e = iterable.GetEnumerator();
            if (e.MoveNext())
            {
                var c = e.Current;
                while (e.MoveNext())
                {
                    if (!e.Current.Equals(c))
                    {
                        yield return c;
                    }
                    c = e.Current;
                }
                yield return c;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<char> lst = new List<char>() { };
            lst = Kata.UniqueInOrder("AAAABBBCCDAABBB");
            foreach (char elem in lst)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
