using Fox_And_Rabbits.Grass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits.Animals
{
    internal class Rabbit : Animal
    {
        public void RabbitMove(Entity[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].GetType() == typeof(InitiativeGrass))
                    {

                    }
                }
            }
        }
        public void RabbitEat(Entity[,] grid)
        {

        }
        public void RabbitBreed()
        {

        }
        public Rabbit(int saturation, bool ate, bool bred, Color entityColor) : base(saturation, ate, bred, entityColor)
        {
            Saturation = saturation;
            Ate = ate;
            Bred = bred;
            EntityColor = entityColor;
        }
        public Rabbit() { }

    }
}
