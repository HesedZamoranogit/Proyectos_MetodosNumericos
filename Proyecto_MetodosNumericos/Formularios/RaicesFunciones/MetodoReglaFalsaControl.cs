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

            var funciones = new List<string>
            {
                "x^3 - x - 2",                // Nueva función agregada
                "x^2*Sqrt(Abs(Cos(x)))-5",               // Nueva función agregada
                "cos(x) - x",                            // Mantienes esta
                "exp(x) - 3*x"                           // Mantienes esta
            };
            CmbFuncion.DataSource = funciones;

            CmbFuncion.SelectedIndexChanged += CmbFuncion_SelectedIndexChanged;
        }



        private void CmbFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbFuncion.SelectedItem?.ToString())
            {
                case "x^3 - x - 2":
                    txtXi.Text = "1";
                    txtXf.Text = "2";
                    break;
                case "x^2*Sqrt(Abs(Cos(x)))-5":
                    txtXi.Text = "2";
                    txtXf.Text = "3";
                    break;
                case "cos(x) - x":
                    txtXi.Text = "0";
                    txtXf.Text = "1";
                    break;
                case "exp(x) - 3*x":
                    txtXi.Text = "0";
                    txtXf.Text = "1";
                    break;
                default:
                    txtXi.Text = "";
                    txtXf.Text = "";
                    break;
            }
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
            if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                string.IsNullOrWhiteSpace(txtXf.Text) ||
                string.IsNullOrWhiteSpace(txtEa.Text))
            {
                MessageBox.Show("Debes llenar todos los campos de entrada.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double xi = double.Parse(txtXi.Text);
            double xf = double.Parse(txtXf.Text);
            double eamax = double.Parse(txtEa.Text);
            //string funcionTexto = txtFuncion.Text;

            string funcionTexto = CmbFuncion.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(funcionTexto))
            {
                MessageBox.Show("Selecciona una función válida.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// Validar campos vacíos antes de convertir
            
            Func<double, double> funcion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(funcionTexto);

            var raices = new Proyecto_MetodosNumericos.Implementaciones.RaicesFunciones();
            var resultado = raices.ReglaFalsa(funcion, xi, xf, eamax);

            try
            {
                resultado = raices.ReglaFalsa(funcion, xi, xf, eamax);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de intervalo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridResultados.DataSource = null; // Limpia la tabla
                return;
            }

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
