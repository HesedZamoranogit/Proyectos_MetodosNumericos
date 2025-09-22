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
    public partial class MetodoSecanteControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public MetodoSecanteControl()
        {
            InitializeComponent();

            // Activa el repintado para que el gradiente se dibuje correctamente
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            // Llama al evento Paint
            this.Paint += new PaintEventHandler(Form_Paint);

            // --- Aquí agregas las funciones al ComboBox ---
            var funciones = new List<string>
            {
                "Selecciona una funcion",
                "sin(x) + cos(1 + x^2) - 1",
                "x^3 - x - 2",
                "x^2*Sqrt(Abs(Cos(x)))-5",
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
                case "sin(x) + cos(1 + x^2) - 1":
                    txtX1.Text = "2.5";
                    txtX2.Text = "3.0";
                    break;
                case "x^3 - x - 2":
                    txtX1.Text = "1.0";
                    txtX2.Text = "2.0";
                    break;
                case "x^2*Sqrt(Abs(Cos(x)))-5":
                    txtX1.Text = "2.0";
                    txtX2.Text = "3.0";
                    break;
                case "x^2 - 4":
                    txtX1.Text = "1.0";
                    txtX2.Text = "3.0";
                    break;
                case "exp(x) - 3*x":
                    txtX1.Text = "0.0";
                    txtX2.Text = "1.0";
                    break;
                case "Selecciona una funcion":
                    txtX1.Text = "";
                    txtX2.Text = "";
                    break;
                default:
                    txtX1.Text = "";
                    txtX2.Text = "";
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

        private void MetodoSecanteControl_Load(object sender, EventArgs e)
        {

            // Fuente y colores para celdas
            dgvSecante.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvSecante.DefaultCellStyle.BackColor = Color.FromArgb(46, 60, 84);
            dgvSecante.DefaultCellStyle.ForeColor = Color.White;
            dgvSecante.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 79, 148);
            dgvSecante.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente y colores para encabezado
            dgvSecante.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvSecante.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 35, 51);
            dgvSecante.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSecante.EnableHeadersVisualStyles = false; // Permite aplicar el color al encabezado

            // Bordes y estilo
            dgvSecante.BorderStyle = BorderStyle.None;
            dgvSecante.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSecante.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSecante.RowHeadersVisible = false;

            // Ajuste de filas
            dgvSecante.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSecante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }



        private void BtnResultado_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos antes de convertir
            if (string.IsNullOrWhiteSpace(txtX1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) ||
                string.IsNullOrWhiteSpace(txtEa.Text))
            {
                MessageBox.Show("Debes llenar todos los campos de entrada.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double x1 = double.Parse(txtX1.Text);
            double x2 = double.Parse(txtX2.Text);
            double eamax = double.Parse(txtEa.Text);

            string funcionTexto = CmbFuncion.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(funcionTexto))
            {
                MessageBox.Show("Selecciona una función válida.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            Func<double, double> funcion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(funcionTexto);

            var raices = new Proyecto_MetodosNumericos.Implementaciones.RaicesFunciones();
            var resultado = raices.Secante(funcion, x1,x2 , eamax);
            // Mostrar en DataGridView
            dgvSecante.DataSource = resultado;

            // Formatear columnas después de asignar el DataSource
            dgvSecante.Columns["X1"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["X2"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["Fx1"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["Fx2"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["Fxr"].DefaultCellStyle.Format = "F4";
            dgvSecante.Columns["Ea"].DefaultCellStyle.Format = "F4";


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtEa.Clear();
            txtX1.Clear();
            dgvSecante.DataSource = null;
        }
    }
}
