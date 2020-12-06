using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day6
{
    class Day6Hub
    {
        public void Run()
        {
            Console.WriteLine("Day 6!");
            var testInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day6TestPuzzleInput.txt");
            var realInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day6PuzzleInput.txt");

            Puzzle1(realInput);
            Puzzle2(realInput);
        }

        private void Puzzle1(string[] input)
        {
            Console.WriteLine("Get Code Puzzle 1");
            int totalNrYes = 0;
            foreach (var line in input)
            {
                string l = line.Replace(" ", string.Empty);
                totalNrYes += l.Distinct().Count();
            }

            Console.WriteLine(totalNrYes);
        }

        private void Puzzle2(string[] input)
        {
            Console.WriteLine("Get Code Puzzle 2");

            var totalNrYesAnswer = 0;
            foreach (var line in input)
            {
                var peopleInGroup = line.Split(' ').Length;
                var compactLine = line.Replace(" ", string.Empty);

                foreach (var c in compactLine.Distinct())
                {
                    if (compactLine.Count(x => x == c) == peopleInGroup)
                    {
                        totalNrYesAnswer++;
                    }
                }
            }

            Console.WriteLine(totalNrYesAnswer);
        }

    }
}
