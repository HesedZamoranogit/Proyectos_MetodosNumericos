using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    public partial class MetodoReglaFalsaControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public MetodoReglaFalsaControl()
        {
            InitializeComponent();

            // Activa el repintado para que el gradiente se dibuje correctamente
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            // Llama al evento Paint
            this.Paint += new PaintEventHandler(Form_Paint);


        }
        //FUNCION PARA EL GRADENTE
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            // Crear el gradiente
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,             // Área a pintar
                Color.FromArgb(46, 60, 84),       // Color inicial (arriba)
                Color.FromArgb(110, 79, 148),          // Color final (abajo)
                LinearGradientMode.Vertical      // Dirección del gradiente
            ))
            {
                // Rellena el fondo con el gradiente
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MetodoReglaFalsaControl_Load(object sender, EventArgs e)
        {



            // Fuente y colores para celdas
            dataGridResultados.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridResultados.DefaultCellStyle.BackColor = Color.FromArgb(46, 60, 84);
            dataGridResultados.DefaultCellStyle.ForeColor = Color.White;
            dataGridResultados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 79, 148);
            dataGridResultados.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente y colores para encabezado
            dataGridResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 35, 51);
            dataGridResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridResultados.EnableHeadersVisualStyles = false; // Permite aplicar el color al encabezado

            // Bordes y estilo
            dataGridResultados.BorderStyle = BorderStyle.None;
            dataGridResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridResultados.RowHeadersVisible = false;

            // Ajuste de filas
            dataGridResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            double xi = double.Parse(txtXi.Text);
            double xf = double.Parse(txtXf.Text);
            double eamax = double.Parse(txtEa.Text);
            string funcionTexto = txtFuncion.Text;


            if (xi == 0 & xf == 0 & eamax == 0 & funcionTexto == " ")
            {
                MessageBox.Show("Los valores no pueden ser nulos llenalos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Asegura multiplicación explícita: 4x -> 4*x
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(funcionTexto, @"(\d)(x)", "$1*$2");

            // Convierte potencias: x^3 -> Pow(x,3), 4*x^3 -> 4*Pow(x,3)
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"x\^(\d+)",
                "Pow(x,$1)"
            );
            // También para casos como 4x^3 -> 4*Pow(x,3)
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"(\d+)\*x\^(\d+)",
                "$1*Pow(x,$2)"
            );
            funcionTexto = System.Text.RegularExpressions.Regex.Replace(
                funcionTexto,
                @"(\d+)x\^(\d+)",
                "$1*Pow(x,$2)"
            );

            funcionTexto = Regex.Replace(funcionTexto, @"\bsqrt\b", "Sqrt", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\babs\b", "Abs", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\bcos\b", "Cos", RegexOptions.IgnoreCase);
            // Convertir texto a función dinámica
            Func<double, double> funcion = (x) =>
            {
                var expr = new NCalc.Expression(funcionTexto);
                expr.Parameters["x"] = x;
                var result = expr.Evaluate();
                if (result is double d)
                    return d;
                if (result is int i)
                    return Convert.ToDouble(i);
                throw new InvalidOperationException($"La expresión no se pudo evaluar como número. Resultado: {result} (Tipo: {result?.GetType().Name})");
            };

            var raices = new Implementaciones.RaicesFunciones();
            var resultado = raices.ReglaFalsa(funcion, xi, xf, eamax);

            // Mostrar en DataGridView
            dataGridResultados.DataSource = resultado;

            // Formatear columnas después de asignar el DataSource
            dataGridResultados.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xf"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Fxr"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Fxf"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["FxiFxr"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Ea"].DefaultCellStyle.Format = "F4";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridResultados.DataSource = null;
            txtEa.Clear();
            txtXf.Clear();
            txtXi.Clear();
        }
    }
}
