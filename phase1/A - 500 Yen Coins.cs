using System;
class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int K = int.Parse(inputs[0]);
        int X = int.Parse(inputs[1]);

        int totalMoney = 500 * K;

        if (totalMoney >= X)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
