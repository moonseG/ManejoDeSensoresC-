using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace ManejoDeSensoresC_
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value); //recibira el valor de tipo string
        public SerialPort ArduinoPort { get; }       
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM8";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000; //Tiempo que va a esperar que lea
            ArduinoPort.WriteTimeout = 1000; //Tiempo que va a esperar la respuesta 
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler); //Manejador de eventos
            //ArduinoPort.Open();
            //Vinvular eventos
            this.BtnConectar.Click += BtnConectar_Click;
            this.BtnDesconectar.Click += BtnDesconectar_Click;
        }
        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);

        }
        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch
                {
                    //poner accion de aviso de error si es necesario messagebox
                }
            }
            else
                lbTemp.Text = dato;
        }
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(tbLimTemp.Text, out int temperaturaLimit))
                {
                    //convierte el valor a una cadena y luego a un arreglo de bytes
                    string limitString = temperaturaLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("ingresa un valor numerico valido");
                }
                lbConeccion.Text = "Conexion OK";
                lbConeccion.ForeColor = System.Drawing.Color.Lime;
            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicacion correcto o desconecte");
            }
        }  
        
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            BtnConectar.Enabled = true;
            BtnDesconectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            lbConeccion.Text = "Desconectado";
            lbConeccion.ForeColor = System.Drawing.Color.Red;
            lbTemp.Text = "0.0";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbTemp_Click(object sender, EventArgs e)
        {

        }
    }
}
