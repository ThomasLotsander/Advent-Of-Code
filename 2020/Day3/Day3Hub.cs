using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day3
{
    public class Day3Hub
    {
        public void Run()
        {
            Console.WriteLine("Day 3!");
            var realInput = CodeInput.GetPuzzleInput();
            var testInput = CodeInput.GetTestPuzzleInput();

            Puzzle1(realInput);
            Puzzle2(realInput);

        }

        public void Puzzle1(string[] puzzleInput)
        {
            Console.WriteLine("Get code 1");

            int rightSteps = 0;
            int treesHit = 0;
            foreach (var row in puzzleInput.Skip(1))
            {
                rightSteps += 3;

                if (rightSteps >= row.Length)
                    rightSteps = rightSteps - row.Length;
                
                if (row[rightSteps] == '#')
                    treesHit++;
            }

            Console.WriteLine(treesHit);
        }

        public void Puzzle2(string[] input)
        {
            Console.WriteLine("Get code 2");

            int[] rightStepsSlop = { 1, 3, 5, 7, 1 };
            int[] downSteps = { 1, 1, 1, 1, 2 };

            int treesHitThisSlope = 0;
            double totalTreesHit = 1;

            int rightSteps = 0;
            int row = 1;
            foreach (var slop in rightStepsSlop)
            {
                int index = 0;

                foreach (var s in input.Skip(1))
                {
                    if (row % downSteps[rightSteps] == 0)
                    {
                        index += slop;

                        if (index >= s.Length)
                            index = index - s.Length;


                        if (s[index] == '#')
                            treesHitThisSlope++;
                    }
                    row++;
                }

                
                totalTreesHit = totalTreesHit * treesHitThisSlope;
                treesHitThisSlope = 0;
                rightSteps++;
            }

            Console.WriteLine(totalTreesHit);
        }
    }


}
