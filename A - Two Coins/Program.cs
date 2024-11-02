using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Two_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');
            int[] arr=new int[input.Length];
            for(int i=0; i<input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);   
            }
            if (arr[0] + arr[1] >= arr[2])
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }
    }
}
