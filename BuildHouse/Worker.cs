using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    internal class Worker : IWorker
    {
        string Name { get; set; }     // имя строителя
        string IWorker.Name => Name;  // реализуем интерфейс IWorker
        // конструктор с параметром
        public Worker(string name) 
        { 
            Name = name; 
        }
        // метод постройки дома
        public void Build(House house, TeamLeader foreman)
        {
            // если фундамент не построен
            if (house.basement == null) 
            {
                // создаем объект класса Фундамент
                Basement basement = new Basement();
                // строим фундамент
                basement.Build(house);
                // добавляем информацию в отчет бригадира
                foreman.report.Add($"{Name} построил фундамент!"); 
            }
            // проверяем построены ли стены(их должно быть 4)
            else if (house.walls == null || house.walls.Count < 4) 
            {
                if (house.walls == null) 
                {
                    // создать список объектов класса Стены
                    house.walls = new List<Walls>(); 
                }
                Walls wall = new Walls();   // создаем объект класса Стены
                wall.Build(house);          // строим стену
                // добавляем информацию в отчет бригадира
                foreman.report.Add($"{Name} построил {house.walls.Count} стену!"); 
            }
            else if (house.door == null) 
            {
                // создаем объект класса Дверь
                Door door = new Door(); 
                door.Build(house);
                // добавляем информацию в отчет бригадира
                foreman.report.Add($"{Name} построил дверь!");
            }
            // проверяем установлены ли окна
            else if (house.window == null || house.window.Count < 4) 
            {
                if (house.window == null) 
                {
                    // создать список объектов класса Окна
                    house.window = new List<Windows>(); 
                }
                Windows window = new Windows();    // создаем объект класса Окна
                window.Build(house);               // строим окно
                // добавляем информацию в отчет бригадира
                foreman.report.Add($"{Name} построил {house.window.Count} окно!"); 
            }
            // проверяем есть ли крыша
            else if (house.roof == null) 
            {
                Roof roof = new Roof();   // создаем объект класса Крыша
                roof.Build(house);        // строим крышу
                // добавляем информацию в отчет бригадира
                foreman.report.Add($"{Name} построил крышу!"); 
            }
        }
    }
}
