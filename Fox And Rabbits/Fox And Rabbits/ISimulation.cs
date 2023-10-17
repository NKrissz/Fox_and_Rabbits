using Fox_And_Rabbits.Animals;

namespace Fox_And_Rabbits
{
    internal interface ISimulation
    {
        int X { get; init; }
        int Y { get; init; }
        int CellSize { get; init; }
        IEntity[,] Grid { get; init; }


        Bitmap GenerateBitmap();



    }
}
