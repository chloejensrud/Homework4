﻿// Written By Chloe Jensrud
// 2/16/25

namespace CharInOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            Console.WriteLine(aCalculator.IsInOrder("abc"));
        }
    }
}
