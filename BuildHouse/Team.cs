using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    internal class Team
    {
        public TeamLeader foreman;     // бригадир
        public List<Worker> workers;   // список строителей
        public string name = "Бригада строителей 'Домовёнок'"; // название бригады
        public Team()
        {
            foreman = new TeamLeader("Бригадир Афанасий");
            workers = new List<Worker> { 
                new Worker("Строитель Кузьма"), 
                new Worker("Строитель Потап"), 
                new Worker("Строитель Адам"), 
                new Worker("Строитель Святослав") 
            };
        }
    }
}
