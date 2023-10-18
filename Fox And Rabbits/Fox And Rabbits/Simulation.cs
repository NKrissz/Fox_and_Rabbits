using Fox_And_Rabbits.Animals;
using Fox_And_Rabbits.Grass;
using Fox_And_Rabbits.Grass.Grass;

namespace Fox_And_Rabbits
{
    internal class Simulation : ISimulation
    {
        public int X { get; init; }
        public int Y { get; init; }
        public int CellSize { get; init; }
        public IEntity[,] Grid { get; init; }


        public Simulation(int x, int y, int cellSize)
        {
            X = x;
            Y = y;
            CellSize = cellSize;
            Grid = new IEntity[x, y];
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
                            Grid[i, j] = new InitiativeGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 29 && n <= 56):
                            Grid[i, j] = new TenderGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 57 && n <= 95):
                            Grid[i, j] = new AdvancedGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 95 && n <= 98):
                            Grid[i, j] = new Rabbit(5, false, false, Color.DarkSlateGray);
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case int n when (n >= 98 && n <= 100):
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
                    if (Grid[i, j] is Rabbit)
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
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    if (Grid[i, j] is InitiativeGrass)
                    {
                        Grid[i, j] = new TenderGrass();
                    }
                    else if (Grid[i, j] is TenderGrass)
                    {
                        Grid[i, j] = new AdvancedGrass();
                    }
                    else if (Grid[i, j] is Rabbit)
                    {
                        Rabbit rabbit = (Rabbit)Grid[i, j];
                        Random randomNum = new Random();
                        int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
                        int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

                        int advancedgrassX = -1, advancedgrassY = -1;
                        int tendergrassX = -1, tendergrassY = -1;
                        bool rabbitfound = false;

                        for (int k = 0; k < 8; k++)
                        {
                            int newX = i + dx[randomNum.Next(0,8)];
                            int newY = j + dy[randomNum.Next(0, 8)];
                            if (IsValidPosition(newX, newY))
                            {
                                if (Grid[newX, newY] is AdvancedGrass)
                                {
                                    advancedgrassX = newX;
                                    advancedgrassY = newY;
                                }
                                else if (Grid[newX, newY] is TenderGrass)
                                {
                                    tendergrassX = newX;
                                    tendergrassY = newY;
                                }else if (Grid[newX, newY] is Rabbit)
                                {
                                    rabbitfound = true;
                                }
                            }
                        }
                        if (advancedgrassX != -1 && rabbit.Saturation <= 3)
                        {
                            Grid[i, j] = new TenderGrass();
                            Grid[advancedgrassX, advancedgrassY] = rabbit;
                            rabbit.Saturation += 2;
                        }else if (tendergrassX != -1 && rabbit.Saturation <= 3)
                        {
                            Grid[i, j] = new InitiativeGrass();
                            Grid[tendergrassX, tendergrassY] = rabbit;
                            rabbit.Saturation += 1;
                        }
                        int randX;
                        int randY;
                        do
                        {
                            randX = randomNum.Next(0, Grid.GetLength(0));
                            randY = randomNum.Next(0, Grid.GetLength(1));
                        } while (Grid[randX, randY] is Fox);
                        if (rabbitfound && !rabbit.Bred)
                        { 
                                Grid[randX,randY] = new Rabbit(5, false, true, Color.DarkSlateGray);
                                rabbit.Bred = true;
                        }
                        bool IsValidPosition(int x, int y)
                        {
                            return x >= 0 && x < Grid.GetLength(0) && y >= 0 && y < Grid.GetLength(1);
                        }
                        rabbit.Saturation --;
                        rabbit.Bred = false;
                        if (rabbit.Saturation == 0)
                        {
                            Grid[i, j] = new InitiativeGrass();
                        }
                    }
                    else if (Grid[i, j] is Fox)
                    {
                        Fox fox = (Fox)Grid[i,j];
                        Random randomNum = new Random();
                    }
                }
            }
            UpdateGrid(bitmap);
        }

        public void UpdateGrid(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Color cellColor = Grid[i, j].EntityColor;
                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            }
        }


    }
}
