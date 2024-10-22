using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            int tot = 800 * x;
            while (x >= 15)
            {
                x -= 15;
                tot -= 200;
            }
            Console.WriteLine(tot);
        }
    }
}
