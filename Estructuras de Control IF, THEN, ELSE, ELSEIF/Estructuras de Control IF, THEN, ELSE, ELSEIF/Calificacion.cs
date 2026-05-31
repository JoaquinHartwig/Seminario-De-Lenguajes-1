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
    public partial class Calificacion : Form
    {
        public Calificacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(textBox1.Text);
            string calificacion = "";
            if (resultado >= 90 && resultado<= 100)
                calificacion = "A";
            else if (resultado >= 80 && resultado <= 89)
                calificacion = "B";
            else if (resultado >= 70 && resultado <= 79)
                calificacion = "C";
            else if (resultado >= 60 && resultado <= 69)
                calificacion = "D";
            else if (resultado >= 40 && resultado <= 59)
                calificacion = "E";
            else
                calificacion = "F";

          MessageBox.Show($" La Calificación es: {calificacion}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
