using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day8
{
    class Day8Hub
    {
        private int accumulator;
        public void Run()
        {
            Console.WriteLine("Day 8!");
            var testInput = CodeInput.GetTestPuzzleInput();
            var realInput = CodeInput.GetPuzzleInput();

            Puzzle1(testInput);
            //Puzzle2(testInput);
        }

        private void Puzzle1(List<Day8Code> puzzleInput)
        {

            Console.WriteLine("Get Code Puzzle 1");
            accumulator = 0;
            int index = 0;
            var changedIndexArray = new List<int>();
            int indexToChange = 0;
            bool isChaged = false;

            while (true)
            {
                if (index == puzzleInput.Count - 1)
                {
                    
                }
                Console.WriteLine("Index: " + index + " Acc: " + accumulator);
                var input = puzzleInput[index];

                if (input.Visited)
                {
                    Console.WriteLine("---------");
                    accumulator = 0;
                    isChaged = false;
                    input.Visited = false;
                    index = 0;

                    puzzleInput = CodeInput.GetPuzzleInput();
                    //puzzleInput = CodeInput.GetTestPuzzleInput();

                    continue;
                }
                input.Visited = true;


                if (!isChaged)
                {
                    if (input.code == "jmp" || input.code == "nop")
                    {
                        if (!changedIndexArray.Contains(index))
                        {
                            if (input.code == "jmp")
                            {
                                input.code = "nop";
                            }
                            else if (input.code == "nop")
                            {
                                input.code = "jmp";
                            }
                            isChaged = true;
                            changedIndexArray.Add(index);
                        }
                    }
                }


                switch (input.code)
                {
                    case "acc":
                        {
                            if (input.add)
                                accumulator += input.number;
                            else
                                accumulator -= input.number;

                            index++;
                            break;
                        }
                    case "jmp":
                        {
                            if (input.add)
                                index += input.number;
                            else
                                index -= input.number;

                            break;
                        }
                    case "nop":
                        {
                            index++;
                            break;
                        }
                }
            }
            Console.WriteLine("Value of Acc: " + accumulator);

        }

        private void Puzzle2(string[] input)
        {
            Console.WriteLine("Get Code Puzzle 2");

        }
    }
}
