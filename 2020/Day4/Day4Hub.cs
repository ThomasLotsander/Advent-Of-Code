using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace _2020.Day4
{
    class Day4Hub
    {
        readonly string[] _requirements =
       {
            "byr",
            "iyr",
            "eyr",
            "hgt",
            "hcl",
            "ecl",
            "pid"
       };
        public void Run()
        {
            Console.WriteLine("Day 4!");
            var puzzleInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day4PuzzleInput.txt");
            var testPuzzleInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day4TestPuzzleInput.txt");

            Puzzle1(puzzleInput);
            Puzzle2(puzzleInput);
        }

        public void Puzzle1(List<string> lines)
        {
            Console.WriteLine("Get code 1");


            int validPass = 0;
            foreach (var l in lines)
            {
                bool isValid = false;
                foreach (var requirement in _requirements)
                {
                    isValid = l.Contains(requirement);

                    if (!isValid)
                        break;
                }
                if (isValid)
                    validPass++;

            }

            Console.WriteLine(validPass);
        }

        public void Puzzle2(List<string> lines)
        {
            Console.WriteLine("Get code 2");
            var passportList = new List<Dictionary<string, string>>();
            foreach (var line in lines)
            {
                var dict = line.Split(' ')
                    .Select(x => x.Split(':'))
                    .ToDictionary(x => x[0], x => x[1]);
                passportList.Add(dict);
            }

            int validPassports = 0;
            foreach (var passport in passportList)
            {
                
                if (CheckRequiredFields(passport))
                {
                    var passIsValid = false;
                    foreach (var pass in passport)
                    {
                        if (pass.Key == "cid")
                        {
                            continue;
                        }
                       
                        var valid = CheckPassValue(pass);

                        if (!valid)
                        {
                            passIsValid = false;
                            break;
                        }

                        passIsValid = true;

                    }
                    if (passIsValid)
                    {
                        validPassports++;
                    }
                }
                
            }
            Console.WriteLine(validPassports);
        }

        private bool CheckRequiredFields(Dictionary<string, string> passport)
        {
            bool isValid = false;
            foreach (var requirement in _requirements)
            {
                isValid = passport.ContainsKey(requirement);
                if (!isValid)
                    return isValid;
                
            }

            return isValid;
        }

        private bool CheckPassValue(KeyValuePair<string, string> item)
        {
            switch (item.Key)
            {
                case "byr":
                    {
                        int birthYear = int.Parse(item.Value);
                        return birthYear >= 1920 && birthYear <= 2002;
                    }

                case "iyr":
                    {
                        int issueYear = int.Parse(item.Value);
                        return issueYear >= 2010 && issueYear <= 2020;
                    }
                case "eyr":
                    {
                        int expirationYear = int.Parse(item.Value);
                        return expirationYear >= 2020 && expirationYear <= 2030;
                    }
                case "hgt":
                    {
                        var identifier = new String(item.Value.Where(Char.IsLetter).ToArray());
                        string value = Regex.Replace(item.Value, "[A-Za-z ]", "");
                        int height = int.Parse(value);
                        if (identifier == "cm")
                        {
                            return height >= 150 && height <= 193;
                        }
                        if (identifier == "in")
                        {
                            return height >= 59 && height <= 76;
                        }

                        return false;

                    }
                case "hcl":
                    {
                        
                        if (!item.Value.Contains('#'))
                        {
                            return false;
                        }
                        string hairColor = Regex.Replace(item.Value, "[#]", "");
                        return Regex.IsMatch(hairColor, "^[0-9a-f]{6}");
                    }
                case "ecl":
                    {
                        string[] acceptedEyeColor = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                        var nr = acceptedEyeColor.Where(x => x == item.Value).Count();
                        return nr == 1;
                    }
                case "pid":
                    {
                       
                        bool isNumber = int.TryParse(item.Value, out int number);
                        if (isNumber)
                        {
                            return item.Value.Length == 9;
                        }
                        return false;
                    }
                default: return false;
            }
        }
    }
}
