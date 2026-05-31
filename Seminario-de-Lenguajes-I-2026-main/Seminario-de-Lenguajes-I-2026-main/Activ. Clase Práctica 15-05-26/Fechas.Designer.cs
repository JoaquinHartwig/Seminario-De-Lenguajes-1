namespace TP_02___SL_I___Tipos_de_Datos__Variables__IDE
{
    partial class Fechas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DtpFecha1 = new DateTimePicker();
            LblIngresoFecha1 = new Label();
            LblIngresoFecha2 = new Label();
            DtpFecha2 = new DateTimePicker();
            BtnPrimeraFecha = new Button();
            BtnSegundaFecha = new Button();
            LblTitulo = new Label();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // DtpFecha1
            // 
            DtpFecha1.Font = new Font("Segoe UI", 12F);
            DtpFecha1.Location = new Point(233, 83);
            DtpFecha1.Name = "DtpFecha1";
            DtpFecha1.Size = new Size(293, 29);
            DtpFecha1.TabIndex = 0;
            // 
            // LblIngresoFecha1
            // 
            LblIngresoFecha1.Font = new Font("Segoe UI", 12F);
            LblIngresoFecha1.Location = new Point(41, 80);
            LblIngresoFecha1.Name = "LblIngresoFecha1";
            LblIngresoFecha1.Size = new Size(186, 32);
            LblIngresoFecha1.TabIndex = 1;
            LblIngresoFecha1.Text = "Ingresá la primera fecha:";
            LblIngresoFecha1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblIngresoFecha2
            // 
            LblIngresoFecha2.Font = new Font("Segoe UI", 12F);
            LblIngresoFecha2.Location = new Point(41, 127);
            LblIngresoFecha2.Name = "LblIngresoFecha2";
            LblIngresoFecha2.Size = new Size(186, 32);
            LblIngresoFecha2.TabIndex = 3;
            LblIngresoFecha2.Text = "Ingresá la segunda fecha:";
            LblIngresoFecha2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpFecha2
            // 
            DtpFecha2.Font = new Font("Segoe UI", 12F);
            DtpFecha2.Location = new Point(233, 130);
            DtpFecha2.Name = "DtpFecha2";
            DtpFecha2.Size = new Size(293, 29);
            DtpFecha2.TabIndex = 2;
            // 
            // BtnPrimeraFecha
            // 
            BtnPrimeraFecha.Font = new Font("Segoe UI", 12F);
            BtnPrimeraFecha.Location = new Point(535, 83);
            BtnPrimeraFecha.Name = "BtnPrimeraFecha";
            BtnPrimeraFecha.Size = new Size(81, 29);
            BtnPrimeraFecha.TabIndex = 4;
            BtnPrimeraFecha.Text = "Cargar";
            BtnPrimeraFecha.UseVisualStyleBackColor = true;
            BtnPrimeraFecha.Click += BtnPrimeraFecha_Click;
            // 
            // BtnSegundaFecha
            // 
            BtnSegundaFecha.Font = new Font("Segoe UI", 12F);
            BtnSegundaFecha.Location = new Point(535, 132);
            BtnSegundaFecha.Name = "BtnSegundaFecha";
            BtnSegundaFecha.Size = new Size(81, 29);
            BtnSegundaFecha.TabIndex = 5;
            BtnSegundaFecha.Text = "Cargar";
            BtnSegundaFecha.UseVisualStyleBackColor = true;
            BtnSegundaFecha.Click += BtnSegundaFecha_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 17F);
            LblTitulo.ForeColor = Color.DarkSlateBlue;
            LblTitulo.Location = new Point(37, 33);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(459, 31);
            LblTitulo.TabIndex = 6;
            LblTitulo.Text = "Cálculo y Comparación de Mayoría de Edad";
            // 
            // LblResultado
            // 
            LblResultado.BackColor = SystemColors.ControlLight;
            LblResultado.BorderStyle = BorderStyle.FixedSingle;
            LblResultado.Font = new Font("Segoe UI", 12F);
            LblResultado.Location = new Point(41, 187);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(575, 200);
            LblResultado.TabIndex = 7;
            // 
            // Fechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 437);
            Controls.Add(LblResultado);
            Controls.Add(LblTitulo);
            Controls.Add(BtnSegundaFecha);
            Controls.Add(BtnPrimeraFecha);
            Controls.Add(LblIngresoFecha2);
            Controls.Add(DtpFecha2);
            Controls.Add(LblIngresoFecha1);
            Controls.Add(DtpFecha1);
            Name = "Fechas";
            Text = "Cálculo y Comparación de Mayoría de Edad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpFecha1;
        private Label LblIngresoFecha1;
        private Label LblIngresoFecha2;
        private DateTimePicker DtpFecha2;
        private Button BtnPrimeraFecha;
        private Button BtnSegundaFecha;
        private Label LblTitulo;
        private Label LblResultado;
    }
}
