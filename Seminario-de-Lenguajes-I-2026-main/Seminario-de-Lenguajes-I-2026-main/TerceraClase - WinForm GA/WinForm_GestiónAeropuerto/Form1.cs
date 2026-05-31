using System.Xml.Linq;

namespace WinForm_GestiónAeropuerto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Leer los valores ingresados por el usuario
            string nombrePasajero = txtNombre.Text;
            string apellidoPasajero = txtApellido.Text;
            string nroDocumento = mskTxtDocumento.Text;
            string nroViajeroFreq = txtViajeroFreq.Text;
            string tipoTarifa = comBoxTarifa.Text;
            string tipoVuelo = comBoxVuelo.Text;

            // 2. Validación básica: ningún campo puede estar vacío
            if (string.IsNullOrWhiteSpace(nombrePasajero) ||
                string.IsNullOrWhiteSpace(apellidoPasajero) ||
                string.IsNullOrWhiteSpace(nroDocumento))
            {
                lblResultado.Text = "⚠ Completá todos los campos obligatorios.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
                return; // detiene la ejecución si falta algo
            }

            // 3. Mostrar resultado en el Label
            lblResultado.ForeColor = System.Drawing.Color.Black;
            lblResultado.Text =
                $"||──────── Datos del Check-In ────────||{Environment.NewLine}" +
                $"||Nombre:            {nombrePasajero}||{Environment.NewLine}" +
                $"||Apellido:          {apellidoPasajero}||{Environment.NewLine}" +
                $"||Documento:         {nroDocumento}||{Environment.NewLine}" +
                $"||Viajero frecuente: {nroViajeroFreq}||{Environment.NewLine}"+
                $"||Tipo de tarifa:    {tipoTarifa}||{Environment.NewLine}" +
                $"||Tipo de vuelo:     {tipoVuelo}|| {Environment.NewLine}" +
                $"||------------------------------------||";

            using (var dlg = new ResultDialog(lblResultado.Text))
            {
                dlg.ShowDialog(this);
            }
        }
    }
}
