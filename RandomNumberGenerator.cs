﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        public static Random _generator = new Random();

        public static int NumberBetween(int MinimumValue, int MaximumValue)
        {
            return _generator.Next(MinimumValue, MaximumValue + 1);
        }

    }
}
