using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Sensor : IDevice
    {
        public int Address { get; set; }

        public bool IsOn { get; set; }

        public string Name { get; set; }
        public double LowZone { get; set; }
        public double HighZone { get; set; }
        public double CurrentZone { get; set; }
        

        public void SwitchOnOff()
        {
            if (CurrentZone < HighZone && CurrentZone > LowZone)
            {
                IsOn = false;
            }
            else
            {
                IsOn = true;
            }
        }
    }
}
