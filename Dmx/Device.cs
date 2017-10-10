using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmx
{
    public class Device
    {
        private int deviceId = 0;
        private int startChannel = 0;
        private string deviceName = "";
        private int maxChannel = 0;
        private int power = 0;
        private string[] channels = { };

        public Device()
        {

        }

        /* Getter */

        public int getDeviceId()
        {
            return this.deviceId;
        }

        public string getDeviceName()
        {
            return this.deviceName;
        }

        public int getMaxChannel()
        {
            return this.maxChannel;
        }

        public int getPower()
        {
            return this.power;
        }

        public string getChannel(int channel)
        {
            return this.channels[channel];
        }

        public int getStartChannel()
        {
            return this.startChannel;
        }

        public int getEndChannel()
        {
            return this.getStartChannel() + this.getMaxChannel() - 1;
        }

        /* Setter */

        public void setDeviceId(int newId)
        {
            this.deviceId = newId;
        }

        public void setDeviceName(string newValue)
        {
            this.deviceName = newValue;
        }

        public void setMaxChannel(int newValue)
        {
            this.maxChannel = newValue;
        }

        public void setPower(int newValue)
        {
            this.power = newValue;
        }

        public void setChannel(int channel, string channelName)
        {
             this.channels[channel] = channelName;
        }

        public void setStartChannel(int channel)
        {
            this.startChannel = channel;
        }
    }
}
