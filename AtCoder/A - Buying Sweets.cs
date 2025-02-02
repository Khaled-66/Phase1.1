using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Buying_Sweets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r = (x - a) % b;
            System.Console.WriteLine(r);
        }
    }
}
