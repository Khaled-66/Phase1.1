using System;
class Program
{
    static int rec(int x)
    {
        if (x == 0)
            return 1;
        return x * rec(x - 1);
    }

    static void Main()
    {
        int n= int.Parse(Console.ReadLine());
        Console.WriteLine(rec(n));
    }
}
