using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_And_Rabbits
{
    internal class Animals
    {
            public int Hp { get; set; }
            public bool Alive { get; set; }
            public bool Ate { get; set; } = false;
            public bool Bred { get; set; } = false;
            public bool Danced { get; set; } = false;
            public int Color { get; set; }
    }
}
