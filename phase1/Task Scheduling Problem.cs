using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Scheduling_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr=input.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            Console.WriteLine(arr[2] - arr[0]);
        }
    }
}
