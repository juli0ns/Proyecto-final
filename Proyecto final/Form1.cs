using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += SerialPort_DataReceived;
            timer1.Interval = 1000;   // 1 segundo
            timer1.Enabled = true;
        }

        private void btnPrender_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = "COM5"; // CAMBIAR AL COM QUE USES
                serialPort.Open();
                MessageBox.Show("Sensor activado.");
            }
            catch
            {
                MessageBox.Show("No se pudo conectar al puerto.");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                    serialPort.Close();

                pictureEstado.BackColor = Color.Gray;
                labelDistancia.Text = "Distancia: --- cm";
            }
            catch { }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine().Trim();

            this.Invoke(new Action(() =>
            {
                // 1?? Extraer solo los dígitos de la línea
                string soloNumero = "";
                foreach (char c in data)
                {
                    if (char.IsDigit(c))
                        soloNumero += c;
                }

                // 2?? Convertir a número
                if (int.TryParse(soloNumero, out int distancia))
                {
                    labelDistancia.Text = $"Distancia: {distancia} cm";

                    // 3?? MISMAS CONDICIONES QUE TU ARDUINO
                    if (distancia >= 40 || distancia <= 0)
                    {
                        pictureEstado.BackColor = Color.Gray;
                    }
                    else if (distancia >= 30)
                    {
                        pictureEstado.BackColor = Color.Green;
                    }
                    else if (distancia >= 20)
                    {
                        pictureEstado.BackColor = Color.Yellow;
                    }
                    else if (distancia >= 10)
                    {
                        pictureEstado.BackColor = Color.Orange;
                    }
                    else
                    {
                        pictureEstado.BackColor = Color.Red;
                    }
                }
            }));
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnVerdeManual_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Write("V");
        }

        private void btnAmarilloManual_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Write("A");
        }

        private void btnNaranjaManual_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Write("N");
        }

        private void btnRojoManual_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Write("R");
        }

        private void btnApagarManual_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Write("X");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value; // 0..255

            if (serialPort.IsOpen)
            {
                // enviamos 'P' seguido del número, por ejemplo "P180"
                serialPort.Write("P" + valor.ToString());
            }
            labelValor.Text = valor.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 🔵 Llenar el ComboBox de puertos COM disponibles
            comboBoxCOM.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(puertos);

            // Opcional: seleccionar el primer COM disponible
            if (puertos.Length > 0)
            {
                comboBoxCOM.SelectedIndex = 0;
            }

            // 🔵 Llenar el ComboBox de baudios
            comboBoxBaud.Items.Clear();
            comboBoxBaud.Items.Add("9600");
            comboBoxBaud.Items.Add("19200");
            comboBoxBaud.Items.Add("38400");
            comboBoxBaud.Items.Add("57600");
            comboBoxBaud.Items.Add("115200");

            // Seleccionar por default 9600 (el que usa Arduino)
            comboBoxBaud.SelectedItem = "9600";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxCOM.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(comboBoxBaud.SelectedItem.ToString());
                    serialPort.Open();

                    MessageBox.Show("Conectado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Desconectado.");
            }
        }
    }
}
                
            
