using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Cats_and_Dogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');   
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            if (a <= c && a + b >= c)
            {
                Console.WriteLine("Yes");
            }
            else
            {

                Console.WriteLine("No");                }
            
        }
    }
}
