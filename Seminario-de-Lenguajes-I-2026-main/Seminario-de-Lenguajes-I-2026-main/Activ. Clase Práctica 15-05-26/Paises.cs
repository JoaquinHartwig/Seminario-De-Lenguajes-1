using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    public partial class Paises : Form
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void BtnPais_Click(object sender, EventArgs e)
        {
            string paisSeleccionado = ComBoxPais.SelectedItem?.ToString() ?? "";
            string resultado = paisSeleccionado switch
            {
                "Argentina" => "Argentina está en latinoamérica.",
                "Brasil" => "Brasil está en latinoamérica.",
                "Chile" => "Chile está en latinoamérica.",
                "México" => "México  está en latinoamérica.",
                "Uruguay" => "Uruguay está en latinoamérica.",
                "Noruega" => "Noruega NO está dentro de Latinoamérica.",
                _ => "País no reconocido. Por favor, seleccioná un país de la lista."
            };
            MessageBox.Show(resultado);
        }
    }
}
