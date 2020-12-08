using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2020.Day8
{
    class CodeInput
    {

        public static string[] GetPuzzleInput(string path)
        {
            return File.ReadAllLines(path);
        }
        public static string[] GetTestPuzzleInput(string path)
        {
            return new string[]
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
        }


    }
}
