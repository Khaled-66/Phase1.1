using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___AC_or_WA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b= int.Parse(input[1]);
            Console.WriteLine(a == b ? "Yes" : "No");
        }
    }
}
