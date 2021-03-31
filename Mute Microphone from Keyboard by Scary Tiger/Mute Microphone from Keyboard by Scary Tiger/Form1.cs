using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NAudio.CoreAudioApi;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mute_Microphone_from_Keyboard_by_Scary_Tiger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void microphoneSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMDeviceEnumerator names = new MMDeviceEnumerator();
            var devices = names.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (var device in devices)
                // Label1.text (device.FriendlyName)
                MessageBox.Show(device.FriendlyName);
           // label1.Text = device.FriendlyName;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gotoform2 = new Form2();
            gotoform2.Show();

        }

        private void vEDILALISTAMICROFONIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMDeviceEnumerator names = new MMDeviceEnumerator();
            var devices = names.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (var device in devices)
                MessageBox.Show(device.FriendlyName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var menu = new MenuStrip();
                


                    //(device.FriendlyName);
        }
    }
}
