using Fox_And_Rabbits.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Grass
{
    internal class GrassHandler : Entity
    {
        public GrassHandler(int nutritionValue, Color entityColor)
        {
            NutritionValue = nutritionValue;
            EntityColor = entityColor;
        }
        enum GrassTypes
        {
            InitativeGrass,
            TenderGrass,
            AdvancedGrass

        }


        public int NutritionValue { get; init; }
        public Color EntityColor { get; init; }

    }
}
