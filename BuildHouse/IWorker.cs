using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // интерфейс IWorker обязывает всех, кто его реализует, иметь имя
    interface IWorker
    { 
        string Name { get; }
    }
}
