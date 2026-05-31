using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void BtnProgramPais_Click(object sender, EventArgs e)
        {
            Paises paisesForm = new Paises();
            paisesForm.ShowDialog();
        }

        private void BtnProgramEdad_Click(object sender, EventArgs e)
        {
            Fechas fechasForm = new Fechas();
            fechasForm.ShowDialog();
        }
    }
}