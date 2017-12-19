using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class GSM : IDevice
    {
        public int Address { get; set; }

        public bool IsOn { get; set; }

        public string Name { get; set; }

        public void SwitchOnOff()
        {
            if (IsOn)
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
