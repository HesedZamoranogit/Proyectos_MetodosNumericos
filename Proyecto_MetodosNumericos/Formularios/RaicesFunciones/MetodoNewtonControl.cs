using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    public partial class MetodoNewtonControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public MetodoNewtonControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            this.Paint += new PaintEventHandler(Form_Paint);

            var funciones = new List<string>
            {
                "Selecciona una funcion",
                "0.95*x^3 - 5.9*x^2 + 10.9*x - 6",
                "4x^3 - 6x^2 + 7x - 2.3",
                "cos(x) - x",
                "x^2 - 4",
                "exp(x) - 3*x"
            };
            CmbFuncion.DataSource = funciones;

            CmbFuncion.SelectedIndexChanged += CmbFuncion_SelectedIndexChanged;
        }

        private void CmbFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbFuncion.SelectedItem?.ToString())
            {
                case "0.95*x^3 - 5.9*x^2 + 10.9*x - 6":
                    txtXi.Text = "3.0";
                    break;
                case "4x^3 - 6x^2 + 7x - 2.3":
                    txtXi.Text = "0.0";
                    break;
                case "cos(x) - x":
                    txtXi.Text = "0.5";
                    break;
                case "x^2 - 4":
                    txtXi.Text = "2.5";
                    break;
                case "exp(x) - 3*x":
                    txtXi.Text = "0.5";
                    break;
                case "Selecciona una función":
                default:
                    txtXi.Text = "";
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

        private void MetodoNewtonControl_Load(object sender, EventArgs e)
        {
            // Fuente y colores para celdas
            dgvNewton.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvNewton.DefaultCellStyle.BackColor = Color.FromArgb(46, 60, 84);
            dgvNewton.DefaultCellStyle.ForeColor = Color.White;
            dgvNewton.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 79, 148);
            dgvNewton.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente y colores para encabezado
            dgvNewton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvNewton.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 35, 51);
            dgvNewton.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNewton.EnableHeadersVisualStyles = false; // Permite aplicar el color al encabezado

            // Bordes y estilo
            dgvNewton.BorderStyle = BorderStyle.None;
            dgvNewton.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNewton.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNewton.RowHeadersVisible = false;

            // Ajuste de filas
            dgvNewton.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNewton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos antes de convertir
            if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                string.IsNullOrWhiteSpace(txtEa.Text))
            {
                MessageBox.Show("Debes llenar todos los campos de entrada.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            double xi = double.Parse(txtXi.Text);
            double emax = double.Parse(txtEa.Text);

            string funcionTexto = CmbFuncion.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(funcionTexto))
            {
                MessageBox.Show("Selecciona una función válida.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Func<double, double> funcion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(funcionTexto);

            var raices = new Proyecto_MetodosNumericos.Implementaciones.RaicesFunciones();
            var resultado = raices.NewtonRaphson(funcion, xi, emax);

            // Mostrar en DataGridView
            dgvNewton.DataSource = resultado;

            // Formatear columnas después de asignar el DataSource
            dgvNewton.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dgvNewton.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dgvNewton.Columns["Fdxi"].DefaultCellStyle.Format = "F4";
            dgvNewton.Columns["Ea"].DefaultCellStyle.Format = "F4";



        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtEa.Clear();
            txtXi.Clear();
            dgvNewton.DataSource = null;
        }
    }
}
