using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);    
            int b = int.Parse(input[1]);
            if ((a * b) % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }

        }
    }
}
