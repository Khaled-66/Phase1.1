using System;

namespace A___Trapezoids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int area = ((a + b) * h) / 2;
            Console.WriteLine(area);    
        }
    }
}
