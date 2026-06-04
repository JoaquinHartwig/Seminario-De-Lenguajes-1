namespace Estructuras_de_Control_FOR__NEXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumadeLosCuadrados sumadeloscuadrados = new SumadeLosCuadrados();
            sumadeloscuadrados.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabladeValores tabladeValores = new TabladeValores();
            tabladeValores.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConversionesDeGrados conversionesDeGrados = new ConversionesDeGrados();
            conversionesDeGrados.ShowDialog();
        }
    }
}
