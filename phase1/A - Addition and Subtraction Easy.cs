using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Addition_and_Subtraction_Easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);    
            int b= int.Parse(s[2]);
            char c = char.Parse(s[1]);
            if (c=='+')
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine(a - b);
            }
        }
    }
}
