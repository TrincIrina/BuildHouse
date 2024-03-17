using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int houseParts = 11;   // объявляем константу, всего в доме 11 частей
            House house = new House();   // создаем объект класса Дом
            Team team = new Team();      // создаем объект класса Бригада строителей

            Console.WriteLine(team.name); 

            Random random = new Random();

            for (int i = 0; i < houseParts; i++) // по числу частей дома
            {
                // один из строителей по порядку строит части дома
                team.workers[random.Next(0, 4)].Build(house, team.foreman);
                // на пятой части выводим текущий прогресс постройки дома
                if (i == 4) { 
                    foreach (var a in team.foreman.report)
                    {
                        Console.WriteLine(a); 
                    }
                    team.foreman.Report();     // бригадир отчитывается о части выполненных работ
                    house.Paint(team.foreman); // попробуем нарисовать дом, до того, как он будет готов
                }
                // на девятой части выводим текущий прогресс постройки дома
                if (i == 8) 
                {
                    foreach (var a in team.foreman.report)
                    {
                        Console.WriteLine(a); 
                    }
                    team.foreman.Report();   // бригадир отчитывается о части выполненных работ
                }
            }
            // после того, как дом построен выводим, что конкретно построено на данный момент
            foreach (var a in team.foreman.report)
            {
                Console.WriteLine(a);
            }
            team.foreman.Report();     // бригадир отчитывается о части выполненных работ

            house.Paint(team.foreman); // рисуем дом
        }
    }
}
