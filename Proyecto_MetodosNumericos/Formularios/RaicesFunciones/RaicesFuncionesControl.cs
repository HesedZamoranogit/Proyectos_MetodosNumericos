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
using Proyecto_MetodosNumericos.Formularios.Errores;

namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    public partial class RaicesFuncionesControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public RaicesFuncionesControl()
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

        private void MetodoBiseccionControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }
        private void MetodoReglaFalsaControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }
        private void MetodoSecanteControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }
        private void MetodoNewtonControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }


        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            MetodoBiseccionControl Biseccion = new MetodoBiseccionControl();
            Biseccion.Dock = DockStyle.Fill;

            // Suscribe al evento RegresarClicked
            Biseccion.RegresarClicked += MetodoBiseccionControl_RegresarClicked;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Biseccion);
        }

        private void BtnRFalsa_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            MetodoReglaFalsaControl RFalsa = new MetodoReglaFalsaControl();
            RFalsa.Dock = DockStyle.Fill;
            // Suscribe al evento RegresarClicked
            RFalsa.RegresarClicked += MetodoReglaFalsaControl_RegresarClicked;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(RFalsa);
        }

        private void BtnNewton_Click(object sender, EventArgs e)
        {

            panelContenedor.Visible = true;
            MetodoNewtonControl Newton = new MetodoNewtonControl();
            Newton.Dock = DockStyle.Fill;
            // Suscribe al evento RegresarClicked
            Newton.RegresarClicked += MetodoNewtonControl_RegresarClicked;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Newton);
        }

        private void BtnSecante_Click(object sender, EventArgs e)
        {

            panelContenedor.Visible = true;
            MetodoSecanteControl Secante = new MetodoSecanteControl();
            Secante.Dock = DockStyle.Fill;
            // Suscribe al evento RegresarClicked
            Secante.RegresarClicked += MetodoSecanteControl_RegresarClicked;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Secante);
        }

        private void RaicesFuncionesControl_Load(object sender, EventArgs e)
        {



            // Fuente y colores para celdas
            dgvComparacion.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvComparacion.DefaultCellStyle.BackColor = Color.FromArgb(46, 60, 84);
            dgvComparacion.DefaultCellStyle.ForeColor = Color.White;
            dgvComparacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 79, 148);
            dgvComparacion.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente y colores para encabezado
            dgvComparacion.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvComparacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 35, 51);
            dgvComparacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvComparacion.EnableHeadersVisualStyles = false; // Permite aplicar el color al encabezado

            // Bordes y estilo
            dgvComparacion.BorderStyle = BorderStyle.None;
            dgvComparacion.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComparacion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvComparacion.RowHeadersVisible = false;

            // Ajuste de filas
            dgvComparacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvComparacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void BtnComparacion_Click(object sender, EventArgs e)
        {

            double Bxi = 0; 
            double Bxf = 1; 
            string BfuncionTexto = "4x^3 - 6x^2 + 7x - 2.3"; 

            double Rxi = 2; 
            double Rxf = 3; 
            string RfunctionTexto = "x^2*Sqrt(Abs(Cos(x)))-5";
            double Nxi = 0;

            double x1 = 2; 
            double x2 = 3; 
            double eamax = 0.1;
           

          Func<double, double> Bfuncion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(BfuncionTexto);
            Func<double, double> Rfuncion = Proyecto_MetodosNumericos.Utils.FuncionHelper.CrearFuncion(RfunctionTexto);
           

            var raices = new Proyecto_MetodosNumericos.Implementaciones.RaicesFunciones();

            // Run all methods
            var biseccion = raices.Biseccion(Bfuncion, Bxi, Bxf, eamax);
            var reglaFalsa = raices.ReglaFalsa(Rfuncion, Rxi, Rxf, eamax);
            var newton = raices.NewtonRaphson(Bfuncion, Nxi, eamax);
            var secante = raices.Secante(Rfuncion, x1, x2, eamax);

            // Prepare summary results (last iteration of each)
            var resumen = new[]
            {
        new {
            Metodo = "Bisección",
            Iteraciones = biseccion.Count,
            Raiz = biseccion.Last().Xr,
            Error = biseccion.Last().Ea
        },
        new {
            Metodo = "Regla Falsa",
            Iteraciones = reglaFalsa.Count,
            Raiz = reglaFalsa.Last().Xr,
            Error = reglaFalsa.Last().Ea
        },
        new {
            Metodo = "Newton-Raphson",
            Iteraciones = newton.Count,
            Raiz = newton.Last().Xi,
            Error = newton.Last().Ea
        },
        new {
            Metodo = "Secante",
            Iteraciones = secante.Count,
            Raiz = secante.Last().Xr,
            Error = secante.Last().Ea
            }
        };

            dgvComparacion.DataSource = resumen.ToList();
            dgvComparacion.Columns["Raiz"].DefaultCellStyle.Format = "F8";
            dgvComparacion.Columns["Error"].DefaultCellStyle.Format = "F8";


            LblMejorMetodo.Text = resumen.OrderBy(r => r.Error).First().Metodo;

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            dgvComparacion.DataSource = null;
        }
    }

}
