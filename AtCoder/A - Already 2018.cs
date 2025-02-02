using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Already_2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1=System.Console.ReadLine();
            char[] s2=s1.ToCharArray();
            s2[3] = '8';
            Console.WriteLine(s2);
            //or i can split the string split('/') and make 3 substrings and modify the first one which will be
            // "yyyy" and then concatinate them again with '/'
        }
    }
}
