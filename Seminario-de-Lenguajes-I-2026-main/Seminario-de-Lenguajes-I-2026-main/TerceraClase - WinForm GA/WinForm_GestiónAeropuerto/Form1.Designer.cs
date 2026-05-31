namespace WinForm_GestiónAeropuerto
{ 

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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtViajeroFreq = new TextBox();
            btnRegistrar = new Button();
            lblResultado = new Label();
            comBoxTarifa = new ComboBox();
            comBoxVuelo = new ComboBox();
            panel1 = new Panel();
            mskTxtDocumento = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("JetBrains Mono", 10F);
            lblNombre.Location = new Point(6, 8);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(135, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("JetBrains Mono", 10F);
            lblApellido.Location = new Point(6, 43);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(135, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido: ";
            // 
            // lblDocumento
            // 
            lblDocumento.Font = new Font("JetBrains Mono", 10F);
            lblDocumento.Location = new Point(6, 78);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(135, 25);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento: ";
            // 
            // lblViajeroFreq
            // 
            lblViajeroFreq.Font = new Font("JetBrains Mono", 10F);
            lblViajeroFreq.Location = new Point(6, 113);
            lblViajeroFreq.Name = "lblViajeroFreq";
            lblViajeroFreq.Size = new Size(135, 25);
            lblViajeroFreq.TabIndex = 3;
            lblViajeroFreq.Text = "Viajero frecuente: ";
            // 
            // lblTipoTarifa
            // 
            lblTipoTarifa.Font = new Font("JetBrains Mono", 10F);
            lblTipoTarifa.Location = new Point(6, 149);
            lblTipoTarifa.Name = "lblTipoTarifa";
            lblTipoTarifa.Size = new Size(135, 25);
            lblTipoTarifa.TabIndex = 4;
            lblTipoTarifa.Text = "Tipo de tarifa: ";
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.Font = new Font("JetBrains Mono", 10F);
            lblTipoVuelo.Location = new Point(6, 185);
            lblTipoVuelo.Name = "lblTipoVuelo";
            lblTipoVuelo.Size = new Size(135, 25);
            lblTipoVuelo.TabIndex = 5;
            lblTipoVuelo.Text = "Tipo de vuelo: ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("JetBrains Mono", 9F);
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(151, 8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 22);
            txtNombre.TabIndex = 6;
            txtNombre.Text = "Juan";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("JetBrains Mono", 9F);
            txtApellido.ForeColor = SystemColors.WindowText;
            txtApellido.Location = new Point(151, 43);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 22);
            txtApellido.TabIndex = 7;
            txtApellido.Text = "Pérez";
            // 
            // txtViajeroFreq
            // 
            txtViajeroFreq.Font = new Font("JetBrains Mono", 9F);
            txtViajeroFreq.ForeColor = SystemColors.WindowText;
            txtViajeroFreq.Location = new Point(151, 113);
            txtViajeroFreq.Name = "txtViajeroFreq";
            txtViajeroFreq.Size = new Size(250, 22);
            txtViajeroFreq.TabIndex = 9;
            txtViajeroFreq.Text = "IE-1235";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Window;
            btnRegistrar.Location = new Point(14, 236);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(409, 35);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar Check-In";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.WhiteSmoke;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Font = new Font("JetBrains Mono", 10F);
            lblResultado.Location = new Point(14, 280);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(409, 160);
            lblResultado.TabIndex = 13;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comBoxTarifa
            // 
            comBoxTarifa.Font = new Font("JetBrains Mono", 9F);
            comBoxTarifa.ForeColor = SystemColors.WindowText;
            comBoxTarifa.FormattingEnabled = true;
            comBoxTarifa.Items.AddRange(new object[] { "Business", "First Class", "Premium Economy", "Premium" });
            comBoxTarifa.Location = new Point(151, 149);
            comBoxTarifa.Name = "comBoxTarifa";
            comBoxTarifa.Size = new Size(250, 23);
            comBoxTarifa.TabIndex = 14;
            comBoxTarifa.Text = "Premium";
            // 
            // comBoxVuelo
            // 
            comBoxVuelo.Font = new Font("JetBrains Mono", 9F);
            comBoxVuelo.ForeColor = SystemColors.WindowText;
            comBoxVuelo.FormattingEnabled = true;
            comBoxVuelo.Items.AddRange(new object[] { "Nacional", "Internacional" });
            comBoxVuelo.Location = new Point(151, 185);
            comBoxVuelo.Name = "comBoxVuelo";
            comBoxVuelo.Size = new Size(250, 23);
            comBoxVuelo.TabIndex = 15;
            comBoxVuelo.Tag = "";
            comBoxVuelo.Text = "Nacional";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(mskTxtDocumento);
            panel1.Controls.Add(comBoxVuelo);
            panel1.Controls.Add(comBoxTarifa);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblDocumento);
            panel1.Controls.Add(lblViajeroFreq);
            panel1.Controls.Add(lblTipoTarifa);
            panel1.Controls.Add(lblTipoVuelo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtViajeroFreq);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 215);
            panel1.TabIndex = 16;
            // 
            // mskTxtDocumento
            // 
            mskTxtDocumento.Location = new Point(151, 80);
            mskTxtDocumento.Mask = "##.###.###";
            mskTxtDocumento.Name = "mskTxtDocumento";
            mskTxtDocumento.Size = new Size(250, 23);
            mskTxtDocumento.TabIndex = 17;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 469);
            Controls.Add(panel1);
            Controls.Add(btnRegistrar);
            Controls.Add(lblResultado);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Check-In Aerolínea/Datos del usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Declaración de los controles
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblViajeroFreq;
        private Label lblTipoTarifa;
        private Label lblTipoVuelo;
        private Button btnRegistrar;
        private Label lblResultado;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtViajeroFreq;
        private MaskedTextBox mskTxtDocumento;
        private ComboBox comBoxTarifa;
        private ComboBox comBoxVuelo;
        private Panel panel1;
    }
    public class ResultDialog : Form
    {
        private TextBox txtResultado;
        private Button btnOk;

        public ResultDialog(string texto)
        {
            Text = "Resultado del Check-In";
            ClientSize = new Size(460, 320);
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponents(texto);
        }

        private void InitializeComponents(string texto)
        {
            txtResultado = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Top,
                Height = ClientSize.Height - 60,
                Text = texto,
                Font = new Font("JetBrains Mono", 9F)
            };

            btnOk = new Button
            {
                Text = "Cerrar",
                Dock = DockStyle.Bottom,
                Height = 36
            };
            btnOk.Click += (s, e) => Close();

            Controls.Add(txtResultado);
            Controls.Add(btnOk);
        }
    }
}
