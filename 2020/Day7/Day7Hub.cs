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
            //var puzzle = CodeInput.GetPuzzleInput("CodeInputFiles/Day7TestPuzzleInput.txt");
            var puzzle = CodeInput.GetPuzzleInput("CodeInputFiles/Day7PuzzleInput.txt");

            Puzzle1(puzzle);
            //Puzzle2(testInput);
        }

        private void Puzzle1(List<Bag> input)
        {
            Console.WriteLine("Get Code Puzzle 1");

            int totlaGold = input.Count(x => x.HasGold);

            int goldCount = 0;
            foreach (var bag in input)
            {
                if (bag.HasGold)
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
