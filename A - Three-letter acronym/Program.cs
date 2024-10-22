using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Three_letter_acronym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string s1 = s[0].ToUpper();
            string s2 = s[1].ToUpper();
            string s3 = s[2].ToUpper();
            Console.WriteLine($"{s1[0]}{s2[0]}{s3[0]}");
        }
    }
}
