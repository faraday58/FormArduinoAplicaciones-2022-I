using System;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
