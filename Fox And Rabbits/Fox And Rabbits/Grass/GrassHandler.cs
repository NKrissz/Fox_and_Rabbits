using Fox_And_Rabbits.Animals;
namespace Fox_And_Rabbits.Grass
{
    internal class GrassHandler : IEntity
    {
        public GrassHandler()
        {
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
