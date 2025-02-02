using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Floor(n/2)*Math.Round(n/2));
        }
    }
}
