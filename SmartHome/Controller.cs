using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Controller
    {
        public GSM GsmModule { get; set; }
        public List<Sensor> Sensors { get; set; }
        public List<User> UserList { get; set; }

        public List<Room> RoomList { get; set; }

        public bool Loginned { get; set; }

        public Controller(int RoomSize)
        {
            for(int i = 0; i < RoomSize; i++)
            {
                RoomList.Add(new Room());
            }
        }


        private void TurnOn(User user,string password)
        {
            if (password == user.Password)
            {
                Loginned = true;
            }else
            {
                Loginned = false;
            }
        }
        private void TurnOff()
        {
            Loginned = false;
        }

        public void RoomSwitchOnOff(int roomNumber)
        {
            if (Loginned)
            {
                for (int i = 0; i < RoomList[i].ActuatorList.Count; i++)
                {
                    RoomList[roomNumber].ActuatorList[i].SwitchOnOff();
                }
            }
        }


        public void RoomSpecificDeviceSwitchOn(int roomNumber,string name)
        {
            if (Loginned)
            {
                for(int i =0;i < RoomList[roomNumber].ActuatorList.Count; i++)
                {
                    for(int j = 0; j < RoomList[roomNumber].ActuatorList[i].ConnectedDevices.Count; i++)
                    {
                       if(RoomList[roomNumber].ActuatorList[i].ConnectedDevices[j].Name == name)
                        {
                            RoomList[roomNumber].ActuatorList[i].ConnectedDevices[j].SwitchOnOff();
                        }
                    }
                }
            }
        }



    }
}
