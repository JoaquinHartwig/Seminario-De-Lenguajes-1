using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estructuras_de_Control_FOR__NEXT 
{
    public partial class SumadeLosCuadrados : Form
    {
        public SumadeLosCuadrados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Tomar los primeros n números pares, elevar cada uno al cuadrado y luego sumar esos cuadrados para obtener el resultado final y mostrar el resultado en un MessageBox.
        {
            int resultado = 0; // Variable para almacenar la suma de los cuadrados
            int número = textBox1.Text != "" ? Convert.ToInt32(textBox1.Text) : 0;//Validamos que el usuario haya ingresado un número, si no es así, se asigna el valor 0
            if (número == 0 || número <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }

            for (int i = 1; i <= número; i++)
            {
                int par = 2 * i; // Calculamos el número par correspondiente
                resultado += par * par; // Sumamos el cuadrado al resultado total
            }
            MessageBox.Show($"La suma de los cuadrados de los primeros {número} números pares es: {resultado}");




        }

    }
}
