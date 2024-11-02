using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___abc_of_ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1=Console.ReadLine();
            //char[] c1 = s1.ToCharArray();
            HashSet<char> s2=new HashSet<char>();
            for (int i = 0; i < s1.Length; i++)
            {
                s2.Add(s1[i]);
            }
            if(s2.Count== 3)
            {
                System.Console.WriteLine("Yes");
            }
            else
            {
                System.Console.WriteLine("No");
            }
        }
    }
}
