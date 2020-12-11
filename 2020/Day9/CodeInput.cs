using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020.Day9
{
    class CodeInput
    {
        public static decimal[] GetPuzzleInput(string path)
        {
            var input = File.ReadAllLines(path);
            var returnInput = new decimal[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                returnInput[i] = decimal.Parse(input[i]);
            }

            return returnInput;
        }

        public static decimal[] GetTestPuzzleInput()
        {
            return new decimal[]
            {
                35,
                20,
                15,
                25,
                47,
                40,
                62,
                55,
                65,
                95,
                102,
                117,
                150,
                182,
                127,
                219,
                299,
                277,
                309,
                576
            };
        }
    }
}
