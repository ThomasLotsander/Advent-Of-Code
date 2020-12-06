using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace _2020.Day5
{
    class CodeInput
    {
        public static string[] GetPuzzleInput(string path)
        {
            var input = File.ReadAllLines(path);
            return input;
        }

        public static string[] GetTestPuzzleInput()
        {
            var input = new string[]
            {
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
            };
            return input;
        }
    }
}
