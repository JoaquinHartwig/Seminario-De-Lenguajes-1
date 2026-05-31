//namespace Ejercicio4;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        // 1. Leer los valores ingresados por el usuario
        string nombrePasajero = txNombre.Text;
        string apellidoPasajero = txApellido.Text;
        string nroDocumento   = txDocumento.Text;
        string nroViajeroFreq = txViajeroFreq.Text;
        string tipoTarifa     = txTipoTarifa.Text;
        string tipoVuelo      = txTipoVuelo.Text;

        // 2. Validación básica: ningún campo puede estar vacío
        if (string.IsNullOrWhiteSpace(nombrePasajero) ||
            string.IsNullOrWhiteSpace(apellidoPasajero) ||
            string.IsNullOrWhiteSpace(nroDocumento)   ||
            string.IsNullOrWhiteSpace(tipoTarifa)     ||
            string.IsNullOrWhiteSpace(tipoVuelo))
        {
            lblResultado.Text      = "⚠ Completá todos los campos obligatorios.";
            lblResultado.ForeColor = System.Drawing.Color.Red;
            return; // detiene la ejecución si falta algo
        }

        // 3. Procesar tipo de vuelo
        string descripcionVuelo = tipoVuelo.ToUpper() == "N" ? "Nacional" : "Internacional";

        // 4. Mostrar resultado en el Label
        lblResultado.ForeColor = System.Drawing.Color.Black;
        lblResultado.Text =
            $"──── Datos del Check-In ────────────{Environment.NewLine}" +
            $"Nombre:            {nombrePasajero}{Environment.NewLine}"  +
            $"Apellido:          {apellidoPasajero}{Environment.NewLine}" +
            $"Documento:         {nroDocumento}{Environment.NewLine}"    +
            $"Viajero frecuente: {nroViajeroFreq}{Environment.NewLine}"  +
            $"Tipo de tarifa:    {tipoTarifa.ToUpper()}{Environment.NewLine}" +
            $"Tipo de vuelo:     {descripcionVuelo}";
    }
}