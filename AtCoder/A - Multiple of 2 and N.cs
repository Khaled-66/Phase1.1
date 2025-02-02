using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Multiple_of_2_and_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine(x%2==0?x:2*x);
        }
    }
}
