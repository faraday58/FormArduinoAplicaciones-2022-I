using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class FormPruebaLED : Form
    {
        private bool onOff=false;
        private SerialPort serialPort;
        public FormPruebaLED(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(onOff)
            {
                ptbFoco.BackColor = Color.Gray;
                serialPort.Write("a");
                onOff = false;
            }
            else
            {
                ptbFoco.BackColor = Color.Yellow;
                serialPort.Write("p");
                onOff = true;
            }
        }
    }
}
