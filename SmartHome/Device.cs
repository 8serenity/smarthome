using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Device: IDevice
    {
        public int Address { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public void SwitchOnOff()
        {
            if (IsOn)
            {
                IsOn = true;
            }
            else
            {
                IsOn = false;
            }
        }

        public Device()
        {
            Console.Write("Введите название устройства: ");

            string tempName = Console.ReadLine();

            Name = tempName;
        }
    }
}
