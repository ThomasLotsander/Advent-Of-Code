using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020.Day9
{
    public class Day9Hub
    {
        public void Run()
        {
            Console.WriteLine("Day 9!");
            var testInput = CodeInput.GetTestPuzzleInput();
            var realInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day9PuzzleInput.txt");

            Puzzle1(testInput);
            Puzzle2(realInput);
        }

        private void Puzzle1(decimal[] puzzleInput)
        {
            int skipIndex = 0;
            int preamble = 5;
            int index = preamble;
            
            while (index < puzzleInput.Length)
            {
                var startList = puzzleInput.Skip(skipIndex).Take(preamble).ToArray();
                
                var valToCheck = puzzleInput[index];
                bool nrFound = false;

                for (int i = 0; i < startList.Length; i++)
                {
                    for (int j = 0; j < startList.Length; j++)
                    {
                        if (startList[j] != startList[i])
                        {
                            decimal val1 = startList[i];
                            decimal val2 = startList[j];
                            if (val1 + val2 == valToCheck)
                            {
                                Console.WriteLine(valToCheck + " True");
                                nrFound = true;
                                break;
                            }
                        }
                    }
                    if (nrFound)
                    {
                        break;
                    }
                }

                if (!nrFound)
                {
                    break;
                }

                index++;
                skipIndex++;
                

            }

            Console.WriteLine(puzzleInput[index] + " noooo");
        }

        private void Puzzle2(decimal[] puzzleInput)
        {
            decimal numbertofind = 542529149;

            var resultArray = new decimal[]
            {
                34309142,
                23249846,
                23189120,
                30892508,
                24331117,
                24779820,
                25684438,
                29676232,
                28682756,
                29914669,
                43826724,
                30908145,
                52489498,
                31909958,
                34243114,
                36964189,
                37477873
            };

            Console.WriteLine("min: " + resultArray.Min() + " max: " + resultArray.Max());
            Console.WriteLine(resultArray.Min() + resultArray.Max());

            Console.WriteLine(resultArray.Sum());
            Console.WriteLine(numbertofind);

            Console.WriteLine("......");

           FindRequiredSumSubArray(puzzleInput, numbertofind);


        }

        private static void FindRequiredSumSubArray(decimal[] arr, decimal sum)
        {
            //create an array for the subset with max length od input array  
            decimal[] sub = new decimal[arr.Length];
            decimal temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i, col = 0; j < arr.Length; j++, col++)
                {
                    //add the value of input array one by one  
                    temp += arr[j];
                    sub[col] = arr[j];
                    //if addition is equal to sum then print it  
                    if (temp == sum)
                    {
                        decimal total = 0;
                        for (int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            //if total and sum are equal then leave the print  
                            if (total == sum)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }
                    //if temp is greater than sum are equal then clear the sub array, set temp value and leave the loop for next  
                    if (temp > sum)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        temp = 0;
                        break;
                    }
                }
            }
        }

    }
}
