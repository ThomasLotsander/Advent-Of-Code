using System;
using _2020.Day1;
using _2020.Day2;
using _2020.Day3;
using _2020.Day4;
using _2020.Day5;

namespace _2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of code 2020!");
            Console.WriteLine("------------");

            Day1Hub day1 = new Day1Hub();
            day1.Run();
            Console.WriteLine("------------");

            Day2Hub day2 = new Day2Hub();
            day2.Run();
            Console.WriteLine("------------");

            Day3Hub day3 = new Day3Hub();
            day3.Run();
            Console.WriteLine("------------");

            Day4Hub day4 = new Day4Hub();
            day4.Run();
            Console.WriteLine("------------");

            Day5Hub day5 = new Day5Hub();
            day5.Run();
            Console.WriteLine("------------");

        }
    }
}
