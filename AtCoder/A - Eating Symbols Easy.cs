using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Eating_Symbols_Easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            int p=0, m=0;
            foreach(char c in s)
            {
                if (c == '+')
                {
                    p++;
                }
                else m++;
            }
            Console.WriteLine(p-m);
        }
    }
}
