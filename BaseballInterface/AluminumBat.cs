﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballInterface
{
    public class AluminumBat : IBaseballBat
    {
        public int WeightInGrams { get; set; }

        public void Swing()
        {
            Console.WriteLine("Ting!");
        }
    }
}
