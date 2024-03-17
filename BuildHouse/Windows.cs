using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс Окна
    internal class Windows : IPart
    {
        public void Build(House house)
        { 
            house.window.Add(new Windows()); 
        }
    }
}
