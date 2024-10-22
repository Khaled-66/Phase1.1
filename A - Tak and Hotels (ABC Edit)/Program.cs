using System;

namespace A___Tak_and_Hotels__ABC_Edit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int tot = 0;
            if (n > k)
            {
               tot = (k * x) + (n - k) * y;
            }
            else
            {
                tot = (n * x);
            }
            Console.WriteLine(tot);
        }
    }
}
