using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day7
{
    class Day7Hub
    {
        public void Run()
        {
            Console.WriteLine("Day 7!");
            //var testInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day7TestPuzzleInput.txt");
            var realInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day7PuzzleInput.txt");

            Puzzle1(realInput);
            //Puzzle2(testInput);
        }

        private void Puzzle1(List<Bag> input)
        {
            Console.WriteLine("Get Code Puzzle 1");

            int goldCount = 0;
            foreach (var bag in input)
            {
                bool hasGold = false;
                if (bag.HasGold)
                {
                    hasGold = true;
                }
                else if (bag.BagsList.Any())
                {
                    foreach (var bag1 in bag.BagsList)
                    {
                        if (bag1.HasGold)
                        {
                            hasGold = true;
                        }
                    }
                }

                if (hasGold)
                {
                    goldCount++;
                }
            }

            Console.WriteLine("Total gold count: " + goldCount);
          
        }

        private void Puzzle2(string[] input)
        {
            Console.WriteLine("Get Code Puzzle 2");

        }
    }
}
