using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2020.Day8
{
   public class CodeInput
    {

        public static List<Day8Code> GetPuzzleInput(string path = "CodeInputFiles/Day8PuzzleInput.txt")
        {
            var puzzleInput = File.ReadAllLines(path);

            var returnList = new List<Day8Code>();
            foreach (var code in puzzleInput)
            {
                var s = code.Split(' ');

                returnList.Add(new Day8Code()
                {
                    code = s[0],
                    add = s[1].First() == '+',
                    number = int.Parse(String.Join("", s[1].Where(char.IsDigit)))
                });

            }
            return returnList;
        }
        public static List<Day8Code> GetTestPuzzleInput()
        {
            var testInput = new []
            {
                "nop +0",
                "acc +1",
                "jmp +4",
                "acc +3",
                "jmp -3",
                "acc -99",
                "acc +1",
                "jmp -4",
                "acc +6",
            };

            var returnList = new List<Day8Code>();
            foreach (var code in testInput)
            {
                var s = code.Split(' ');

                returnList.Add(new Day8Code()
                {
                    code = s[0],
                    add = s[1].First() == '+',
                    number = int.Parse(String.Join("", s[1].Where(char.IsDigit)))
                });

            }
            return returnList;
        }
    }

    public class Day8Code
    {
        public string code { get; set; }
        public bool add { get; set; }
        public int number { get; set; }

        public bool Visited { get; set; }
    }
}
