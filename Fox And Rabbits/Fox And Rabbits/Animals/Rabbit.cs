using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Animals
{
    internal class Rabbit : Animal
    {
        public Rabbit(int saturation, bool ate, bool bred, Color animalColor) : base(saturation, ate, bred, animalColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            AnimalColor = animalColor;
        }

    }
}
