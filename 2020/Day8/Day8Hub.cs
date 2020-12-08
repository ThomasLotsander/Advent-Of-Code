using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day8
{
    class Day7Hub
    {
        private int accumulator;
        public void Run()
        {
            Console.WriteLine("Day 8!");
            var testInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day8TestPuzzleInput.txt");
            var realInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day8PuzzleInput.txt");

            Puzzle1(testInput);
            //Puzzle2(testInput);
        }

        private void Puzzle1(string[] input)
        {
            accumulator = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var code = input[i].Split(' ');
                bool add = code[1].First() == '+';
                //int number = code[1].Skip(1).Take()
                var number = int.Parse(String.Join("", code[1].Where(char.IsDigit)));


                switch (code[0])
                {
                    case "acc":
                        {
                            if (add)
                                accumulator += number;
                            else
                                accumulator -= number;
                            break;
                        }
                    case "jmp":
                        {
                            if (add)
                                i += number;
                            else
                                i -= i;

                            break;
                        }
                    case "nop":
                        {
                            break;
                        }
                }
            }
            Console.WriteLine("Get Code Puzzle 1");


        }

        private void Puzzle2(string[] input)
        {
            Console.WriteLine("Get Code Puzzle 2");

        }
    }
}
