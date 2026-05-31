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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calificacion calificacion = new Calificacion();
            calificacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeerNúmeros leerNúmeros = new LeerNúmeros();
            leerNúmeros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leer3Numeroscs leer3Numeroscs = new Leer3Numeroscs();
            leer3Numeroscs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fechas fechas = new Fechas();
            fechas.Show();
        }
    }
}
