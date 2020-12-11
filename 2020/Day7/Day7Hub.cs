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
            var puzzle = CodeInput.GetPuzzleInput("CodeInputFiles/Day7TestPuzzleInput.txt");
            //var puzzle = CodeInput.GetPuzzleInput("CodeInputFiles/Day7PuzzleInput.txt");

            Console.WriteLine("Räkna");
            Console.WriteLine(1 + 1*2);

            //Puzzle1(puzzle);
            Puzzle2(puzzle);
        }

        private void Puzzle1(List<Bag> input)
        {
            Console.WriteLine("Get Code Puzzle 1");

            int totlaGold = input.Count(x => x.HasGold);

            Console.WriteLine("Total gold count: " + totlaGold);
          
        }

        private void Puzzle2(List<Bag> input)
        {
            Console.WriteLine("Get Code Puzzle 2");
            var shinyGoldBag = input.FirstOrDefault(x => x.BagType.Equals("shiny gold"));


            GetNrOfBagsInBag(shinyGoldBag);
            foreach (var bag in shinyGoldBag.BagsList)
            {
                
            }

        }

        int numToReturn = 0;
        private int GetNrOfBagsInBag(Bag inputBag)
        {
            
            if (inputBag.BagsList.Any())
            {
                numToReturn += inputBag.NumberOfBags;
               
                foreach (var bag in inputBag.BagsList)
                {
                    var result = GetNrOfBagsInBag(bag);
                }
            }

            return numToReturn;

        }
    }
}
