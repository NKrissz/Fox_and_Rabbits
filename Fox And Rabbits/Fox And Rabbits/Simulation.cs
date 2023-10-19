using Fox_And_Rabbits.Animals;
using Fox_And_Rabbits.Grass;
using Fox_And_Rabbits.Grass.Grass;
using System.Drawing;


namespace Fox_And_Rabbits
{
    internal class Simulation : ISimulation
    {
        readonly Random rnd = new();

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


            Color cellColor = new();

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            Grid[i, j] = new InitiativeGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case 2:
                            Grid[i, j] = new TenderGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                        case 3:
                            Grid[i, j] = new AdvancedGrass();
                            cellColor = Grid[i, j].EntityColor;
                            break;
                    }

                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            }

            int randX;
            int randY;
            for (int i = 0; i < 120; i++)
            {
                randX = rnd.Next(0, X);
                randY = rnd.Next(0, Y);
                Grid[randX, randY] = new Rabbit(5, false, false, Color.DarkSlateGray);
                cellColor = Grid[randX, randY].EntityColor;

                SolidBrush brush = new(cellColor);
                graphics.FillRectangle(brush, randX * CellSize, randX * CellSize, CellSize, CellSize);

            }
            for (int i = 0; i < 40; i++)
            {
                randX = rnd.Next(0, X);
                randY = rnd.Next(0, Y);
                Grid[randX, randY] = new Fox(10, false, false, Color.Red);
                cellColor = Grid[randX, randY].EntityColor;

                SolidBrush brush = new(cellColor);
                graphics.FillRectangle(brush, randX * CellSize, randX * CellSize, CellSize, CellSize);

            }

            bitmapHandler = bitmap;
        }

        bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < X && y >= 0 && y < Y;
        }

        public List<string> ReturnNeighbourCoordinates(int x, int y, Type lookingfor, int num)
        {
            List<string> NeighbourCoordinates = new();

            if (num == 1)
            {
                if (IsValidPosition(x - 1, y - 1) && Grid[x - 1, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y - 1}");
                }
                if (IsValidPosition(x - 1, y) && Grid[x - 1, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y}");
                }
                if (IsValidPosition(x - 1, y + 1) && Grid[x - 1, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y + 1}");
                }
                if (IsValidPosition(x, y - 1) && Grid[x, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y - 1}");
                }
                if (IsValidPosition(x, y + 1) && Grid[x, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y + 1}");
                }
                if (IsValidPosition(x + 1, y - 1) && Grid[x + 1, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y - 1}");
                }
                if (IsValidPosition(x + 1, y) && Grid[x + 1, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y}");
                }
                if (IsValidPosition(x + 1, y + 1) && Grid[x + 1, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y + 1}");
                }
                return NeighbourCoordinates;
            }
            else
            {
                if (IsValidPosition(x - 1, y - 1) && Grid[x - 1, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y - 1}");
                }
                if (IsValidPosition(x - 1, y) && Grid[x - 1, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y}");
                }
                if (IsValidPosition(x - 1, y + 1) && Grid[x - 1, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y + 1}");
                }
                if (IsValidPosition(x, y - 1) && Grid[x, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y - 1}");
                }
                if (IsValidPosition(x, y + 1) && Grid[x, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y + 1}");
                }
                if (IsValidPosition(x + 1, y - 1) && Grid[x + 1, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y - 1}");
                }
                if (IsValidPosition(x + 1, y) && Grid[x + 1, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y}");
                }
                if (IsValidPosition(x + 1, y + 1) && Grid[x + 1, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y + 1}");
                }



                if (IsValidPosition(x - 2, y) && Grid[x - 2, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 2};{y}");
                }
                if (IsValidPosition(x - 2, y + 1) && Grid[x - 2, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 2};{y + 1}");
                }
                if (IsValidPosition(x - 2, y + 2) && Grid[x - 2, y + 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 2};{y + 2}");
                }
                if (IsValidPosition(x - 1, y + 2) && Grid[x - 1, y + 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y + 2}");
                }
                if (IsValidPosition(x, y + 2) && Grid[x, y + 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y + 2}");
                }
                if (IsValidPosition(x + 1, y + 2) && Grid[x + 1, y + 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y + 2}");
                }
                if (IsValidPosition(x + 2, y + 2) && Grid[x + 2, y + 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 2};{y + 2}");
                }
                if (IsValidPosition(x + 2, y + 1) && Grid[x + 2, y + 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 2};{y + 1}");
                }
                if (IsValidPosition(x + 2, y) && Grid[x + 2, y].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 2};{y}");
                }
                if (IsValidPosition(x + 2, y - 1) && Grid[x + 2, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 2};{y - 1}");
                }
                if (IsValidPosition(x + 2, y - 2) && Grid[x + 2, y - 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 2};{y - 2}");
                }
                if (IsValidPosition(x + 1, y - 2) && Grid[x + 1, y - 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x + 1};{y - 2}");
                }
                if (IsValidPosition(x, y - 2) && Grid[x, y - 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x};{y - 2}");
                }
                if (IsValidPosition(x - 1, y - 2) && Grid[x - 1, y - 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 1};{y - 2}");
                }
                if (IsValidPosition(x - 2, y - 2) && Grid[x - 2, y - 2].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 2};{y - 2}");
                }
                if (IsValidPosition(x - 2, y - 1) && Grid[x - 2, y - 1].GetType() == lookingfor)
                {
                    NeighbourCoordinates.Add($"{x - 2};{y - 1}");
                }

                return NeighbourCoordinates;
            }

        }

        public static string[] RandomCoordinateFromList(List<string> list)
        {

            Random randomNum = new();
            int randomElement = randomNum.Next(0, list.Count);
            string[] splitted = list[randomElement].Split(';');
            return splitted;

        }

        public void InitiativeGrassActions(int x, int y)
        {
            if (Grid[x, y] is InitiativeGrass)
            {
                Grid[x, y] = new TenderGrass();

            }

        }

        public void TenderGrassActions(int x, int y)
        {
            if (Grid[x, y] is TenderGrass)
            {
                Grid[x, y] = new AdvancedGrass();

            }


        }

        public void RabbitActions(int x, int y)
        {
            if (Grid[x, y] is Rabbit rabbit)
            {
                if (!rabbit.Ate)
                {

                    List<string> advancedGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(AdvancedGrass), 1);
                    List<string> tenderGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(TenderGrass), 1);
                    List<string> initiativeGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(InitiativeGrass), 1);
                    List<string> rabbitCoordinates = ReturnNeighbourCoordinates(x, y, typeof(Rabbit), 1);


                    if (advancedGrassCoordinates.Count != 0)
                    {
                        string[] splitted = RandomCoordinateFromList(advancedGrassCoordinates);


                        int advancedGrassX = int.Parse(splitted[0]);
                        int advancedGrassY = int.Parse(splitted[1]);


                        Grid[x, y] = new InitiativeGrass();
                        Grid[advancedGrassX, advancedGrassY] = rabbit;


                        rabbit.Saturation += 2;

                        if (rabbit.Saturation > 5)
                        {
                            rabbit.Saturation = 5;
                        }

                        rabbit.Ate = true;

                    }
                    else if (tenderGrassCoordinates.Count != 0 && !rabbit.Ate)
                    {
                        string[] splitted = RandomCoordinateFromList(tenderGrassCoordinates);
                        int tenderGrassX = int.Parse(splitted[0]);
                        int tenderGrassY = int.Parse(splitted[1]);


                        Grid[x, y] = new InitiativeGrass();
                        Grid[tenderGrassX, tenderGrassY] = rabbit;

                        rabbit.Saturation++;

                        if (rabbit.Saturation > 5)
                        {
                            rabbit.Saturation = 5;
                        }


                        rabbit.Ate = true;
                    }



                    else if (initiativeGrassCoordinates.Count != 0)
                    {
                        string[] splitted = RandomCoordinateFromList(initiativeGrassCoordinates);
                        int initiativeGrassX = int.Parse(splitted[0]);
                        int initiativeGrassY = int.Parse(splitted[1]);

                        Grid[x, y] = new InitiativeGrass();
                        Grid[initiativeGrassX, initiativeGrassY] = rabbit;
                    }
                    if (!rabbit.Bred && rabbitCoordinates.Count == 1)
                    {

                        for (int i = 0; i < rabbitCoordinates.Count; i++)
                        {
                            string[] splitted = RandomCoordinateFromList(rabbitCoordinates);
                            int rabbitPairX = int.Parse(splitted[0]);
                            int rabbitPairY = int.Parse(splitted[1]);

                            Rabbit rabbitPair = (Rabbit)Grid[rabbitPairX, rabbitPairY];

                            if (!rabbitPair.Bred)
                            {
                                int newRabbitX;
                                int newRabbitY;
                                do
                                {
                                    newRabbitX = rnd.Next(0, X);
                                    newRabbitY = rnd.Next(0, Y);
                                } while (Grid[newRabbitX, newRabbitY] is Rabbit || Grid[newRabbitX, newRabbitY] is Fox);

                                Grid[newRabbitX, newRabbitY] = new Rabbit(5, true, true, Color.DarkSlateGray);


                                break;
                            }

                        }

                    }

                }                              
                rabbit.Bred = true;
            }

        }

        public void FoxActions(int x, int y)
        {
            if (Grid[x, y] is Fox fox)
            {
                List<string> rabbitCoordinates = ReturnNeighbourCoordinates(x, y, typeof(Rabbit), 2);
                List<string> foxCoordinates = ReturnNeighbourCoordinates(x, y, typeof(Fox), 1);

                
                
                    if (!fox.Ate && rabbitCoordinates.Count != 0)
                    {
                        string[] splitted = RandomCoordinateFromList(rabbitCoordinates);
                        int rabbitX = int.Parse(splitted[0]);
                        int rabbitY = int.Parse(splitted[1]);


                        Grid[x, y] = new TenderGrass();
                        Grid[rabbitX, rabbitY] = fox;


                        fox.Saturation += 3;

                        if (fox.Saturation > 10)
                        {
                            fox.Saturation = 10;
                        }

                        fox.Ate = true;
                    }
                
                else if (rabbitCoordinates.Count == 0)
                    {
                        List<string> advancedGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(AdvancedGrass), 1);
                        List<string> tenderGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(TenderGrass), 1);
                        List<string> initiativeGrassCoordinates = ReturnNeighbourCoordinates(x, y, typeof(InitiativeGrass), 1);
                        List<string> GrassCoordiantes = new();
                        GrassCoordiantes.AddRange(advancedGrassCoordinates);
                        GrassCoordiantes.AddRange(tenderGrassCoordinates);
                        GrassCoordiantes.AddRange(initiativeGrassCoordinates);


                        string[] splitted = RandomCoordinateFromList(GrassCoordiantes);
                        int grassX = int.Parse(splitted[0]);
                        int grassY = int.Parse(splitted[1]);

                        Grid[x, y] = new InitiativeGrass();
                        Grid[grassX, grassY] = fox;
                    if (!fox.Bred && foxCoordinates.Count == 1)
                    {

                        for (int i = 0; i < foxCoordinates.Count; i++)
                        {
                            splitted = RandomCoordinateFromList(foxCoordinates);
                            int foxPairX = int.Parse(splitted[0]);
                            int foxPairY = int.Parse(splitted[1]);

                            Fox foxPair = (Fox)Grid[foxPairX, foxPairY];

                            if (!foxPair.Bred)
                            {
                                int newFoxX;
                                int newFoxY;
                                do
                                {
                                    newFoxX = rnd.Next(0, X);
                                    newFoxY = rnd.Next(0, Y);
                                } while (Grid[newFoxX, newFoxY] is Rabbit || Grid[newFoxX, newFoxY] is Fox);

                                Grid[newFoxX, newFoxY] = new Fox(10, true, true, Color.Red);


                                break;
                            }

                        }

                    }
                }              
                fox.Bred = true;
            }
        }

        public void ResetStats()
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (Grid[i, j] is Rabbit rabbit)
                    {

                        rabbit.Ate = false;
                        rabbit.Bred = false;

                        rabbit.Saturation--;
                        if (rabbit.Saturation == 0)
                        {
                            Grid[i, j] = new InitiativeGrass();
                        }

                    }
                    else if (Grid[i, j] is Fox fox)
                    {
                        fox.Ate = false;
                        fox.Bred = false;


                        fox.Saturation--;

                        if (fox.Saturation == 0)
                        {
                            Grid[i, j] = new InitiativeGrass();
                        }
                    }

                }
            }
        }

        public void UpdateGrid(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Color cellColor = Grid[i, j].EntityColor;
                    SolidBrush brush = new(cellColor);
                    graphics.FillRectangle(brush, j * CellSize, i * CellSize, CellSize, CellSize);
                }
            }
        }

        public int RabbitCounter()
        {
            int rabbit = 0;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (Grid[i, j] is Rabbit)
                    {
                        rabbit++;
                    }
                }
            }
            return rabbit;
        }
        public int FoxCounter()
        {
            int fox = 0;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (Grid[i, j] is Fox)
                    {
                        fox++;
                    }
                }
            }
            return fox;
        }

    }
}
