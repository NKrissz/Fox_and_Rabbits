using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Grass
{
    internal class InitiativeGrass : GrassHandler
    {
        public InitiativeGrass(int nutritionValue, Color grassColor) : base(nutritionValue, grassColor)
        {
            NutritionValue = nutritionValue;
            GrassColor = grassColor;
        }
    }
}
