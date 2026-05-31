using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm_GestiónAeropuerto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        {
            void pesajeEquipaje(string tipoTarifa, string tipoVuelo)
        {
            int cantidadItems;
            if (tipoTarifa.ToUpper() == "P" || tipoTarifa.ToUpper() == "B")
            {
                cantidadItems = 1;
            }
            else if (tipoTarifa.ToUpper() == "F")
            {
                cantidadItems = 2;
            }
            else
            {
                cantidadItems = 3;
            }

            ImprimirTitulo("Pesaje de Equipaje");

            MensajeInfo($"Cantidad de items permitidos para el equipaje: {cantidadItems}");
            double pesoNacional = 0;
            double pesoInternacional = 0;
            for (int i = 1; i <= cantidadItems; i++)
            {
                Console.WriteLine($"Ingrese el peso del item {i} en kg: ");
                double pesoItem = Convert.ToDouble(Console.ReadLine()!);
                if (cantidadItems == 1)
                {
                    pesoNacional = 8.0;
                    pesoInternacional = 10.0;
                }
                else
                {
                    pesoNacional = 15.0;
                    pesoInternacional = 23.0;
                }

                if (tipoVuelo.ToUpper() == "N")
                {
                    if (pesoItem > pesoNacional)
                    {
                        MensajeError($"El item {i} excede el peso permitido para vuelos nacionales ({pesoNacional} kg).");
                    }
                    else
                    {
                        MensajeExito($"El item {i} cumple con el peso permitido para vuelos nacionales.");
                    }
                }
                else if (pesoItem > pesoInternacional)
                {
                    MensajeError($"El item {i} excede el peso permitido para vuelos internacionales ({pesoInternacional} kg).");
                }
                else
                {
                    MensajeExito($"El item {i} cumple con el peso permitido para vuelos internacionales.");
                }
            }
        }
    }
    }
}
