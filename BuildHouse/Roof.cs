using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс дверь
    internal class Roof : IPart
    {
        public void Build(House house)
        { 
            house.roof = new Roof(); 
        }
    }
}
