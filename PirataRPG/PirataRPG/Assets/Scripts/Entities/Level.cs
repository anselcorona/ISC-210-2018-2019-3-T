﻿using System;
using System.Collections.Generic;

namespace Assets.Scripts.Entities
{
    public class Level
    {
        public List<List<char>> Map { get; set; }
        public List<Character> characters { get; set; }
        //public List<Item> Items { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
