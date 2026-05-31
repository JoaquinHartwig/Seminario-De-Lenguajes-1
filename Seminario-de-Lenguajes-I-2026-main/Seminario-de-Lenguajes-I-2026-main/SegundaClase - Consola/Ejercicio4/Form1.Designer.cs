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
        lblNombre = new Label();
        lblApellido = new Label();
        lblDocumento = new Label();
        lblViajeroFreq = new Label();
        lblTipoTarifa = new Label();
        lblTipoVuelo = new Label();
        txNombre = new TextBox();
        txApellido = new TextBox();
        txDocumento = new TextBox();
        txViajeroFreq = new TextBox();
        txTipoTarifa = new TextBox();
        txTipoVuelo = new TextBox();
        btnRegistrar = new Button();
        lblResultado = new Label();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.Font = new Font("JetBrains Mono", 10F);
        lblNombre.Location = new Point(20, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(135, 25);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre: ";
        // 
        // lblApellido
        // 
        lblApellido.Font = new Font("JetBrains Mono", 10F);
        lblApellido.Location = new Point(20, 55);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(135, 25);
        lblApellido.TabIndex = 1;
        lblApellido.Text = "Apellido: ";
        // 
        // lblDocumento
        // 
        lblDocumento.Font = new Font("JetBrains Mono", 10F);
        lblDocumento.Location = new Point(20, 90);
        lblDocumento.Name = "lblDocumento";
        lblDocumento.Size = new Size(135, 25);
        lblDocumento.TabIndex = 2;
        lblDocumento.Text = "Documento: ";
        // 
        // lblViajeroFreq
        // 
        lblViajeroFreq.Font = new Font("JetBrains Mono", 10F);
        lblViajeroFreq.Location = new Point(20, 125);
        lblViajeroFreq.Name = "lblViajeroFreq";
        lblViajeroFreq.Size = new Size(135, 25);
        lblViajeroFreq.TabIndex = 3;
        lblViajeroFreq.Text = "Viajero frecuente: ";
        // 
        // lblTipoTarifa
        // 
        lblTipoTarifa.Font = new Font("JetBrains Mono", 10F);
        lblTipoTarifa.Location = new Point(20, 160);
        lblTipoTarifa.Name = "lblTipoTarifa";
        lblTipoTarifa.Size = new Size(135, 25);
        lblTipoTarifa.TabIndex = 4;
        lblTipoTarifa.Text = "Tipo de tarifa (P|B|F|PE): ";
        // 
        // lblTipoVuelo
        // 
        lblTipoVuelo.Font = new Font("JetBrains Mono", 10F);
        lblTipoVuelo.Location = new Point(20, 195);
        lblTipoVuelo.Name = "lblTipoVuelo";
        lblTipoVuelo.Size = new Size(135, 25);
        lblTipoVuelo.TabIndex = 5;
        lblTipoVuelo.Text = "Tipo de vuelo (N|I): ";
        // 
        // txNombre
        // 
        txNombre.Location = new Point(165, 20);
        txNombre.Name = "txNombre";
        txNombre.Size = new Size(250, 23);
        txNombre.TabIndex = 6;
        // 
        // txApellido
        // 
        txApellido.Location = new Point(165, 55);
        txApellido.Name = "txApellido";
        txApellido.Size = new Size(250, 23);
        txApellido.TabIndex = 7;
        // 
        // txDocumento
        // 
        txDocumento.Location = new Point(165, 90);
        txDocumento.Name = "txDocumento";
        txDocumento.Size = new Size(250, 23);
        txDocumento.TabIndex = 8;
        // 
        // txViajeroFreq
        // 
        txViajeroFreq.Location = new Point(165, 125);
        txViajeroFreq.Name = "txViajeroFreq";
        txViajeroFreq.Size = new Size(250, 23);
        txViajeroFreq.TabIndex = 9;
        // 
        // txTipoTarifa
        // 
        txTipoTarifa.Location = new Point(165, 160);
        txTipoTarifa.MaxLength = 2;
        txTipoTarifa.Name = "txTipoTarifa";
        txTipoTarifa.Size = new Size(250, 23);
        txTipoTarifa.TabIndex = 10;
        // 
        // txTipoVuelo
        // 
        txTipoVuelo.Location = new Point(165, 195);
        txTipoVuelo.MaxLength = 1;
        txTipoVuelo.Name = "txTipoVuelo";
        txTipoVuelo.Size = new Size(250, 23);
        txTipoVuelo.TabIndex = 11;
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(165, 230);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(250, 35);
        btnRegistrar.TabIndex = 12;
        btnRegistrar.Text = "Registrar Check-In";
        btnRegistrar.Click += btnRegistrar_Click;
        // 
        // lblResultado
        // 
        lblResultado.BackColor = Color.WhiteSmoke;
        lblResultado.BorderStyle = BorderStyle.FixedSingle;
        lblResultado.Font = new Font("JetBrains Mono", 9F);
        lblResultado.Location = new Point(20, 284);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new Size(395, 160);
        lblResultado.TabIndex = 13;
        // 
        // Form1
        // 
        ClientSize = new Size(451, 453);
        Controls.Add(lblNombre);
        Controls.Add(lblApellido);
        Controls.Add(lblDocumento);
        Controls.Add(lblViajeroFreq);
        Controls.Add(lblTipoTarifa);
        Controls.Add(lblTipoVuelo);
        Controls.Add(txNombre);
        Controls.Add(txApellido);
        Controls.Add(txDocumento);
        Controls.Add(txViajeroFreq);
        Controls.Add(txTipoTarifa);
        Controls.Add(txTipoVuelo);
        Controls.Add(btnRegistrar);
        Controls.Add(lblResultado);
        Name = "Form1";
        Text = "Check-In Aerolínea";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    // Declaración de los controles
    private System.Windows.Forms.Label lblNombre, lblApellido, lblDocumento, lblViajeroFreq, lblTipoTarifa, lblTipoVuelo;
    private System.Windows.Forms.TextBox txNombre, txApellido, txDocumento, txViajeroFreq, txTipoTarifa, txTipoVuelo;
    private System.Windows.Forms.Button  btnRegistrar;
    private System.Windows.Forms.Label   lblResultado;
}