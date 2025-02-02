using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 7, 8, 10, 12 }, arr2 = { 4, 6, 9, 11 };// arr3 = { 2 };
            string[] s = Console.ReadLine().Split(' '); //int count = 2;
            int a = int.Parse(s[0]), b = int.Parse(s[1]);
            if (a == 2 || b == 2) { Console.WriteLine("NO"); }
            else if (arr1.Contains(a) && arr1.Contains(b)) { Console.WriteLine("YES"); }
            else if (arr2.Contains(a) && arr2.Contains(b)) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
