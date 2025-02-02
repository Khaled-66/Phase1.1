using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___One_Card_Poker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a == 1&&b!=1){ Console.WriteLine("Alice"); }
            else if(a !=1&&b==1) { Console.WriteLine("Bob"); }
            else if(a==b) { Console.WriteLine("Draw"); }
            else
            {
                if (a > b) { Console.WriteLine("Alice"); }
                else
                {
                    Console.WriteLine("Bob");
                }
            }
        }
    }
}
