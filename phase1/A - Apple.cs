using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);
        int N = int.Parse(input[2]);

        int setsOfThree = N / 3;
        int remainingApples = N % 3;

        int cost = (Y < 3 * X) ? setsOfThree * Y + remainingApples * X : N * X;

        Console.WriteLine(cost);
    }
}
