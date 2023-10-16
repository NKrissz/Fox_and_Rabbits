﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Animals
{
    internal class Animal : Entity
    {
        public Animal(int saturation, bool ate, bool bred, Color entityColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            EntityColor = entityColor;
        }

       


        public int Saturation { get; init; }
        public bool Ate { get; init; } = false;
        public bool Bred { get; init; } = false;
        public Color EntityColor { get; init; }
    }
}
