﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits
{
    internal interface ISimulation
    {
        int X { get; init; }
        int Y { get; init; }
        int CellSize { get; init; }
        int[,] Grid { get; init; }


        Bitmap GenerateBitmap();

        void StartGame();


    }
}