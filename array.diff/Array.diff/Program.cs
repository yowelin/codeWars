using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            for (int j = 0; j < b.Length; j++)
            {
                a = a.Where(val => val != b[j]).ToArray();
            }
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int elem in Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }))
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
            foreach (int elem in Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }))
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
            foreach (int elem in Kata.ArrayDiff(new int[] { 1, 2, 2, 3, 4, 4, 2 }, new int[] { 2 }))
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
            foreach (int elem in Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }))
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
            foreach (int elem in Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }))
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
        }
    }
}
