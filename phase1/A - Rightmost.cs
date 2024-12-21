using System;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        int x = S.LastIndexOf('a') + 1;

        console.WriteLine(x==0?-1:x);
    }
}
