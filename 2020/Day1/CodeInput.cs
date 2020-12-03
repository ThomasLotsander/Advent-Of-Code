using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2020.Day1
{
    public static class CodeInput
    {
        public static int[] GetPuzzleInput()
        {
            var inputText = File.ReadAllLines(@"Day1PuzzleInput.txt");
            var inputNumbers = new int[inputText.Length];

            int index = 0;
            foreach (var line in inputText)
            {
                inputNumbers[index] = int.Parse(line);
                index++;
            }

            return inputNumbers;

        }

        public static int[] GetTestPuzzleInput()
        {
            var testPuzzleInput = new int[]
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            return testPuzzleInput;
        }
    }
}
