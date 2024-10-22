using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Two_Rectangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');
            int[] arr = new int[4];
            for(int i = 0; i < input.Length; i++)
            {
                arr[i]= int.Parse(input[i]);
            }
            Console.WriteLine(Math.Max(arr[0] * arr[1], arr[2] * arr[3]));
        }
    }
}
