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
        }

        public void Selecciona()
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tlsCmbPuertos.Items.AddRange(puertos);

        }

        private void pruebaLEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPruebaLED formPruebaLED = new FormPruebaLED();
            formPruebaLED.MdiParent = this;
            formPruebaLED.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatura formTemperatura = new FormTemperatura();
            formTemperatura.MdiParent = this;
            formTemperatura.Show();

        }

        private void verficarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
