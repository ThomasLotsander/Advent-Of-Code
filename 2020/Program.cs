using System;
using _2020.Day1;
using _2020.Day2;
using _2020.Day3;

namespace _2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           Day1Hub day1 = new Day1Hub();
           day1.Run();

           Day2Hub day2 = new Day2Hub();
           day2.Run();


           Day3Hub day3 = new Day3Hub();
           day3.Run();
        }
    }
}
