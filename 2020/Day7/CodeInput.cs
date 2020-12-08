using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2020.Day7
{
    class CodeInput
    {
        static List<Bag> bagList;

        public static List<Bag> GetPuzzleInput(string path)
        {
            string ln;
            using (StreamReader sr = new StreamReader(path))
            {
                bagList = new List<Bag>();
                while ((ln = sr.ReadLine()) != null)
                {
                    var bags = new List<Bag>();
                    var splitLn = ln.Split("bags contain");
                    var bagType = splitLn[0].Trim();

                    foreach (var b in splitLn[1].Split(','))
                    {
                        if (b.Trim() != "no other bags.")
                            bags.Add(SetUpBag(b.Trim()));
                    }

                    var bag = new Bag
                    {
                        NumberOfBags = 1,
                        BagType = bagType,
                        HasGold = splitLn[1].Contains("shiny gold"),
                        BagsList = bags
                    };
                    bagList.Add(bag);
                }
            }

            foreach (var bag in bagList)
            {
                if (bag.BagsList.Any())
                {
                    foreach (var bag1 in bag.BagsList)
                    {
                        var result = bagList.FirstOrDefault(x => x.BagType == bag1.BagType);
                    }
                }
            }

            foreach (var bag in bagList)
            {
                if (bag.BagsList.Any())
                {
                    foreach (var bag1 in bag.BagsList)
                    {
                        bag1.HasGold = CheckIfBagHasGold(bag1);
                    }
                }
            }
            return bagList;
        }

        private static Bag SetUpBag(string bagString)
        {
            var splitBag = bagString.Split(' ');
            var bag = new Bag()
            {
                NumberOfBags = int.Parse(splitBag[0]),
                BagType = splitBag[1] + " " + splitBag[2],
            };

            return bag;
        }

        private static bool CheckIfBagHasGold(Bag bag)
        {
            var result = bagList.FirstOrDefault(x => x.BagType == bag.BagType);
            if (result != null)
            {
                return result.HasGold;
            }
            return false;
        }
    }
}
