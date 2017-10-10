using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmx
{
    public class ListDevice
    {
        private int nextInsertId = 1;
        private List<Device> listDevice = new List<Device>();

        public void clearList()
        {
            this.listDevice.Clear();
        }

        public void delDevice(int deviceId)
        {
            this.listDevice.Remove(getDevice(deviceId));
        }

        public void addDevice(Device newDevice)
        {
            if (newDevice.getDeviceId() > 0)
            {
                nextInsertId = newDevice.getDeviceId() + 1;
            }
            else
            {
                newDevice.setDeviceId(nextInsertId);
                ++nextInsertId;
            }
            this.listDevice.Add(newDevice);
        }

        public int getLastInsertId()
        {
            return nextInsertId;
        }

        public Device getDevice(int deviceId)
        {
            foreach (Device element in listDevice)
            {
                if (deviceId == element.getDeviceId())
                {
                    return element;
                }
            }
            return null;
        }

        public List<Device> getList()
        {
            return this.listDevice;
        }

        public int countPower()
        {
            int power = 0;
            foreach(Device device in listDevice)
            {
                power = power + device.getPower();
            }
            return power;
        }

        public int countUseChannel()
        {
            int useChannel = 0;
            foreach (Device device in listDevice)
            {
                useChannel = useChannel + device.getMaxChannel();
            }
            return useChannel;
        }

        public string getExportCSV()
        {
            string output = "";
            foreach (Device element in listDevice)
            {
                output += element.getDeviceId() + ";";
                output += element.getDeviceName() + ";";
                output += element.getMaxChannel() + ";";
                output += element.getStartChannel() + ";";
                output += element.getPower() + ";\t";
            }
            return output;
        }

    }
}
