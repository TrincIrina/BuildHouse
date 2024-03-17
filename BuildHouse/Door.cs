using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс Дверь
    internal class Door : IPart
    {
        public void Build(House house)
        { 
            house.door = new Door(); 
        }
    }
}
