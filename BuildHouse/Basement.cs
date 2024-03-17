using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс Фундамент
    internal class Basement : IPart
    {
        public void Build(House house)
        { 
            house.basement = new Basement(); 
        }
    }
}
