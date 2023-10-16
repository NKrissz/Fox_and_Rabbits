using Fox_And_Rabbits.Animals;
using Fox_And_Rabbits.Grass;
using Fox_And_Rabbits.Grass.Grass;
using System.Drawing;

namespace Fox_And_Rabbits
{
    internal class Simulation : ISimulation
    {
        public int X { get; init; }
        public int Y { get; init; }
        public int CellSize { get; init; }
        public Entity[,] Grid { get; init; }

        public Simulation(int x, int y, int cellSize)
        {
            X = x;
            Y = y;
            CellSize = cellSize;
            Grid = new Entity[x, y];
        }



        public Bitmap GenerateBitmap()
        {
            return new Bitmap(X * CellSize, Y * CellSize);

        }



        public void StartGame(out Bitmap bitmapHandler)
        {
            var bitmap = GenerateBitmap();

            Graphics graphics = Graphics.FromImage(bitmap);

            Random rnd = new();
            Color cellColor = new();

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    switch (rnd.Next(1, 101))
                    {
                        case int n when (n >= 1 && n <= 28):
                            Grid[i, j] = new InitiativeGrass(0, Color.LightGreen);
                            cellColor = Grid[i,j].EntityColor;
                            break;
                        case int n when (n >= 29 && n <= 56):
                            Grid[i, j] = new TenderGrass(1, Color.Green);
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 57 && n <= 84):
                            Grid[i, j] = new AdvancedGrass(2, Color.DarkGreen);
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 85 && n <= 94):
                            Grid[i, j] = new Rabbit(5, false, false, Color.DarkSlateGray);
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 95 && n <= 100):
                            Grid[i, j] = new Fox(10, false, false, Color.Red);
                            cellColor = Grid[i, j].EntityColor;
                            break;
                    }

                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            }
            bitmapHandler = bitmap;

        }
        public int RabbitCounter()
        {
            int rabbit = 0;
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    if (Grid[i, j].GetType() == typeof(Rabbit))
                    {
                        rabbit++;
                    }
                }
            }
            return rabbit;
        }
        public void PassageOfTime(Bitmap bitmap)
        {
 
                for (int i = 0; i < Grid.GetLength(0); i++)
                {
                    for (int j = 0; j < Grid.GetLength(1);j++)
                    {
                        if (Grid[i,j].GetType() == typeof(InitiativeGrass))
                        {
                            Grid[i, j] = new TenderGrass(1, Color.Green);
                        }
                        if (Grid[i, j].GetType() == typeof(TenderGrass))
                        {
                            Grid[i, j] = new AdvancedGrass(2, Color.DarkGreen);
                        }
                    }
                }
            UpdateGrid(bitmap);
        }
        public void UpdateGrid(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            Color cellColor = new();
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {

                    cellColor = Grid[i, j].EntityColor;
                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            } 
        }


    }
}
