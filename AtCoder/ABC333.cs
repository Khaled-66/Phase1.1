﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine((arr[0] * arr[1])%2==0?"No":"Yes");
        }
    }
}
