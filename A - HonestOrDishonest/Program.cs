using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___HonestOrDishonest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(' ');
            char c1 = s[0][0];
            char c2 = s[1][0];
            if (c1 == 'H')
            {
                Console.WriteLine(c2);
            }
            else
            {
                Console.WriteLine(c2=='D'?"H":"D");
            }
        }
    }
}
