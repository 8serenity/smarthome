using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Actuator : IDevice
    {
        public int Address { get; set; }
        public bool IsOn { get; set; }
        public string Name { get; set; }

        public List<Device> ConnectedDevices { get; set; }

        public void SwitchOnOff()
        {
            for (int i = 0; i < ConnectedDevices.Count; i++)
            {
                ConnectedDevices[i].SwitchOnOff();
            }
        }

        public void AddDevice()
        {
            ConnectedDevices.Add(new Device());

            Console.WriteLine("Устройство успешно добавлено!");
        }
    }
}
