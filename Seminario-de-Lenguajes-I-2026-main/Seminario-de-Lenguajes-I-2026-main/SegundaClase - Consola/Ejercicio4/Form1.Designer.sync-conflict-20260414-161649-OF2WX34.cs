using System.Windows.Forms;
using WinFormsUILibrary;

namespace Ejercicio4;

partial class Form1
{
    ///  Required designer variable.
    private System.ComponentModel.IContainer components = null;

    ///  Clean up any resources being used.
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

#region Windows Form Designer generated code

    private void InitializeComponent()
    {
        //---------INSTANCIACIÓN---------

        lblNombre         = new Label();
        lblApellido       = new Label();
        lblDocumento      = new Label();
        lblViajeroFreq    = new Label();
        lblTipoTarifa     = new Label();
        lblTipoVuelo      = new Label();

        txNombre          = new TextBox();
        txApellido        = new TextBox();
        txDocumento       = new TextBox();
        txViajeroFreq     = new TextBox();
        txTipoTarifa      = new TextBox();
        txTipoVuelo       = new TextBox();

        btnRegistrar      = new Button();
        lblResultado      = new Label();

        //---------LABELS DE TITULO---------

        // --- lblNombre ---
        lblNombre.Text      = "Nombre: ";
        lblNombre.Location  = new System.Drawing.Point(20, 20);
        lblNombre.Size      = new System.Drawing.Size(135, 25);
        lblNombre.Font      = new System.Drawing.Font("JetBrains Mono", 10);

        // --- lblApellido ---
        lblApellido.Text     = "Apellido: ";
        lblApellido.Location = new System.Drawing.Point(20, 55);
        lblApellido.Size     = new System.Drawing.Size(135, 25);
        lblApellido.Font     = new System.Drawing.Font("JetBrains Mono", 10);

        // --- lblDocumento ---
        lblDocumento.Text     = "Documento: ";
        lblDocumento.Location = new System.Drawing.Point(20, 90);
        lblDocumento.Size     = new System.Drawing.Size(135, 25);
        lblDocumento.Font     = new System.Drawing.Font("JetBrains Mono", 10);

        // --- lblViajeroFreq ---
        lblViajeroFreq.Text     = "Viajero frecuente: ";
        lblViajeroFreq.Location = new System.Drawing.Point(20, 125);
        lblViajeroFreq.Size     = new System.Drawing.Size(135, 25);
        lblViajeroFreq.Font     = new System.Drawing.Font("JetBrains Mono", 10);

        // --- lblTipoTarifa ---
        lblTipoTarifa.Text     = "Tipo de tarifa (P|B|F|PE): ";
        lblTipoTarifa.Location = new System.Drawing.Point(20, 160);
        lblTipoTarifa.Size     = new System.Drawing.Size(135, 25);
        lblTipoTarifa.Font     = new System.Drawing.Font("JetBrains Mono", 10);

        // --- lblTipoVuelo ---
        lblTipoVuelo.Text     = "Tipo de vuelo (N|I): ";
        lblTipoVuelo.Location = new System.Drawing.Point(20, 195);
        lblTipoVuelo.Size     = new System.Drawing.Size(135, 25);
        lblTipoVuelo.Font     = new System.Drawing.Font("JetBrains Mono", 10);

        // ── TextBox (columna derecha) ───────────────────────────
        txNombre.Location = new System.Drawing.Point(165, 20);
        txNombre.Size     = new System.Drawing.Size(250, 25);

        txApellido.Location = new System.Drawing.Point(165, 55);
        txApellido.Size     = new System.Drawing.Size(250, 25);

        txDocumento.Location = new System.Drawing.Point(165, 90);
        txDocumento.Size     = new System.Drawing.Size(250, 25);

        txViajeroFreq.Location = new System.Drawing.Point(165, 125);
        txViajeroFreq.Size     = new System.Drawing.Size(250, 25);

        txTipoTarifa.Location = new System.Drawing.Point(165, 160);
        txTipoTarifa.Size     = new System.Drawing.Size(250, 25);
        txTipoTarifa.MaxLength = 2;   // máximo 2 caracteres (PE)

        txTipoVuelo.Location = new System.Drawing.Point(165, 195);
        txTipoVuelo.Size     = new System.Drawing.Size(250, 25);
        txTipoVuelo.MaxLength = 1;    // solo N o I

        // ── Botón ───────────────────────────────────────────────
        btnRegistrar.Text     = "Registrar Check-In";
        btnRegistrar.Location = new System.Drawing.Point(165, 230);
        btnRegistrar.Size     = new System.Drawing.Size(180, 35);
        btnRegistrar.Click   += new System.EventHandler(btnRegistrar_Click);

        // ── Label resultado (muestra los datos al final) ────────
        lblResultado.Location  = new System.Drawing.Point(20, 280);
        lblResultado.Size      = new System.Drawing.Size(420, 160);
        lblResultado.Font      = new System.Drawing.Font("JetBrains Mono", 9);
        lblResultado.BackColor = System.Drawing.Color.WhiteSmoke;
        lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        // --- Formulario ---
        ClientSize = new System.Drawing.Size(460, 220);
        Text       = "Check-In Aerolínea";
        Controls.AddRange(new System.Windows.Forms.Control[] {
            lblNombre,
            lblApellido,
            lblDocumento,
            lblViajeroFreq,
            lblTipoTarifa,
            lblTipoVuelo,
            txNombre,
            txApellido,
            txDocumento,
            txViajeroFreq,
            txTipoTarifa,
            txTipoVuelo,
            btnRegistrar,
            lblResultado
        });
    }

#endregion

    // Declaración de los controles
    private Label lblNombre, lblApellido, lblDocumento, lblViajeroFreq, lblTipoTarifa, lblTipoVuelo;
    private TextBox txNombre, txApellido, txDocumento, txViajeroFreq, txTipoTarifa, txTipoVuelo;
    private Button  btnRegistrar;
    private Label   lblResultado;
}