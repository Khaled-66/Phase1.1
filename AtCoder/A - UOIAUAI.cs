using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___UOIAUAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c=Console.ReadLine();
            if (c[0] == 'a' || c[0] == 'o' || c[0] == 'u' || c[0] == 'i' || c[0] == 'e')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
    }
}
