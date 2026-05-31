namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    public partial class Fechas : Form
    {
        private DateTime fecha1;
        private DateTime fecha2;

        public Fechas()
        {
            InitializeComponent();
        }

        private void BtnPrimeraFecha_Click(object sender, EventArgs e)
        {
            fecha1 = DtpFecha1.Value;
            MessageBox.Show($"Fecha 1 guardada: {fecha1:dd/MM/yyyy}");
        }

        private void BtnSegundaFecha_Click(object sender, EventArgs e)
        {
            fecha2 = DtpFecha2.Value;
            MessageBox.Show($"Fecha 2 guardada: {fecha2:dd/MM/yyyy}");
            CompararFechas(); // Llamar la comparación
        }

        private void CompararFechas()
        {
            if (fecha1 < fecha2)
                MessageBox.Show($"La Fecha 1 ({fecha1:dd/MM/yyyy}) es anterior a la Fecha 2 ({fecha2:dd/MM/yyyy})");
            else if (fecha1 > fecha2)
                MessageBox.Show($"Fecha 1 ({fecha1:dd/MM/yyyy}) es posterior a Fecha 2 ({fecha2:dd/MM/yyyy})");
            else
                MessageBox.Show("Las fechas son iguales");
        }
    }
}
