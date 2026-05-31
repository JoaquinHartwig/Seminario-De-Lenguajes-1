namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    partial class Paises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblResultado = new Label();
            LblTitulo = new Label();
            ComBoxPais = new ComboBox();
            BtnPais = new Button();
            LblIngresoPais = new Label();
            SuspendLayout();
            // 
            // LblResultado
            // 
            LblResultado.BackColor = SystemColors.ControlLight;
            LblResultado.BorderStyle = BorderStyle.FixedSingle;
            LblResultado.Font = new Font("Segoe UI", 12F);
            LblResultado.Location = new Point(46, 238);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(575, 134);
            LblResultado.TabIndex = 15;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 17F);
            LblTitulo.ForeColor = Color.DarkSlateBlue;
            LblTitulo.Location = new Point(42, 41);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(382, 31);
            LblTitulo.TabIndex = 14;
            LblTitulo.Text = "Verificación Países de Latinoamérica";
            // 
            // ComBoxPais
            // 
            ComBoxPais.Font = new Font("Segoe UI", 12F);
            ComBoxPais.FormattingEnabled = true;
            ComBoxPais.Items.AddRange(new object[] { "Brasil", "Uruguay", "Argentina", "México", "Noruega", "Chile" });
            ComBoxPais.Location = new Point(238, 89);
            ComBoxPais.Name = "ComBoxPais";
            ComBoxPais.Size = new Size(293, 29);
            ComBoxPais.TabIndex = 16;
            ComBoxPais.Text = "Países";
            // 
            // BtnPais
            // 
            BtnPais.Font = new Font("Segoe UI", 12F);
            BtnPais.Location = new Point(540, 89);
            BtnPais.Name = "BtnPais";
            BtnPais.Size = new Size(81, 30);
            BtnPais.TabIndex = 17;
            BtnPais.Text = "Cargar";
            BtnPais.UseVisualStyleBackColor = true;
            BtnPais.Click += BtnPais_Click;
            // 
            // LblIngresoPais
            // 
            LblIngresoPais.Font = new Font("Segoe UI", 12F);
            LblIngresoPais.Location = new Point(46, 87);
            LblIngresoPais.Name = "LblIngresoPais";
            LblIngresoPais.Size = new Size(186, 33);
            LblIngresoPais.TabIndex = 18;
            LblIngresoPais.Text = "Ingresá la segunda fecha:";
            LblIngresoPais.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Paises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 437);
            Controls.Add(LblIngresoPais);
            Controls.Add(BtnPais);
            Controls.Add(ComBoxPais);
            Controls.Add(LblResultado);
            Controls.Add(LblTitulo);
            Name = "Paises";
            Text = "Comprobación Países";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblResultado;
        private Label LblTitulo;
        private ComboBox ComBoxPais;
        private Button BtnPais;
        private Label LblIngresoPais;
    }
}