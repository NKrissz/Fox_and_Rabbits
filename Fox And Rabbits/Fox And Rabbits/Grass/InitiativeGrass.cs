namespace Fox_And_Rabbits.Grass
{
    internal class InitiativeGrass : GrassHandler
    {
        public InitiativeGrass(int nutritionValue, Color entityColor) : base(nutritionValue, entityColor)
        {
            NutritionValue = nutritionValue;
            EntityColor = entityColor;
        }
    }
}
