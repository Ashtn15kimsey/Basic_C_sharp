﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class player
    {
        public List<card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivePlayer { get; set; }
    }
}
