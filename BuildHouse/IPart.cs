using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // интерфейс IPart обязывает всех, кто его реализует, реализовать метод Построить
    interface IPart
    { 
        void Build(House house);
    }
}
