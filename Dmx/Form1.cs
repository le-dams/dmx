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
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\le-dams\Desktop\k8062d.dll")]
        public static extern void StartDevice();

        [DllImport("k8062d.dll")]
        public static extern void StopDevice();

        ListDevice listDevice = new ListDevice();
        string fileDatabase = @"C:\Users\" + Environment.UserName + @"\dmx.txt";
        int maxPower = 3000;
        int maxChannel = 512;

        public Form1()
        {
            // Main form
            InitializeComponent();

            // Create dataGrid
            createColumn();

            // Devices
            createItems(this.fileDatabase);
            addItems();

            // ProgressBar
            progressBar1.Maximum = maxPower;
            progressBar2.Maximum = maxChannel;
            this.refreshProgressbar();

            timer1.Interval = 1000;
            //timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopDevice();
        }

        private void createColumn()
        {
            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 45;

            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "Non";
            this.Id.Name = "Id";
            this.Id.Width = 300;

            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "Nb de canaux";
            this.Id.Name = "Id";
            this.Id.Width = 100;

            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "Début";
            this.Id.Name = "Id";
            this.Id.Width = 50;

            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "Fin";
            this.Id.Name = "Id";
            this.Id.Width = 50;

            this.Id = new DataGridViewTextBoxColumn();
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Id });
            this.Id.HeaderText = "Consommation";
            this.Id.Name = "Id";
            this.Id.Width = 100;
        }

        private void createItems(string fileSource)
        {
            listDevice.clearList();

            // String to listDevice
            string[] lines = System.IO.File.ReadAllLines(fileSource);
            foreach (string line in lines)
            {
                string[] res = line.Split(';');

                Device device = new Device();
                device.setDeviceId(Convert.ToInt16(res[0]));
                device.setDeviceName(res[1]);
                device.setMaxChannel(Convert.ToInt32(res[2]));
                device.setStartChannel(Convert.ToInt32(res[3]));
                device.setPower(Convert.ToInt32(res[4]));

                listDevice.addDevice(device);
            }
        }

        public DataGridView getDataGridView()
        {
            return this.dataGridView1;
        }

        private void addItems()
        {
            // Reset
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            // Add devices of listDevice
            foreach (Device element in listDevice.getList())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.RowTemplate.Clone();

                row.CreateCells(dataGridView1, element.getDeviceId(), element.getDeviceName(), element.getMaxChannel().ToString(), element.getStartChannel().ToString(), element.getEndChannel().ToString(), element.getPower().ToString());

                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView_Selected(Object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                /*
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int deviceId = Convert.ToInt16(row.Cells[0].Value.ToString());
                Form formControlDevice = new Form3(listDevice.getDevice(deviceId));
                */

                Form formControlDevice = new Form3(listDevice.getDevice(1));
                formControlDevice.ShowDialog();
            }

            this.refreshProgressbar();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form formAddDevice = new Form2(listDevice, dataGridView1);
            formAddDevice.ShowDialog();
        }

        private void listDevice_Save(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(this.fileDatabase, listDevice.getExportCSV());
            MessageBox.Show("Sauvegarde réussie", "Message");
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            string files = openFileDialog1.FileName;

            createItems(files);
            addItems();

            MessageBox.Show("Les appareils ont bien été chargé");
        }

        private void supprimerAppareilSelectionnéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int delDeviceId = Convert.ToInt16(row.Cells[0].Value.ToString()) - 1;

                this.listDevice.delDevice(delDeviceId);
                this.dataGridView1.Rows.Remove(row);
            }

            this.refreshProgressbar();
        }

        private void updateProgressBar(ProgressBar pBar, int value)
        {
            if (value <= pBar.Maximum && value >= pBar.Minimum)
                pBar.Value = value;
            else if (value > pBar.Maximum)
                pBar.Value = pBar.Maximum;
            else if (value < pBar.Minimum)
                pBar.Value = pBar.Minimum;
        }

        private void refreshProgressbar()
        {
            this.label8.Text = this.listDevice.countPower().ToString() + " sur " + maxPower.ToString();
            this.label9.Text = this.listDevice.countUseChannel().ToString() + " sur " + maxChannel.ToString();

            updateProgressBar(this.progressBar1, this.listDevice.countPower());
            updateProgressBar(this.progressBar2, this.listDevice.countUseChannel());
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.refreshProgressbar();
            MessageBox.Show("La liste a été mise à jour");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rndNumbers = new Random();

            this.Text = rndNumbers.Next(255).ToString();
        }

        private void dmxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if(this.dmxEnabled.Enabled == true)
            {
                StartDevice();
            }
            else
            {
                StopDevice();
            }
        }

    }
}
