using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020.Day10
{
    class CodeInput
    {
        public static int[] GetTestPuzzleInput()
        {
            
            return new[]
            {
                28,
                33,
                18,
                42,
                31,
                14,
                46,
                20,
                48,
                47,
                24,
                23,
                49,
                45,
                19,
                38,
                39,
                11,
                1,
                32,
                25,
                35,
                8,
                17,
                7,
                9,
                4,
                2,
                34,
                10,
                3
            };
        }
        public static int[] GetPuzzleInput(string path)
        {
            var inputText = File.ReadAllLines("CodeInputFiles/Day10PuzzleInput.txt");
            var inputNumbers = new int[inputText.Length];

            int index = 0;
            foreach (var line in inputText)
            {
                inputNumbers[index] = int.Parse(line);
                index++;
            }

            return inputNumbers;
        }
    }
}
