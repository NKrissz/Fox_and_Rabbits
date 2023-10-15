using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Grass
{
    internal class GrassHandler
    {
        public GrassHandler(int nutritionValue, Color grassColor)
        {
            NutritionValue = nutritionValue;
            GrassColor = grassColor;
        }
        enum GrassTypes
        {
            InitativeGrass,
            TenderGrass,
            AdvancedGrass

        }



        public int NutritionValue { get; init; }
        public Color GrassColor { get; init; }

    }
}
