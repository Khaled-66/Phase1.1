using System;

namespace A___Fighting_over_Candies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);    
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);
            if (x + y == z || x + z == y || x == y + z)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
    }
