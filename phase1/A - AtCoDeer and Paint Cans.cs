using System;
using System.Collections.Generic;
using System.Web;

namespace A___AtCoDeer_and_Paint_Cans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');
            int[] arr = new int[3];
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(input[i]);
                numbers.Add(arr[i]);
            }
            Console.WriteLine(numbers.Count.ToString());    
            
        }
    }
}
