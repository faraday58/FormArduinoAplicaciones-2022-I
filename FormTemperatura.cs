using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace FormArduinoAplicaciones_2022_I
{
    public partial class FormTemperatura : Form
    {
        private byte temperatura;
        private Random aleatorio;
        private uint tiempo;
        private List<byte> temperaturas;
        private const string filtroArchivos = "Archivos de Texto | *.txt|Archivos con campos separdados por ','|*.csv|Todos los archivos | *.*";
        private SerialPort serialPort;
        bool simulador;

        public FormTemperatura(SerialPort serialPort)
        {
            InitializeComponent();
            aleatorio = new Random();
            ValidarGuardar();
            this.serialPort = serialPort;
        }
        #region Propiedades
        public byte Temperatura { get => temperatura;
            set
            {
                if (value > 100)
                {
                    temperatura = 100;
                } else
                {
                    temperatura = value;
                }


            }
        }
        #endregion



        private void ValidarGuardar()
        { 
            if(dgvTemperatura.Rows.Count == 0   )
            {
                guardarToolStripMenuItem.Enabled = false;
            }
            else
            {
                guardarToolStripMenuItem.Enabled = true;
            }
        }

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            if( simulador)
            {
                Temperatura = (byte)aleatorio.Next(120);
                tiempo++;
                dgvTemperatura.Rows.Add(tiempo, Temperatura);
                chartTemperatura.Series["seTemperatura"].Points.AddXY(tiempo, Temperatura);
            }
            else
            {
                tiempo++;
                Temperatura =(byte)serialPort.ReadByte();
                dgvTemperatura.Rows.Add(tiempo, Temperatura);
                chartTemperatura.Series["seTemperatura"].Points.AddXY(tiempo, Temperatura);
            }
            
        }

        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.iniciarToolStripMenuItem1.Image = global::FormArduinoAplicaciones_2022_I.Properties.Resources.playApagado;
            timerTemp.Start();
            simulador = true;

        }

        private void detenerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerTemp.Stop();
            ValidarGuardar();
            this.iniciarToolStripMenuItem1.Image = global::FormArduinoAplicaciones_2022_I.Properties.Resources.playPrendido;
            simulador = false;
        }

        private void filtrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temperaturas = new List<byte>();
            for (int i=0; i< dgvTemperatura.Rows.Count; i++ )
            {
                Temperatura =Convert.ToByte( dgvTemperatura.Rows[i].Cells["ColTemperatura"].Value);

                temperaturas.Add(Temperatura);
            }

            FormFiltrarDatos formFiltrarDatos = new FormFiltrarDatos(temperaturas);
            formFiltrarDatos.Show();

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = filtroArchivos;
            sfd.DefaultExt = "*.txt";
            StreamWriter sw = null;

            if(sfd.ShowDialog() == DialogResult.OK    )
            {
                try
                {
                    sw = new StreamWriter(sfd.FileName );
                    sw.WriteLine("Tiempo,Temperatura");
                    for(int i=0; i< dgvTemperatura.Rows.Count; i++  )
                    {
                        sw.WriteLine("{0},{1}", dgvTemperatura.Rows[i].Cells["ColTiempo"].Value, dgvTemperatura.Rows[i].Cells["ColTemperatura"].Value);
                    }

                }
                catch (IOException error)
                {
                    MessageBox.Show(error.Message, "Error");
                }
                finally
                {
                    sw.Close();
                }

            }



        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filtroArchivos;
            ofd.DefaultExt = "*.txt";

            StreamReader sr = null;

            if(  ofd.ShowDialog()  == DialogResult.OK   )
            {
                try
                {
                    sr = new StreamReader(ofd.FileName);
                    string linea = sr.ReadLine();
                    linea = sr.ReadLine();
                    while (linea != null)
                    {
                        string[] datos = linea.Split(',');
                        dgvTemperatura.Rows.Add(datos[0], datos[1]);
                        chartTemperatura.Series["seTemperatura"].Points.AddXY(datos[0], datos[1]);
                        linea = sr.ReadLine();
                    }

                }
                catch(IOException error)
                {
                    MessageBox.Show(error.Message, "Error");
                }
                finally
                {
                    sr.Close();
                }
            }



        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo ...");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemp.Start();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemp.Stop();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document docPdf = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = " Archivos pdf | *.pdf  ";

            if( sfd.ShowDialog() == DialogResult.OK  )
            {
                PdfWriter pdfWriter = PdfWriter.GetInstance(docPdf, new FileStream(sfd.FileName,FileMode.Append ));
                docPdf.Open();
                MemoryStream imagenStream = new MemoryStream();
                chartTemperatura.SaveImage(imagenStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                iTextSharp.text.Image ImagenPDF = iTextSharp.text.Image.GetInstance(imagenStream.GetBuffer());
                docPdf.Add(ImagenPDF);
                docPdf.Close();

            }


        }
    }
}
