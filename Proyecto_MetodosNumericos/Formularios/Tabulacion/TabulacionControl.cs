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
using Proyecto_MetodosNumericos.Utils;

namespace Proyecto_MetodosNumericos.Formularios.Tabulacion
{
    public partial class TabulacionControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;

        private Func<double, double> FuncionF = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
        private Func<double, double> FuncionG = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;


        public TabulacionControl()
        {
            InitializeComponent();
           }

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


        private void TabulacionControl_Load(object sender, EventArgs e)
        {
            dataGridResultados.Size = new Size(808, 249); // Ajusta el tamaño según lo que necesites
            dataGridResultados.Location = new Point(82, 334); // Ajusta la ubicación según lo que necesites

            dataGridResultados.Columns.Add("X", "X");
            dataGridResultados.Columns.Add("Y", "Y");

            dataGridResultados.Columns["X"].DefaultCellStyle.Format = "F2";
            dataGridResultados.Columns["Y"].DefaultCellStyle.Format = "F4";


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







            Font = new Font("HP Simplified Jpan", 10, FontStyle.Regular);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            // Dispara el evento
            RegresarClicked?.Invoke(this, EventArgs.Empty);

        }

        private void BtnFuncionF_Click(object sender, EventArgs e)
        {
            double maxY, minY;
            var resultados = Implementaciones.Tabula.Tabular(FuncionF, 0.0, 1.0, 0.1, out maxY, out minY);
            MostrarResultados(resultados, maxY, minY);
        }

        private void BtnFuncionG_Click(object sender, EventArgs e)
        {
            double maxY, minY;
            var resultados = Implementaciones.Tabula.Tabular(FuncionG, -3.0, 2.0, 0.1, out maxY, out minY);
            MostrarResultados(resultados, maxY, minY);
        }

        private void MostrarResultados(List<(double x, double y)> resultados, double maxY, double minY)
        {
            dataGridResultados.Rows.Clear();
            foreach (var r in resultados)
            {
                dataGridResultados.Rows.Add(r.x, r.y);
            }

            LblMax.Text = $"Valor Maximo: {maxY}";
            LblMin.Text = $"Valor Minimo: {minY}";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridResultados.Rows.Clear();
            LblMax.Text = "Valor Maximo: ";
            LblMin.Text = "Valor Minimo: ";
        }
    }
}
