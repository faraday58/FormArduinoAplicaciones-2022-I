using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class FormPruebaLED : Form
    {
        private bool onOff=false;
        public FormPruebaLED()
        {
            InitializeComponent();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(onOff)
            {
                ptbFoco.BackColor = Color.Gray;
                onOff = false;
            }
            else
            {
                ptbFoco.BackColor = Color.Yellow;
                onOff = true;
            }
        }
    }
}
