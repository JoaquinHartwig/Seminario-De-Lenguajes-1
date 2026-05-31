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
    public partial class LeerNúmeros : Form
    {
        public LeerNúmeros()
        {
            InitializeComponent();
        }
        List<double> numeros = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            numeros.Add(num);

            listBox1.Items.Add(num);  // muestra el número en la lista
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double mayor = numeros[0];
            double menor = numeros[0];
            double suma = 0;

            foreach (double num in numeros)
            {
                if (num > mayor) mayor = num;
                if (num < menor) menor = num;
                suma += num;
            }

            double media = suma / numeros.Count;

            MessageBox.Show($"Mayor: {mayor}\nMenor: {menor}\nMedia: {media}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
