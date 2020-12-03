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
            var realInput = CodeInput.GetPuzzleInput();
            var testInput = CodeInput.GetTestPuzzleInput();

            p1(testInput);
            p1(realInput);

        }

        public void p1(string[] input)
        {
            int[] slops = new[] { 1, 3, 5, 7, 1 };
            int[] steps = new[] { 1, 1, 1, 1, 2 };

            int nrOfTreesHit = 0;
            double tot = 1;

            int stepCont = 0;
            int count = 1;
            foreach (var slop in slops)
            {

                int index = 0;

                foreach (var s in input.Skip(1))
                {
                    if (count % steps[stepCont] == 0)
                    {
                        index += slop;

                        if (index >= s.Length)
                        {
                            index = index - s.Length;
                        }


                        if (s[index] == '#')
                        {
                            nrOfTreesHit++;
                        }
                    }

                    count++;

                }
                Console.WriteLine(nrOfTreesHit + " träd");

                tot = tot * nrOfTreesHit;
                nrOfTreesHit = 0;
                stepCont++;
            }

            Console.WriteLine(tot);
        }
    }


}
