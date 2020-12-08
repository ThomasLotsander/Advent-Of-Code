using System;
using System.Collections.Generic;
using System.Text;

namespace _2020.Day7
{
    class Bag
    {
        public int NumberOfBags { get; set; }

        public string BagType { get; set; }

        public List<Bag> BagsList { get; set; } = new List<Bag>();

        public bool HasGold { get; set; }
    }
}
