using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020.Day2
{
    public class CodeInput
    {
        public static string[] GetPuzzleInput()
        {
            var text = File.ReadAllLines(@"Day2PuzzleInput.txt");
            return text;

        }

        public static string[] GetTestPuzzleInput()
        {
            string[] testPuzzleInput = new[]
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            return testPuzzleInput;

        }
    }
}
