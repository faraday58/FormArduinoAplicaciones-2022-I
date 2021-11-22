using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class FormFiltrarDatos : Form
    {
        List<byte> temperaturas;
        public FormFiltrarDatos(List<byte>  temperaturas )
        {
            InitializeComponent();
            this.temperaturas = temperaturas;
            FiltrarDatos();
        }


        public void FiltrarDatos()
        {
            foreach(byte temperatura in temperaturas   )
            {
                if( temperatura < 40 )
                {
                    lstbTempBajas.Items.Add(temperatura);
                }
                else if(  temperatura > 60)
                {
                    lstbTempAltas.Items.Add(temperatura);
                }
            }
        }
    }
}
