using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(input[i]);
        }
        Console.WriteLine(sum);
    }
}
