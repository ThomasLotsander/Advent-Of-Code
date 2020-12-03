using System;
using System.Collections.Generic;
using System.Text;

namespace _2020.Day1
{
    public class Puzzle2
    {
        private readonly int[] _puzzleInput;
        public Puzzle2(int[] puzzleInput)
        {
            _puzzleInput = puzzleInput;
            Console.WriteLine(GetCodePuzzle2());
        }

        private int GetCodePuzzle2()
        {
            Console.WriteLine("Get code 2");

            int length = _puzzleInput.Length;
            bool codeFound = false;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        int num1 = _puzzleInput[i];
                        int num2 = _puzzleInput[j];
                        int num3 = _puzzleInput[k];

                        if (num1 + num2 + num3 == 2020)
                        {
                            return num1 * num2 * num3;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
