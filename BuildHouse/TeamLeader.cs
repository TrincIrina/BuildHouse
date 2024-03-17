using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    internal class TeamLeader : IWorker
    {
        string Name { get; set; }     // имя бригадира
        public List<string> report;   // перечень выполненных работ
        string IWorker.Name => Name;  // реализуем интерфейс IWorker
        // конструктор с параметром
        public TeamLeader(string name) 
        { 
            Name = name;
            report = new List<string>();
        }
        // метод вычисления доли выполненных работ
        public void Report()
        {
            double d = (report.Count / 11.0) * 100; 
            Console.WriteLine($"{(int)d}% работы над домом завершено!");
        }
    }
}
