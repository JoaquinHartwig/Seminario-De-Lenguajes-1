using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_de_Control_IF__THEN__ELSE__ELSEIF
{
    public partial class Leer3Numeroscs : Form

    {
        int resultado;
        public Leer3Numeroscs()
        {
            InitializeComponent();
        }
        List<int> numeros = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (numeros.Count >= 3)
            {
                MessageBox.Show("Ya ingresaste 3 números");
                return;
            }

            int num = int.Parse(textBox1.Text);
            numeros.Add(num);

            listBox1.Items.Add(num);
            textBox1.Clear();
            textBox1.Focus();

            label4.Text = $"Números ingresados: {numeros.Count} de 3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numeros.Count < 3) {
                MessageBox.Show("Debes ingresar 3 números antes de calcular");
                return;

            }
         
            else if (numeros[0] < 0)
            {
                resultado = numeros[0] + numeros[1] + numeros[2];

            }
            else {
                resultado = numeros[0] * numeros[1] * numeros[2];

            }
            MessageBox.Show($"El resultado es: {resultado}");

        }
    }
}
