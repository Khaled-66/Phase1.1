using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Something_on_It
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1= Console.ReadLine();
            int c1 = 0;
            foreach (char c in s1) {
                if (c == 'o')
                {
                    c1++;
                }
            }
            Console.WriteLine(c1 == 0 ? "700" : c1 == 1 ? "800" : c1 == 2 ? "900" : "1000");
        }
    }
}
