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
            dataGridResultados.Columns.Add("Xi", "Xi");
            dataGridResultados.Columns.Add("Xf", "Xf");
            dataGridResultados.Columns.Add("Xr", "Xr");
            dataGridResultados.Columns.Add("f(Xi)", "f(Xi)");
            dataGridResultados.Columns.Add("f(Xr)", "f(Xr)");
            dataGridResultados.Columns.Add("f(Xi)*f(Xr)", "f(Xi)*f(Xr)");
            dataGridResultados.Columns.Add("Ea", "Ea");

            dataGridResultados.Columns["Xi"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xf"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Xr"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["f(Xi)"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["f(Xr)"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["f(Xi)*f(Xr)"].DefaultCellStyle.Format = "F4";
            dataGridResultados.Columns["Ea"].DefaultCellStyle.Format = "F4";



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
    }
}
