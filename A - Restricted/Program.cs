using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Restricted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]), b = int.Parse(s[1]);
            int sum = a + b; 
            Console.WriteLine(a + b >= 10 ? "error" : sum.ToString());
        }
    }
}
