using System;
class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        int daysUntilSaturday = S switch
        {
            "Monday" => 5,
            "Tuesday" => 4,
            "Wednesday" => 3,
            "Thursday" => 2,
            "Friday" => 1,
            _ =>-1
        };
        Console.WriteLine(daysUntilSaturday);
    }
}
