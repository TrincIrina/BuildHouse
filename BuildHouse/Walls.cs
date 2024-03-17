using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс Стены
    internal class Walls : IPart
    {
        public void Build(House house)
        { 
            house.walls.Add(new Walls()); 
        }
    }
}
