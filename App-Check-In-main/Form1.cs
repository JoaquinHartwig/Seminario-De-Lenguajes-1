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
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = textDocumento.Text;
            string pasajeroFrecuente = txtPasajero.Text;
            string tipoVuelo = rdInternacional.Checked ? "Internacional" : "Nacional";

            // 2. Validar selección de tarifa
            if (cbxTarifa.Text == "")
            {
                MessageBox.Show("Error: Debe seleccionar una tarifa.");
                return;
            }

            string tipoTarifa = cbxTarifa.Text;
            string equipaje = ""; // Variable para guardar la info del equipaje

            // 3. Lógica de equipaje (Guardamos el texto en la variable 'equipaje')
            if (tipoTarifa == "P/B")
            {
                if (rdNacional.Checked) equipaje = "1 ítem de 8 kg.";
                else equipaje = "1 ítem de 10 kg.";
            }
            else if (tipoTarifa == "F")
            {
                if (rdNacional.Checked) equipaje = "1 ítem de 8 kg + 1 ítem de 15 kg.";
                else equipaje = "1 ítem de 10 kg + 1 ítem de 23 kg.";
            }
            else if (tipoTarifa == "PE")
            {
                if (rdNacional.Checked) equipaje = "1 ítem de 8 kg + 2 ítems de 15 kg c/u.";
                else equipaje = "1 ítem de 10 kg + 2 ítems de 23 kg c/u.";
            }

            // 4. Mostrar TODO en un solo mensaje final
            string mensajeFinal = $"DATOS DEL PASAJERO\n" +
                                  $"--------------------------\n" +
                                  $"Nombre completo: {apellido}, {nombre}\n" +
                                  $"DNI: {documento}\n" +
                                  $"Vuelo: {tipoVuelo}\n" +
                                  $"Tarifa: {tipoTarifa}\n\n" +
                                  $"EQUIPAJE PERMITIDO:\n" +
                                  $"{equipaje}";

            MessageBox.Show(mensajeFinal, "Resumen de Check-in");
        }
        
        

        private void cbxTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        
            string tarifa = cbxTarifa.Text;
            string tipoVuelo = rdNacional.Checked ? "N" : "I";

            double peso1 = string.IsNullOrEmpty(textBox1.Text) ? 0 : Convert.ToDouble(textBox1.Text);
            double peso2 = string.IsNullOrEmpty(textBox2.Text) ? 0 : Convert.ToDouble(textBox2.Text);
            double peso3 = string.IsNullOrEmpty(textBox3.Text) ? 0 : Convert.ToDouble(textBox3.Text);

            string resultado = "";

            // ITEM 1 (siempre existe)
            double limite1 = tipoVuelo == "N" ? 8 : 10;

            if (peso1 > limite1)
                resultado += $"Item 1  Excede ({limite1}kg)\n";
            else
                resultado += $"Item 1  OK\n";

            // TARIFA F (2 items)
            if (tarifa == "F" || tarifa == "PE")
            {
                double limite2 = tipoVuelo == "N" ? 15 : 23;

                if (peso2 > limite2)
                    resultado += $"Item 2  Excede ({limite2}kg)\n";
                else
                    resultado += $"Item 2  OK\n";
            }

            // TARIFA PE (3 items)
            if (tarifa == "PE")
            {
                double limite3 = tipoVuelo == "N" ? 15 : 23;

                if (peso3 > limite3)
                    resultado += $"Item 3  Excede ({limite3}kg)\n";
                else
                    resultado += $"Item 3  OK\n";
            }

            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();  
            textDocumento.Clear();  
            txtPasajero.Clear();
            rdNacional.Checked = false;
            rdInternacional.Checked = false;
            cbxTarifa.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string tipoTarifa = cbxTarifa.Text;
            string tipoVuelo = rdNacional.Checked ? "N" : "I";

            Form2 f2 = new Form2(tipoTarifa, tipoVuelo); // Crear formulario
            f2.Show();
        }
    }
    }
    
    
        
    
