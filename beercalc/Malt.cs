﻿using System;
namespace beercalc
{
    public class Malt
    {
        public int id { get; set; }
        public int recipe_id { get; set; }
        public int malt_id { get; set; }
        public float weight { get; set; }
        public string name { get; set; }
        public float gravity_factor { get; set; }
        public float ebc { get; set; }
        public int nomash { get; set; }
        public float gravity { get; set; }
        public float colour { get; set; }
        public float percent { get; set; }

    }
}
