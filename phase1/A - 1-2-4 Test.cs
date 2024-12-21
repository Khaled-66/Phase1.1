using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(); int c = 0;
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        if (A >= 1 || B >= 1) c += 1;
        if (A >= 2 || B >= 2) c += 2;
        if (A >= 4 || B >= 4) c += 4;
        Console.WriteLine(c);
    }
}
