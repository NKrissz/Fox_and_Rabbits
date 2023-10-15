using Fox_And_Rabbits.Animals;
using Fox_And_Rabbits.Grass;
using Fox_And_Rabbits.Grass.Grass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits
{
    internal class Simulation : ISimulation
    {
        public int X { get; init; }
        public int Y { get; init; }
        public int CellSize { get; init; }
        public int[,] Grid { get; init; }


        public Simulation(int x, int y, int cellSize)
        {
            X = x;
            Y = y;
            CellSize = cellSize;
            Grid = new int[x, y];
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
                            Grid[i, j] = n;
                            InitiativeGrass initiativeGrass = new(0,Color.LightGreen);
                            cellColor = initiativeGrass.GrassColor;
                            break;
                        case int n when (n >= 29 && n <= 56):
                            Grid[i, j] = n;
                            TenderGrass tenderGrass = new(2, Color.Green);
                            cellColor = tenderGrass.GrassColor;
                            break;
                        case int n when (n >= 57 && n <= 84):
                            Grid[i, j] = n;
                            AdvancedGrass advancedGrass = new(3, Color.DarkGreen);
                            cellColor = advancedGrass.GrassColor;
                            break;
                        case int n when (n >= 85 && n <= 94):
                            Grid[i, j] = n;
                            Rabbit rabbit = new(5, false, false, Color.DarkSlateGray);
                            cellColor = rabbit.AnimalColor;
                            break;
                        case int n when (n >= 95 && n <= 100):
                            Grid[i, j] = n;
                            Fox fox = new(5, false, false, Color.Red);
                            cellColor = fox.AnimalColor;
                            break;
                    }

                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            }
            bitmapHandler = bitmap;

        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
