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
    public partial class Fechas : Form
    {
        public Fechas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha1 = textBox1.Text;
            string[] partes=fecha1.Split('/'); 
            int año = int.Parse(partes[2]);
            if ((año % 4 == 0 && año % 100 != 0) || año % 400 == 0)
                MessageBox.Show($"{año} Es bisiesto");
            else
                MessageBox.Show($"{año} No es bisiesto");
        }
    }
}
