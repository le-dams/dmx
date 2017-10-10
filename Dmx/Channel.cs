using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dmx
{
    public class Channel
    {
        [DllImport("k8062d.dll")]
        public static extern void SetData(int Channel, int Data);

        [DllImport("k8062d.dll")]
        public static extern void SetChannelCount(int Count);

        int maxValue = 255;
        int[] channels = new int[512];
        private int step = 10;

        public Channel()
        {

        }

        public int getChannelValue(int Channel)
        {
            int currentChannel = this.channels[Channel];
            return currentChannel;
        }

        public void setChannel(int Channel, int Data)
        {
            channels[Channel] = Data;
            SetData(Channel, Data);
        }

        public void upChannel(int Channel)
        {
            int currentValue = getChannelValue(Channel);
            if (currentValue < maxValue)
                setChannel(Channel, currentValue + this.step);
        }

        public void downChannel(int Channel)
        {
            int currentValue = getChannelValue(Channel);
            if (currentValue > 0)
                setChannel(Channel, currentValue - this.step);

        }
    }
}
