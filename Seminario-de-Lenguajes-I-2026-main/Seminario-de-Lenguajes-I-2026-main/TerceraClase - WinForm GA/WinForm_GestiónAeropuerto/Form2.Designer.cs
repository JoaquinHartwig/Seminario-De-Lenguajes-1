namespace WinForm_GestiónAeropuerto
{
    partial class Form2
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
            panel1 = new Panel();
            btnRegistrar = new Button();
            lblResultado = new Label();
            lblTipoVuelo = new Label();
            comBoxVuelo = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comBoxVuelo);
            panel1.Controls.Add(lblTipoVuelo);
            panel1.Location = new Point(14, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 215);
            panel1.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Window;
            btnRegistrar.Location = new Point(14, 244);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(409, 35);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar Check-In";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.WhiteSmoke;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Font = new Font("JetBrains Mono", 10F);
            lblResultado.Location = new Point(14, 288);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(409, 160);
            lblResultado.TabIndex = 18;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 469);
            Controls.Add(panel1);
            Controls.Add(btnRegistrar);
            Controls.Add(lblResultado);
            Name = "Form2";
            Text = "Check-In Aerolíneas/Equipaje";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
        private Label lblResultado;
        private ComboBox comBoxVuelo;
        private Label lblTipoVuelo;
    }
}