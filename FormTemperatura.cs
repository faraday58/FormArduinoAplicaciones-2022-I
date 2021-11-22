using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormArduinoAplicaciones_2022_I
{
    public partial class FormTemperatura : Form
    {
        private byte temperatura;
        private Random aleatorio;
        private uint tiempo;
        
        public FormTemperatura()
        {
            InitializeComponent();
            aleatorio = new Random(); 
        }
        #region Propiedades
        public byte Temperatura { get => temperatura;
            set
            {
                if( value > 100)
                {
                    temperatura = 100;
                }else
                {
                    temperatura = value;
                }    
                

            }
        }
        #endregion
        private void timerTemp_Tick(object sender, EventArgs e)
        {
            Temperatura = (byte )aleatorio.Next(120);
            tiempo++;
            dgvTemperatura.Rows.Add(tiempo, Temperatura);
            chartTemperatura.Series["seTemperatura"].Points.AddXY(tiempo, Temperatura);
        }

        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerTemp.Start();
        }

        private void detenerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerTemp.Stop();
        }
    }
}
