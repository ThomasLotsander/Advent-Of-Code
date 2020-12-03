using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;

namespace _2020.Day3
{
    class CodeInput
    {
        public static string[] GetPuzzleInput()
        {
            var inputText = File.ReadAllLines("CodeInputFiles/Day3PuzzleInput.txt");
            return inputText;
        }

        public static string[] GetTestPuzzleInput()
        {
            var t = new string[]
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            return t;
        }
    }
}
