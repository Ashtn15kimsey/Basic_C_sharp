﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        public List<card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}