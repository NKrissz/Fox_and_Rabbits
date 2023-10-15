using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Animals
{
    internal class Animal
    {
        public Animal(int saturation, bool ate, bool bred, Color animalColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            AnimalColor = animalColor;
        }

       


        public int Saturation { get; init; }
        public bool Ate { get; init; } = false;
        public bool Bred { get; init; } = false;
        public Color AnimalColor { get; init; }



    }
}
