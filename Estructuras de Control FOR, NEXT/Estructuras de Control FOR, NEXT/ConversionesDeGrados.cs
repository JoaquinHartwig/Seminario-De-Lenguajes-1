using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estructuras_de_Control_FOR__NEXT
{
    public partial class ConversionesDeGrados : Form //Ingresar un valor en grados Celsius y convertirlo a grados Fahrenheit o  Kevin  utilizando la siguiente fórmula: F = (C * 9/5) + 32 K=  Celsius + 273, mostrar el resultado en un MessageBox.
    {
        public ConversionesDeGrados()// F = (C * 9/5) + 32 K=  Celsius + 273, mostrar el resultado en un MessageBox.
        {
            InitializeComponent();
        }

        private void ConversionesDeGrados_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kelvin;
            double fahrenheit;
            double celsius = textBox1.Text != "" ? Convert.ToInt32(textBox1.Text) : 0;//Validamos que el usuario haya ingresado un número, si no es así, se asigna el valor 0
            if (celsius == 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");

                return;

            }
            kelvin = celsius + 273; // Convertimos a Kelvin
            fahrenheit = (celsius * 9.0 / 5.0) + 32; //hacemos q tenga decimal para evitar errores de redondeo al convertir a Fahrenheit
            MessageBox.Show($"Celsius:    {celsius} °C\n" +
                     $"Fahrenheit: {fahrenheit} °F\n" +
                     $"Kelvin:     {kelvin} K");// Mostramos los resultados en un MessageBox
        }
    }
}
