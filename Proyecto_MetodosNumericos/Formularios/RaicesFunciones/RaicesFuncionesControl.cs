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
    }
}
