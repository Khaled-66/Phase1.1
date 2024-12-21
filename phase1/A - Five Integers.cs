using System;
class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(input, int.Parse);
        int c = new HashSet<int>(nums).Count;
        Console.WriteLine(c);
    }
}
