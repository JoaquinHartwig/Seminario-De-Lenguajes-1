using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estructuras_de_Control_FOR__NEXT
{
    public partial class TabladeValores : Form 
    {
        public TabladeValores()//Crear una tabla de valores del -10 al 10,para la sigueinte funcion y=x^2+x+1,mostrar los resultados en un ListBox.
        {
            InitializeComponent();
        }

        private void TabladeValores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x= -10; x <= 10; x++)
            {
                int y = x * x + x + 1; // Calculamos el valor de y para cada valor de x
                listBox1.Items.Add($"x: {x}, y: {y}"); // Agregamos el resultado al ListBox
            }
        }
    }
}
