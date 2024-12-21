using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Day_of_Takahashi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            System.Console.WriteLine(a <= b ? a : a-1);

        }
    }
}
