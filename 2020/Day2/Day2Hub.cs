using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _2020.Day2
{
    public class Day2Hub
    {
        public void Run()
        {
            var realInput = CodeInput.GetPuzzleInput();
            var testInput = CodeInput.GetTestPuzzleInput();

            Console.WriteLine("Day 2!");

            Puzzle1(realInput);
            Puzzle2(realInput);

        }

        private void Puzzle1(string[] puzzleInput)
        {
            Console.WriteLine("Get code 1");

            int numberOfCorrectPasswords = 0;

            foreach (var input in puzzleInput)
            {

                string[] inputs = input.Split(' ');
                var range = inputs[0].Split('-');
                var minRange = int.Parse(range[0]);
                var maxRange = int.Parse(range[1]);
                var key = inputs[1].First();
                var password = inputs[2];

                var result = password.Count(x => x == key);

                if (result >= minRange && result <= maxRange)
                {
                    numberOfCorrectPasswords++;
                }
            }

            Console.WriteLine(numberOfCorrectPasswords);
        }

        private void Puzzle2(string[] puzzleInput)
        {
            Console.WriteLine("Get code 2");

            int numberOfCorrectPasswords = 0;

            foreach (var input in puzzleInput)
            {

                string[] inputs = input.Split(' ');
                var pos = inputs[0].Split('-');
                var firtsPos = int.Parse(pos[0]) - 1;
                var lastPos = int.Parse(pos[1]) - 1;
                var key = inputs[1].First();
                var password = inputs[2];

         

                if ((password[firtsPos] == key && password[lastPos] != key) || password[lastPos] == key && password[firtsPos] != key)
                {
                    numberOfCorrectPasswords++;
                }

            
            }

            Console.WriteLine(numberOfCorrectPasswords);
        }
    }
}
