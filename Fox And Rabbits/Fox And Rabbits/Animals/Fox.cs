using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Animals
{
    internal class Fox : Animal
    {
        public Fox(int saturation, bool ate, bool bred, Color animalColor) : base(saturation, ate, bred, animalColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            AnimalColor = animalColor;
        }

  
    }
}
