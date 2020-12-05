using System;
using System.Collections.Generic;
using System.Text;

namespace _2020.Day1
{
    public class Day1Hub
    {
        public void Run()
        {
            var testInput = CodeInput.GetTestPuzzleInput();
            var realInput = CodeInput.GetPuzzleInput();

            Console.WriteLine("Day 1 Get the code!");

            Console.WriteLine(GetCodePuzzle1(realInput));
            Console.WriteLine(GetCodePuzzle2(realInput));
            Console.WriteLine("----------------");
        }

        public int GetCodePuzzle1(int[] puzzleInput)
        {
            Console.WriteLine("Get code 1");
            for (int i = 0; i < puzzleInput.Length; i++)
            {
                for (int j = 0; j < puzzleInput.Length; j++)
                {
                    int num1 = puzzleInput[i];
                    int num2 = puzzleInput[j];

                    if (num1 + num2 == 2020)
                        return num1 * num2;
                }
            }

            return 0;
        }

        private int GetCodePuzzle2(int[] puzzleInput)
        {
            Console.WriteLine("Get code 2");

            int length = puzzleInput.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        int num1 = puzzleInput[i];
                        int num2 = puzzleInput[j];
                        int num3 = puzzleInput[k];

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
