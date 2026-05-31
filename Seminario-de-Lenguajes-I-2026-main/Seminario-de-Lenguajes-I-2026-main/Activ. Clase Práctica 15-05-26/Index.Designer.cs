namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    partial class Index
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
            LblProgramPais = new Label();
            BtnProgramEdad = new Button();
            LblTitulo = new Label();
            LblProgramEdad = new Label();
            BtnProgramPais = new Button();
            SuspendLayout();
            // 
            // LblProgramPais
            // 
            LblProgramPais.Font = new Font("Segoe UI", 12F);
            LblProgramPais.Location = new Point(59, 111);
            LblProgramPais.Name = "LblProgramPais";
            LblProgramPais.Size = new Size(186, 48);
            LblProgramPais.TabIndex = 21;
            LblProgramPais.Text = "Verificación Países de Latinoamérica";
            LblProgramPais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnProgramEdad
            // 
            BtnProgramEdad.Font = new Font("Segoe UI", 12F);
            BtnProgramEdad.Location = new Point(419, 186);
            BtnProgramEdad.Name = "BtnProgramEdad";
            BtnProgramEdad.Size = new Size(186, 65);
            BtnProgramEdad.TabIndex = 20;
            BtnProgramEdad.Text = "Ir";
            BtnProgramEdad.UseVisualStyleBackColor = true;
            BtnProgramEdad.Click += BtnProgramEdad_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Segoe UI", 17F);
            LblTitulo.ForeColor = Color.DarkSlateBlue;
            LblTitulo.Location = new Point(59, 49);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(259, 31);
            LblTitulo.TabIndex = 19;
            LblTitulo.Text = "Selección de Programas";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblProgramEdad
            // 
            LblProgramEdad.Font = new Font("Segoe UI", 12F);
            LblProgramEdad.Location = new Point(419, 111);
            LblProgramEdad.Name = "LblProgramEdad";
            LblProgramEdad.Size = new Size(186, 48);
            LblProgramEdad.TabIndex = 22;
            LblProgramEdad.Text = "Cálculo y Comparación de Mayoría de Edad";
            LblProgramEdad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnProgramPais
            // 
            BtnProgramPais.Font = new Font("Segoe UI", 12F);
            BtnProgramPais.Location = new Point(59, 186);
            BtnProgramPais.Name = "BtnProgramPais";
            BtnProgramPais.Size = new Size(173, 65);
            BtnProgramPais.TabIndex = 23;
            BtnProgramPais.Text = "Ir";
            BtnProgramPais.UseVisualStyleBackColor = true;
            BtnProgramPais.Click += BtnProgramPais_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 304);
            Controls.Add(BtnProgramPais);
            Controls.Add(LblProgramEdad);
            Controls.Add(LblProgramPais);
            Controls.Add(BtnProgramEdad);
            Controls.Add(LblTitulo);
            Name = "Index";
            Text = "Índice de programas";
            ResumeLayout(false);
        }

        #endregion

        private Label LblProgramPais;
        private Button BtnProgramEdad;
        private Label LblTitulo;
        private Label LblProgramEdad;
        private Button BtnProgramPais;
    }
}