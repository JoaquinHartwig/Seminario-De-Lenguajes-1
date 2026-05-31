// ═══════════════════════════════════════════════════════════════════
//  WinFormsUI.cs — Librería de ayuda para crear interfaces Windows Forms
//  Uso: métodos estáticos de fábrica para crear y configurar controles
//  Compatibilidad: .NET 6 / .NET 8 / .NET 10 — Windows Forms
// ═══════════════════════════════════════════════════════════════════

using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUILibrary
{
    // ───────────────────────────────────────────────────────────────
    //  TEMA GLOBAL — colores, fuentes y tamaños por defecto
    // ───────────────────────────────────────────────────────────────
    public static class UITheme
    {
        // Fuentes
        public static Font FontNormal  = new Font("Segoe UI", 10F);
        public static Font FontBold    = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static Font FontSmall   = new Font("Segoe UI", 8.5F);
        public static Font FontLarge   = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static Font FontMono    = new Font("Courier New", 9F);

        // Colores de fondo
        public static Color BackForm       = Color.WhiteSmoke;
        public static Color BackInput      = Color.White;
        public static Color BackPanel      = Color.FromArgb(230, 235, 245);
        public static Color BackResult     = Color.FromArgb(240, 248, 255);

        // Colores de texto
        public static Color TextPrimary    = Color.FromArgb(30, 30, 30);
        public static Color TextSecondary  = Color.FromArgb(90, 90, 90);
        public static Color TextSuccess    = Color.FromArgb(0, 128, 0);
        public static Color TextError      = Color.FromArgb(180, 0, 0);
        public static Color TextWarning    = Color.FromArgb(180, 100, 0);

        // Colores de botones
        public static Color BtnPrimaryBack  = Color.FromArgb(0, 100, 200);
        public static Color BtnPrimaryFore  = Color.White;
        public static Color BtnDangerBack   = Color.FromArgb(200, 40, 40);
        public static Color BtnDangerFore   = Color.White;
        public static Color BtnNeutralBack  = SystemColors.ControlDark;
        public static Color BtnNeutralFore  = Color.White;

        // Tamaños estándar de controles
        public static int ControlHeight     = 34;
        public static int LabelHeight       = 28;
        public static int ButtonHeight      = 40;
        public static int DefaultPadding    = 12;
    }

    // ───────────────────────────────────────────────────────────────
    //  FÁBRICA DE CONTROLES — crea controles listos para usar
    // ───────────────────────────────────────────────────────────────
    public static class UIFactory
    {
        // ── Label ─────────────────────────────────────────────────

        /// <summary>Crea un Label con texto, posición y tamaño.</summary>
        public static Label CreateLabel(
            string text,
            int x, int y,
            int width = 180, int height = -1,
            bool bold = false,
            Color? foreColor = null)
        {
            var lbl = new Label
            {
                Text      = text,
                Location  = new Point(x, y),
                Size      = new Size(width, height == -1 ? UITheme.LabelHeight : height),
                Font      = bold ? UITheme.FontBold : UITheme.FontNormal,
                ForeColor = foreColor ?? UITheme.TextPrimary,
                AutoSize  = false
            };
            return lbl;
        }

        /// <summary>Crea un Label de título (grande y negrita).</summary>
        public static Label CreateTitle(string text, int x, int y, int width = 400)
        {
            return new Label
            {
                Text      = text,
                Location  = new Point(x, y),
                Size      = new Size(width, 36),
                Font      = UITheme.FontLarge,
                ForeColor = UITheme.TextPrimary,
                AutoSize  = false
            };
        }

        /// <summary>Crea un Label de resultado (fondo coloreado, fuente monoespaciada).</summary>
        public static Label CreateResultBox(
            int x, int y,
            int width = 420, int height = 160)
        {
            return new Label
            {
                Text        = string.Empty,
                Location    = new Point(x, y),
                Size        = new Size(width, height),
                Font        = UITheme.FontMono,
                BackColor   = UITheme.BackResult,
                ForeColor   = UITheme.TextPrimary,
                BorderStyle = BorderStyle.FixedSingle,
                AutoSize    = false,
                Padding     = new Padding(8)
            };
        }

        // ── TextBox ────────────────────────────────────────────────

        /// <summary>Crea un TextBox estándar.</summary>
        public static TextBox CreateTextBox(
            int x, int y,
            int width = 250,
            int maxLength = 100,
            string placeholder = "")
        {
            var tb = new TextBox
            {
                Location  = new Point(x, y),
                Size      = new Size(width, UITheme.ControlHeight),
                MaxLength = maxLength,
                Font      = UITheme.FontNormal,
                BackColor = UITheme.BackInput
            };
            // Simulación de placeholder vía eventos
            if (!string.IsNullOrEmpty(placeholder))
                UIHelper.SetPlaceholder(tb, placeholder);
            return tb;
        }

        /// <summary>Crea un TextBox de solo lectura (para mostrar datos).</summary>
        public static TextBox CreateReadOnly(int x, int y, int width = 250)
        {
            var tb = CreateTextBox(x, y, width);
            tb.ReadOnly  = true;
            tb.BackColor = UITheme.BackPanel;
            return tb;
        }

        // ── Button ────────────────────────────────────────────────

        /// <summary>Crea un botón primario (azul por defecto).</summary>
        public static Button CreateButton(
            string text,
            int x, int y,
            int width = 180, int height = -1,
            EventHandler? onClick = null,
            ButtonStyle style = ButtonStyle.Primary)
        {
            var btn = new Button
            {
                Text                  = text,
                Location              = new Point(x, y),
                Size                  = new Size(width, height == -1 ? UITheme.ButtonHeight : height),
                Font                  = UITheme.FontBold,
                FlatStyle             = FlatStyle.Flat,
                UseVisualStyleBackColor = false,
                Cursor                = Cursors.Hand
            };

            switch (style)
            {
                case ButtonStyle.Primary:
                    btn.BackColor = UITheme.BtnPrimaryBack;
                    btn.ForeColor = UITheme.BtnPrimaryFore;
                    btn.FlatAppearance.BorderColor = UITheme.BtnPrimaryBack;
                    break;
                case ButtonStyle.Danger:
                    btn.BackColor = UITheme.BtnDangerBack;
                    btn.ForeColor = UITheme.BtnDangerFore;
                    btn.FlatAppearance.BorderColor = UITheme.BtnDangerBack;
                    break;
                case ButtonStyle.Neutral:
                    btn.BackColor = UITheme.BtnNeutralBack;
                    btn.ForeColor = UITheme.BtnNeutralFore;
                    btn.FlatAppearance.BorderColor = UITheme.BtnNeutralBack;
                    break;
            }

            if (onClick != null)
                btn.Click += onClick;

            return btn;
        }

        // ── ComboBox ──────────────────────────────────────────────

        /// <summary>Crea un ComboBox con lista de ítems predefinida.</summary>
        public static ComboBox CreateComboBox(
            int x, int y,
            string[] items,
            int width = 250,
            int selectedIndex = 0)
        {
            var cb = new ComboBox
            {
                Location      = new Point(x, y),
                Size          = new Size(width, UITheme.ControlHeight),
                Font          = UITheme.FontNormal,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cb.Items.AddRange(items);
            if (cb.Items.Count > 0)
                cb.SelectedIndex = selectedIndex;
            return cb;
        }

        // ── NumericUpDown ─────────────────────────────────────────

        /// <summary>Crea un NumericUpDown con rango y valor inicial.</summary>
        public static NumericUpDown CreateNumeric(
            int x, int y,
            decimal min, decimal max, decimal value,
            int width = 150,
            int decimalPlaces = 0)
        {
            var nud = new NumericUpDown
            {
                Location      = new Point(x, y),
                Size          = new Size(width, UITheme.ControlHeight),
                Font          = UITheme.FontNormal,
                Minimum       = min,
                Maximum       = max,
                Value         = value,
                DecimalPlaces = decimalPlaces
            };
            return nud;
        }

        // ── CheckBox ──────────────────────────────────────────────

        /// <summary>Crea un CheckBox con texto y estado inicial.</summary>
        public static CheckBox CreateCheckBox(
            string text,
            int x, int y,
            bool isChecked = false,
            int width = 250)
        {
            return new CheckBox
            {
                Text     = text,
                Location = new Point(x, y),
                Size     = new Size(width, UITheme.ControlHeight),
                Font     = UITheme.FontNormal,
                Checked  = isChecked,
                Cursor   = Cursors.Hand
            };
        }

        // ── RadioButton ───────────────────────────────────────────

        /// <summary>Crea un RadioButton.</summary>
        public static RadioButton CreateRadioButton(
            string text,
            int x, int y,
            bool isChecked = false,
            int width = 200)
        {
            return new RadioButton
            {
                Text     = text,
                Location = new Point(x, y),
                Size     = new Size(width, UITheme.ControlHeight),
                Font     = UITheme.FontNormal,
                Checked  = isChecked,
                Cursor   = Cursors.Hand
            };
        }

        // ── Panel ─────────────────────────────────────────────────

        /// <summary>Crea un Panel con fondo coloreado, útil para agrupar controles.</summary>
        public static Panel CreatePanel(
            int x, int y,
            int width, int height,
            Color? backColor = null)
        {
            return new Panel
            {
                Location  = new Point(x, y),
                Size      = new Size(width, height),
                BackColor = backColor ?? UITheme.BackPanel,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        // ── GroupBox ──────────────────────────────────────────────

        /// <summary>Crea un GroupBox con título y posición.</summary>
        public static GroupBox CreateGroupBox(
            string title,
            int x, int y,
            int width, int height)
        {
            return new GroupBox
            {
                Text     = title,
                Location = new Point(x, y),
                Size     = new Size(width, height),
                Font     = UITheme.FontBold
            };
        }

        // ── Separador horizontal ──────────────────────────────────

        /// <summary>Crea una línea horizontal decorativa.</summary>
        public static Label CreateSeparator(int x, int y, int width)
        {
            return new Label
            {
                Location    = new Point(x, y),
                Size        = new Size(width, 2),
                BackColor   = Color.FromArgb(180, 180, 200),
                BorderStyle = BorderStyle.None,
                AutoSize    = false
            };
        }

        // ── Par Label + TextBox ───────────────────────────────────

        /// <summary>
        /// Crea un par Label + TextBox alineados horizontalmente.
        /// Retorna una tupla (label, textbox) para que puedas agregarlos al form.
        /// </summary>
        public static (Label label, TextBox input) CreateLabeledInput(
            string labelText,
            int x, int y,
            int labelWidth = 160, int inputWidth = 250,
            int maxLength = 100,
            string placeholder = "")
        {
            var lbl = CreateLabel(labelText, x, y + 4, labelWidth);
            var tb  = CreateTextBox(x + labelWidth + UITheme.DefaultPadding, y, inputWidth, maxLength, placeholder);
            return (lbl, tb);
        }

        /// <summary>
        /// Crea un par Label + ComboBox alineados horizontalmente.
        /// </summary>
        public static (Label label, ComboBox combo) CreateLabeledCombo(
            string labelText,
            int x, int y,
            string[] items,
            int labelWidth = 160, int comboWidth = 250)
        {
            var lbl = CreateLabel(labelText, x, y + 4, labelWidth);
            var cb  = CreateComboBox(x + labelWidth + UITheme.DefaultPadding, y, items, comboWidth);
            return (lbl, cb);
        }

        /// <summary>
        /// Crea un par Label + NumericUpDown alineados horizontalmente.
        /// </summary>
        public static (Label label, NumericUpDown numeric) CreateLabeledNumeric(
            string labelText,
            int x, int y,
            decimal min, decimal max, decimal value,
            int labelWidth = 160, int numericWidth = 150)
        {
            var lbl = CreateLabel(labelText, x, y + 4, labelWidth);
            var nud = CreateNumeric(x + labelWidth + UITheme.DefaultPadding, y, min, max, value, numericWidth);
            return (lbl, nud);
        }
    }

    // ───────────────────────────────────────────────────────────────
    //  LAYOUT — ayuda para calcular posiciones automáticamente
    // ───────────────────────────────────────────────────────────────
    public class UILayout
    {
        private int _currentY;
        private readonly int _startX;
        private readonly int _rowSpacing;

        /// <param name="startX">Margen izquierdo.</param>
        /// <param name="startY">Posición Y inicial.</param>
        /// <param name="rowSpacing">Espacio entre filas.</param>
        public UILayout(int startX = 20, int startY = 20, int rowSpacing = 45)
        {
            _startX     = startX;
            _currentY   = startY;
            _rowSpacing = rowSpacing;
        }

        /// <summary>Devuelve la Y actual y avanza a la siguiente fila.</summary>
        public int NextRow()
        {
            int y = _currentY;
            _currentY += _rowSpacing;
            return y;
        }

        /// <summary>Avanza N filas extras (para separar secciones).</summary>
        public void SkipRows(int count = 1) => _currentY += _rowSpacing * count;

        /// <summary>X de inicio configurada.</summary>
        public int X => _startX;

        /// <summary>Y actual sin avanzar.</summary>
        public int CurrentY => _currentY;
    }

    // ───────────────────────────────────────────────────────────────
    //  FORM BUILDER — configura el formulario base con buenas prácticas
    // ───────────────────────────────────────────────────────────────
    public static class UIFormBuilder
    {
        /// <summary>
        /// Aplica configuración base al formulario:
        /// AutoScaleMode, BackColor, Font y título.
        /// </summary>
        public static void Configure(
            Form form,
            string title,
            int width = 520, int height = 480,
            bool centerScreen = true)
        {
            form.Text                = title;
            form.ClientSize          = new Size(width, height);
            form.Font                = UITheme.FontNormal;
            form.BackColor           = UITheme.BackForm;
            form.AutoScaleDimensions = new SizeF(11F, 28F);
            form.AutoScaleMode       = AutoScaleMode.Font;
            form.FormBorderStyle     = FormBorderStyle.FixedSingle;
            form.MaximizeBox         = false;
            if (centerScreen)
                form.StartPosition   = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Agrega una lista de controles al formulario con SuspendLayout
        /// para evitar parpadeo.
        /// </summary>
        public static void AddControls(Form form, params Control[] controls)
        {
            form.SuspendLayout();
            form.Controls.AddRange(controls);
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        /// <summary>
        /// Agrega controles a un Panel o GroupBox con SuspendLayout.
        /// </summary>
        public static void AddControls(Control container, params Control[] controls)
        {
            container.SuspendLayout();
            container.Controls.AddRange(controls);
            ((ContainerControl?)container)?.ResumeLayout(false);
            container.PerformLayout();
        }
    }

    // ───────────────────────────────────────────────────────────────
    //  VALIDACIONES — helpers para validar campos del form
    // ───────────────────────────────────────────────────────────────
    public static class UIValidator
    {
        /// <summary>Verifica que el TextBox no esté vacío.</summary>
        public static bool IsRequired(TextBox tb, string fieldName, out string error)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                error = $"El campo '{fieldName}' es obligatorio.";
                tb.BackColor = Color.FromArgb(255, 220, 220);
                return false;
            }
            tb.BackColor = UITheme.BackInput;
            error = string.Empty;
            return true;
        }

        /// <summary>Verifica que el TextBox contenga solo dígitos.</summary>
        public static bool IsNumericOnly(TextBox tb, string fieldName, out string error)
        {
            if (!tb.Text.All(char.IsDigit))
            {
                error = $"'{fieldName}' debe contener solo números.";
                tb.BackColor = Color.FromArgb(255, 220, 220);
                return false;
            }
            tb.BackColor = UITheme.BackInput;
            error = string.Empty;
            return true;
        }

        /// <summary>Verifica que el valor esté dentro de una lista de opciones válidas.</summary>
        public static bool IsInOptions(TextBox tb, string fieldName, string[] validOptions, out string error)
        {
            if (!validOptions.Contains(tb.Text.ToUpper()))
            {
                error = $"'{fieldName}' debe ser uno de: {string.Join(", ", validOptions)}.";
                tb.BackColor = Color.FromArgb(255, 220, 220);
                return false;
            }
            tb.BackColor = UITheme.BackInput;
            error = string.Empty;
            return true;
        }

        /// <summary>Resetea el color de fondo de todos los TextBox pasados.</summary>
        public static void ResetColors(params TextBox[] fields)
        {
            foreach (var tb in fields)
                tb.BackColor = UITheme.BackInput;
        }
    }

    // ───────────────────────────────────────────────────────────────
    //  MENSAJES — wrappers sobre MessageBox con estilos predefinidos
    // ───────────────────────────────────────────────────────────────
    public static class UIMessage
    {
        public static void Success(string message, string title = "Éxito")
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Error(string message, string title = "Error")
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Warning(string message, string title = "Atención")
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool Confirm(string message, string title = "Confirmar")
            => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes;
    }

    // ───────────────────────────────────────────────────────────────
    //  HELPERS — utilidades varias
    // ───────────────────────────────────────────────────────────────
    public static class UIHelper
    {
        /// <summary>
        /// Simula un placeholder en un TextBox usando eventos GotFocus/LostFocus.
        /// </summary>
        public static void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text      = placeholder;
            tb.ForeColor = Color.Gray;

            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text      = string.Empty;
                    tb.ForeColor = UITheme.TextPrimary;
                }
            };
            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.Text      = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }

        /// <summary>
        /// Formatea el texto de un Label de resultado con el estilo estándar.
        /// Acepta un diccionario campo → valor.
        /// </summary>
        public static void FillResultLabel(Label lbl, Dictionary<string, string> data)
        {
            var lines = data.Select(kv => $"{kv.Key,-22}{kv.Value}");
            lbl.Text      = string.Join(Environment.NewLine, lines);
            lbl.ForeColor = UITheme.TextPrimary;
        }

        /// <summary>Muestra un error en el Label de resultado (texto rojo).</summary>
        public static void ShowError(Label lbl, string message)
        {
            lbl.Text      = "⚠  " + message;
            lbl.ForeColor = UITheme.TextError;
        }

        /// <summary>Limpia todos los TextBox pasados.</summary>
        public static void ClearFields(params TextBox[] fields)
        {
            foreach (var tb in fields)
                tb.Clear();
        }

        /// <summary>Pone el foco en el primer TextBox de la lista.</summary>
        public static void FocusFirst(params TextBox[] fields)
        {
            if (fields.Length > 0)
                fields[0].Focus();
        }
    }

    // ───────────────────────────────────────────────────────────────
    //  ENUMS
    // ───────────────────────────────────────────────────────────────
    public enum ButtonStyle
    {
        Primary,   // Azul
        Danger,    // Rojo
        Neutral    // Gris
    }
}
