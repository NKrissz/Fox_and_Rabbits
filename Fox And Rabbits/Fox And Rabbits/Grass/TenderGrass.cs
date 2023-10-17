namespace Fox_And_Rabbits.Grass.Grass
{
    internal class TenderGrass : GrassHandler
    {
        public TenderGrass(int nutritionValue, Color entityColor) : base(nutritionValue, entityColor)
        {
            NutritionValue = nutritionValue;
            EntityColor = entityColor;
        }
    }
}
