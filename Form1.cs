using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            Selecciona();
            tlsCmbVelocidad.SelectedIndex = 2;
        }

        public void Selecciona()
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tlsCmbPuertos.Items.AddRange(puertos);
            
        }

        private void pruebaLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPruebaLED formPruebaLED = new FormPruebaLED(serialPort);
            formPruebaLED.MdiParent = this;
            formPruebaLED.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura(serialPort);
            formTemperatura.MdiParent = this;
            formTemperatura.Show();

        }

        private void verficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.BaudRate = int.Parse(tlsCmbVelocidad.SelectedItem.ToString());
                serialPort.PortName = tlsCmbPuertos.SelectedItem.ToString();

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message,"Error: ");
            }

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            conectarToolStripMenuItem.Enabled = false;
        }
    }
}
