using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Serval_vs_Monster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int h = int.Parse(inputs[0]);
            int n = int.Parse(inputs[1]);
            Console.WriteLine(h%n == 0? (h/n): (h/n)+1);
        }
    }
}
