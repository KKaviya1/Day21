﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplilib
{
    [Serializable]
    public class Player
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string PlayerType { get; set; }
        public string Team { get; set; }
    }
    
}
