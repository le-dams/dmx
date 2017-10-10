using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dmx
{
    public partial class Form3 : Form
    {
        Channel channel = new Channel();
        Device deviceControl = null;

        public Form3(Device deviceIn)
        {
            //Load Device
            deviceControl = getSampleDevice();
            InitializeComponent();

            this.Text = deviceControl.getDeviceName();

            timerRandom.Stop();
        }

        private Device getSampleDevice()
        {
            Device deviceSample = new Device();
            deviceSample.setDeviceId(1);
            deviceSample.setDeviceName("jbSystem Micro Scan");
            deviceSample.setStartChannel(1);
            deviceSample.setMaxChannel(5);
            deviceSample.setPower(200);

            return deviceSample;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label1.Text = "Click bouton ;    " + e.KeyChar            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //String.Compare(e.KeyCode.ToString(),"F1",true)
        }

        private void devicesRandom()
        {
            Random rndNumbers = new Random();
            /*
            int rndNumber = 0;
            int startChannel = 1;
            int endChannel = 5;
            */ 

            int tiltChannel = Convert.ToInt32(this.textTilt.Text) + this.deviceControl.getStartChannel() - 1;
            int panChannel = Convert.ToInt32(this.textPan.Text) + this.deviceControl.getStartChannel() - 1;

            this.channel.setChannel(tiltChannel, rndNumbers.Next(255));
            this.channel.setChannel(panChannel, rndNumbers.Next(255));

            /*
            for (int i = startChannel; i <= endChannel; i++)
            {
                rndNumber = rndNumbers.Next(255);
                this.channel.setChannel(i,rndNumber);
            }
            */

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 255; i++)
            {
                this.hScrollBar1.Value = i;
                this.channel.setChannel(this.getCurrentChannel(), i);
                System.Threading.Thread.Sleep(10);
            }

            for (int i = 255; i >= 0; i--)
            {
                this.hScrollBar1.Value = i;
                this.channel.setChannel(this.getCurrentChannel(), i);
                System.Threading.Thread.Sleep(10);
            }
        }

        private void comboBox1_Changed(object sender, EventArgs e)
        {
            this.label2.Text = (255 - this.channel.getChannelValue(this.getCurrentChannel())).ToString();
            this.hScrollBar1.Value = this.channel.getChannelValue(this.getCurrentChannel());
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.label2.Text = Convert.ToString(255 - hScrollBar1.Value);
            this.channel.setChannel(this.getCurrentChannel(), hScrollBar1.Value);
        }

        private int getCurrentChannel()
        {
            return Convert.ToInt16(this.comboBox1.Text);
        }

        private void releaseCenter(Boolean on = true)
        {
            this.buttonCenter.Enabled = on;
            this.buttonCenter.Enabled = on;

            this.releaseRandom(on);
        }

        private void releaseRandom(Boolean on = true)
        {
            this.checkBoxRandom.Enabled = on;
            this.vScrollBarRandom.Enabled = on;
        }

        private void releaseTilt(Boolean on = true)
        {
            this.tiltUp.Enabled = on;
            this.tiltDown.Enabled = on;
        }

        private void releasePan(Boolean on = true)
        {
            this.panLeft.Enabled = on;
            this.panRight.Enabled = on;
        }

        private void tiltUp_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(this.textTilt.Text) + this.deviceControl.getStartChannel() - 1;
            this.channel.upChannel(channel);
        }

        private void tiltDown_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(this.textTilt.Text) + this.deviceControl.getStartChannel() - 1;
            this.channel.downChannel(channel);
        }

        private void panLeft_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(this.textPan.Text) + this.deviceControl.getStartChannel() - 1;
            this.channel.upChannel(channel);
        }

        private void panRight_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(this.textPan.Text) + this.deviceControl.getStartChannel() - 1;
            this.channel.upChannel(channel);
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            int tiltChannel = Convert.ToInt32(this.textTilt.Text) + this.deviceControl.getStartChannel() - 1;
            int panChannel = Convert.ToInt32(this.textPan.Text) + this.deviceControl.getStartChannel() - 1;
            this.channel.setChannel(tiltChannel, 128);
            this.channel.setChannel(panChannel, 128);
        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= this.deviceControl.getMaxChannel(); i++)
            {
                channel.setChannel((deviceControl.getStartChannel()+i-1),255);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hScrollBar1.Value = channel.getChannelValue(Convert.ToInt32(comboBox1.Text));
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {
            this.devicesRandom();
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRandom.Enabled == true)
            {
                // Enabled
                this.vScrollBarRandom.Value = 1000; 
                this.vScrollBarRandom.Enabled = true;

                this.timerRandom.Interval = this.vScrollBarRandom.Value;
                this.timerRandom.Start();
            }

            if (this.checkBoxRandom.Enabled == false)
            {
                // Disabled
                this.vScrollBarRandom.Enabled = false;
                this.timerRandom.Interval = 0;
                this.timerRandom.Stop();
            }
        }

        private void vScrollBarRandom_Scroll(object sender, ScrollEventArgs e)
        {
            this.labelRandom.Text = this.vScrollBarRandom.Value.ToString();
            this.timerRandom.Interval = this.vScrollBarRandom.Value;
        }

        private void textPan_TextChanged(object sender, EventArgs e)
        {
            if (this.textPan.Text != "")
            {
                if (this.textTilt.Text != "")
                {
                    this.releaseCenter(true);
                }
                this.releasePan(true);
            }
            else
            {
                this.releaseCenter(false);
                this.releasePan(false);
            }
        }

        private void textTilt_TextChanged(object sender, EventArgs e)
        {
            if(this.textTilt.Text != "")
            {
                if (this.textPan.Text != "")
                {
                    this.releaseCenter(true);
                }
                this.releaseTilt(true);
            }
            else
            {
                this.releaseCenter(false);
                this.releaseTilt(false);
            }
        }

    }
}
