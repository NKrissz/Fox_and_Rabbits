namespace Fox_And_Rabbits.Animals
{
    internal class Fox : Animal
    {
        public Fox(int saturation, bool ate, bool bred, Color entityColor) : base(saturation, ate, bred, entityColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            EntityColor = entityColor;
        }
        public Fox() { }

  
    }
}
