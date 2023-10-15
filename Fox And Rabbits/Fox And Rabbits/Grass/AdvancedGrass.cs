using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Grass
{
    internal class AdvancedGrass : GrassHandler
    {
        public AdvancedGrass(int nutritionValue, Color grassColor) : base(nutritionValue, grassColor)
        {
            NutritionValue = nutritionValue;
            GrassColor = grassColor;
        }
    }
}
