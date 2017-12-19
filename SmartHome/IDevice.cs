using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IDevice
    {
        int Address { get; set; }
        string Name { get; set; }
        bool IsOn { get; set; }

        void SwitchOnOff();
    }
}
