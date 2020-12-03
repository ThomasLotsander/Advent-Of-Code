using System;
using System.Collections.Generic;
using System.Text;

namespace _2020.Day1
{
    public static class Day1Hub
    {
        public static void Run()
        {
            
            var testInput = CodeInput.GetTestPuzzleInput();
            var realInput = CodeInput.GetPuzzleInput();

            Puzzle1 p1 = new Puzzle1(testInput);
            Puzzle2 p2 = new Puzzle2(testInput);
        }

    }
}
