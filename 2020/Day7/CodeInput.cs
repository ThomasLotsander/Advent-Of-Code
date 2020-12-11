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
                    var containsBags = splitLn[1].Trim().Split(',');
                    int numberOfBags = 0;

                    if (containsBags.Any())
                    {
                        foreach (var nrOfBagsString in containsBags)
                        {
                            if (!nrOfBagsString.Contains("no other bags"))
                            {
                                numberOfBags += int.Parse(nrOfBagsString.Trim()[0].ToString());
                            }
                        }
                    }
                    


                    foreach (var b in splitLn[1].Split(','))
                    {
                        if (!b.Trim().Contains("no other bags"))
                            bags.Add(SetUpBag(b.Trim()));
                    }

                    var bag = new Bag
                    {
                        NumberOfBags = numberOfBags,
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
                    SetUpBaglistForBag(bag.BagsList);
                }
            }

            var firstBag = bagList[0];
            var firstlist = firstBag.BagsList;

            foreach (var bag in bagList)
            {
                bag.HasGold = GetInfoForevar(bag.BagsList);
            }

            foreach (var bag in bagList)
            {
                Console.WriteLine(bag.BagType + " \t" + bag.HasGold);
            }

            Console.WriteLine("Titta: " + bagList.Count(x => x.HasGold));
            return bagList;
        }

        private static void SetUpBaglistForBag(List<Bag> bags)
        {
            foreach (var bag1 in bags)
            {
                var originalBag = bagList.FirstOrDefault(x => x.BagType == bag1.BagType);
                bag1.BagsList = originalBag.BagsList;

                if (originalBag.BagsList.Any())
                {
                    SetUpBaglistForBag(originalBag.BagsList);
                }
            }
        }

        private static bool GetInfoForevar(List<Bag> inputBag)
        {
            if (!inputBag.Any())
            {
                return false;
            }


            if (inputBag.Any(x => x.BagType.Contains("shiny gold")))
            {
                return true;
            }


            foreach (var bag in inputBag)
            {
                    bag.HasGold = GetInfoForevar(bag.BagsList);
                    if (bag.HasGold)
                    {
                        return true;
                    }
            }

            if (inputBag.Any(x => x.BagType.Contains("shiny gold")))
            {
                return true;
            }



            return false;


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


    }
}
