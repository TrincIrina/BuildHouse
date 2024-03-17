using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    // Класс Дом
    internal class House
    {
        public Basement basement;    // фундамент
        public List<Walls> walls;    // список стен
        public List<Windows> window; // список окон
        public Door door;            // дверь
        public Roof roof;            // крыша
        // метод отрисовки дома
        public void Paint(TeamLeader foreman)
        {
            // когда дом полностью достроен
            if (foreman.report.Count == 11) 
            {
                // рисуем дом
                string completeHouse = @"
      /\
     /  \
    /    \
   /      \
  /        \
 /          \
/------------\
 |          |
 |   ____   |
 |   |--|   |
 |   ====   |
 |          |
 |          |
 |   ____   |
 |   |  |   |
 |   | '|   |
 |   |  |   |
 |   ====   |
 |==========|
 |__________|";

                Console.WriteLine(completeHouse);
            }
            else
            { 
                Console.WriteLine("Дом еще не достроен.");
            }
        }
    }
}
