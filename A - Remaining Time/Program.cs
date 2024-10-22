using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Remaining_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s =Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);    
            int b = int.Parse(s[1]);
            if (a + b < 24)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine((a+b)-24);
            }

        }
    }
}
