namespace Fox_And_Rabbits.Animals
{
    internal class Animal : IEntity
    {
        public Animal(int saturation, bool ate, bool bred, Color entityColor )
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            EntityColor = entityColor;
        }

        public Animal() { }

   

        public int Saturation { get; set; }
        public bool Ate { get; set; } = false;
        public bool Bred { get; set; }
        public Color EntityColor { get; init; }
    }
}
