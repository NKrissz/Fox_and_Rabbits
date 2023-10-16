using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Grass
{
    internal class AdvancedGrass : GrassHandler
    {
        public AdvancedGrass(int nutritionValue, Color entityColor) : base(nutritionValue, entityColor)
        {
            NutritionValue = nutritionValue;
            EntityColor = entityColor;
        }
    }
}
