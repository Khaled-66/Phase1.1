using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Infinite_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            int a=int.Parse(Console.ReadLine());    
            if(a>= (x % 500))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
