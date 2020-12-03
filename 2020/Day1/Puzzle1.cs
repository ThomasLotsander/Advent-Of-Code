using System;
using System.Collections.Generic;
using System.Text;

namespace _2020.Day1
{
    public class Puzzle1
    {
        private readonly int[] _puzzleInput;
        public Puzzle1(int[] puzzleInput)
        {
            _puzzleInput = puzzleInput;
            Console.WriteLine(GetCodePuzzle1());
        }

        public int GetCodePuzzle1()
        {
            Console.WriteLine("Get code 1");
            for (int i = 0; i < _puzzleInput.Length; i++)
            {
                for (int j = 0; j < _puzzleInput.Length; j++)
                {
                    int num1 = _puzzleInput[i];
                    int num2 = _puzzleInput[j];

                    if (num1 + num2 == 2020)
                        return num1 * num2;
                }
            }

            return 0;
        }
    }
}
