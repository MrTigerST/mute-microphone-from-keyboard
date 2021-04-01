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

        //Il codice è stato scritto da Scary Tiger (Mr Tiger). 
        //Licenza MIT Libera (Copyleft) ma vietato modificare i diritti d'Autore.
        //E' stato utilizzato GitHub SOLO per collaborare.
        //Il programma ha disponibile solo 2 lingue: Inglese e Italiano.      Predenfinito: Inglese.
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var menu = new MenuStrip();


            Console.WriteLine("Program By Scary Tiger (Mr Tiger)");
            //console.ReadLine();
            if (progressBar1.Value != 0)
            {
                progressBar1.Visible = false;
            }

            MMDeviceEnumerator names = new MMDeviceEnumerator();
            var devices = names.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (var device in devices)
                comboBox1.Items.Add(device.FriendlyName);
            //(device.FriendlyName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                progressBar1.Visible = false;
                
               


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The purpose of the program is to mute microphones where the mute button does not exist. Created by Scary Tiger (Mr Tiger)" , "Info Program",MessageBoxButtons.OK);
        }
    }
}
