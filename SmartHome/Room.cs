using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Room
    {
        public string Name { get; set; }
        public int CounterRoom { get; set; }
        public List<Actuator> ActuatorList { get; set; }

        public Room()
        {
            Console.WriteLine("Введите название комнаты: ");

            string tempName = Console.ReadLine();

            Name = tempName;
        }
    }
}