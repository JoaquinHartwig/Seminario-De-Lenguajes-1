using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Check_In
{
    public partial class Form2 : Form

    {
        string tarifa;
        string vuelo;
        public Form2(string tipoTarifa, string tipoVuelo)
        {
            InitializeComponent();

            this.tarifa = tipoTarifa;
            this.vuelo = tipoVuelo;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
            if (tarifa == "P" || tarifa == "B")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            else if (tarifa == "F")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else if (tarifa == "PE")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            double peso1 = (double)numericUpDown1.Value;
            double peso2 = (double)numericUpDown2.Value;
            double peso3 = (double)numericUpDown3.Value;

            string resultado = "";

            double limite1 = vuelo == "N" ? 8 : 10;
            resultado += peso1 <= limite1 ? "Item 1 ✔\n" : "Item 1 ❌\n";

            if (tarifa == "F" || tarifa == "PE")
            {
                double limite2 = vuelo == "N" ? 15 : 23;
                resultado += peso2 <= limite2 ? "Item 2 ✔\n" : "Item 2 ❌\n";
            }

            if (tarifa == "PE")
            {
                double limite3 = vuelo == "N" ? 15 : 23;
                resultado += peso3 <= limite3 ? "Item 3 ✔\n" : "Item 3 ❌\n";
            }

            MessageBox.Show(resultado);
            /*
            Form3 f3 = new Form3(); // Crear y mostrar un nuevo formulario
            f3.Show();
            */
        }
    }
    }

