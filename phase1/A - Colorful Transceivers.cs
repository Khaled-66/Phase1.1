using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A___Colorful_Transceivers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s1=Console.ReadLine().Split(' ');
            int[] a=new int[4];
            int c = int.Parse(s1[3]);
            for (int i=0; i<3; i++)
            {
                a[i] = int.Parse(s1[i]);
            }
            Array.Sort(a);
            System.Console.WriteLine((a[1]-a[0] < c || a[2]-a[1] < c )? "YES" : "NO");
        }
    }
}

