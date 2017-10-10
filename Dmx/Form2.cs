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
    public partial class Form2 : Form
    {
        DataGridView dataGridView1;
        ListDevice listDevice;

        public Form2(ListDevice listDevice,DataGridView dataGridView1)
        {
            this.listDevice = listDevice;
            this.dataGridView1 = dataGridView1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create device
            Device insertDevice = new Device();
            insertDevice.setDeviceName(textBox1.Text);
            insertDevice.setMaxChannel(Convert.ToInt32(textBox2.Text));
            insertDevice.setStartChannel(Convert.ToInt32(textBox3.Text));
            insertDevice.setPower(Convert.ToInt32(textBox4.Text));

            //List devices
            listDevice.addDevice(insertDevice);

            // DataGrid
            DataGridViewRow row = (DataGridViewRow)dataGridView1.RowTemplate.Clone();

            row.CreateCells(dataGridView1, insertDevice.getDeviceId(), insertDevice.getDeviceName(), insertDevice.getMaxChannel().ToString(), insertDevice.getStartChannel().ToString(), insertDevice.getEndChannel().ToString(), insertDevice.getPower().ToString());

            dataGridView1.Rows.Add(row);

            MessageBox.Show(insertDevice.getDeviceName() + " a bien été ajouté.");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox4.Text = "";
            this.textBox3.Text = "";
            this.textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
