using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _2020.Day10
{
    class Day10Hub
    {
        public void Run()
        {
            var testPuzzle = CodeInput.GetTestPuzzleInput();
            var puzzleInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day10PuzzleInput.txt");

            Puzzle1(puzzleInput);
            Puzzle2(testPuzzle);
        }

        private void Puzzle1(int[] puzzleInput)
        {
            var joltSortArray = puzzleInput.ToList().OrderBy(x => x);
            int joltVal = 0;

            var joltSteps = new List<int>();
            foreach (var jolt in joltSortArray)
            {
                int joltageRating = jolt - joltVal;
                joltSteps.Add(joltageRating);
                joltVal = jolt;


            }
           joltSteps.Add(3);
           var joltGroup = joltSteps.GroupBy(x => x);
           int totalVal = 1;
           foreach (var group in joltGroup)
           {
               Console.WriteLine("Key: " +group.Key + " - " + group.Count());
               totalVal *= group.Count();
           }

           Console.WriteLine(totalVal);
        }
        private void Puzzle2(int[] puzzleInput)
        {

        }
    }
}
