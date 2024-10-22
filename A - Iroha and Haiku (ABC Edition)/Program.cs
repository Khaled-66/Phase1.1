// i can sort the array and check if the first two elements=5 and the third one =7
// i can also make simple if condition checks if two elements =5 and one element=7
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] arr = new int[3];
        int c1 = 0, c2 = 0;
        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(input[i]);
            if (arr[i] == 5) { c1++; }
            else if (arr[i] == 7) { c2++; }
        }

        if (c1 == 2 && c2 == 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
