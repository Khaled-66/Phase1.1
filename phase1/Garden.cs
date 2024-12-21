using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine((arr[0]-1) * (arr[1]-1));
        }
    }
}
