using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using Proyecto_MetodosNumericos.Implementaciones;

namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    public partial class MetodoBiseccionControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public MetodoBiseccionControl()
        {
            InitializeComponent();

            // Activa el repintado para que el gradiente se dibuje correctamente
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            // Llama al evento Paint
            this.Paint += new PaintEventHandler(Form_Paint);

            var funciones = new List<string>
            {
                    "4x^3 - 6x^2 + 7x - 2.3",                // Nueva función agregada
                    "x^3 - x - 2",               // Nueva función agregada
                    "cos(x) - x",                            // Mantienes esta
                    "exp(x) - 3*x"
            };
            CmbFuncion.DataSource = funciones;

            CmbFuncion.SelectedIndexChanged += CmbFuncion_SelectedIndexChanged;
        }



        private void CmbFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbFuncion.SelectedItem?.ToString())
            {
                case "4x^3 - 6x^2 + 7x - 2.3":
                    txtXi.Text = "0";
                    txtXf.Text = "1";
                    break;
                case "x^3 - x - 2":
                    txtXi.Text = "1";
                    txtXf.Text = "2";
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

        private void MetodoBiseccionControl_Load(object sender, EventArgs e)
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
        // Replace this line:
        // RaicesFunciones raicesFunciones = new RaicesFunciones();

        // With the correct type from the namespace, for example:
        Implementaciones.RaicesFunciones raicesFunciones = new Implementaciones.RaicesFunciones();
        private void BtnResultados_Click(object sender, EventArgs e)
        {
 // Validar campos vacíos antes de convertir
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

            string funcionTexto = CmbFuncion.SelectedItem.ToString() ?? " ";

           

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
            

            Func<double, double> funcion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(funcionTexto);


            var raices = new Implementaciones.RaicesFunciones();
            var resultado = raices.Biseccion(funcion, xi, xf, eamax);

            // Mostrar en DataGridView
            dataGridResultados.DataSource = resultado;

            // Mostrar solo 4 digitos
            dataGridResultados.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xf"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Fxi"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Fxr"].DefaultCellStyle.Format = "F4";
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

        private void dataGridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
