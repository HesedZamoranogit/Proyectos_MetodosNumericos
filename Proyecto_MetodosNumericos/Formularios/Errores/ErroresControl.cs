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
using Proyecto_MetodosNumericos.Implementaciones;

namespace Proyecto_MetodosNumericos.Formularios.Errores
{

    public partial class ErroresControl : UserControl
    {
        // Evento personalizado
        public event EventHandler? RegresarClicked;
        public Double ValorReal { get; set; }
        public Double ValorAproximado { get; set; }
        public ErroresControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            // Llama al evento Paint
            this.Paint += new PaintEventHandler(Form_Paint);

        }


       
        public double ErrorAbsoluto()
        {
            double Ea = Math.Abs(ValorReal - ValorAproximado);

            if (Ea < 0)
            {
                Ea = Ea * -1;
                return Ea;
            }
            else
            {
                return Ea;
            }

        }

        public double ErrorRelativo()
        {
            double Er = Math.Abs(ValorReal - ValorAproximado) / Math.Abs(ValorReal) * 100;
            return Er;
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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            // Dispara el evento
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ErroresControl_Load(object sender, EventArgs e)
        {
            Border_R.AplicarRedondeado(panelFondo, 8);
            Border_R.AplicarRedondeado(BtnRegresar, 8);
            Border_R.AplicarRedondeado(txtVr, 8);
            Border_R.AplicarRedondeado(txtVa, 8);
            Border_R.AplicarRedondeado(txtEa, 8);
            Border_R.AplicarRedondeado(txtEr, 8);


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtVa.Clear();
            txtVr.Clear();
            txtEa.Clear();
            txtEr.Clear();
        }

        //ESTE ES EL VALOR REAL TEXTBOX QUE SE ESCRIBE
        private void txtVr_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtVr.Text, out Double valorReal))
                ValorReal = valorReal;
            else
                ValorReal = 0;
        }

        //ESTE ES EL VALOR APROXIMADO TEXTBOX QUE SE ESCRIBE
        private void txtVa_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtVa.Text, out Double valorAprox))
                ValorAproximado = valorAprox;
            else
                ValorAproximado = 0;
        }
        private void BtnResultados_Click(object sender, EventArgs e)
        {
            if (ValorReal == 0 || ValorAproximado == 0)
            {
                MessageBox.Show("Por favor ingrese valores numéricos distintos de cero en ambos campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtEa.Text = ErrorAbsoluto().ToString();
            txtEr.Text = ErrorRelativo().ToString();
        }

        //ESTE ES EL VALOR APROXIMADO TEXTBOX ESTATICO
        private void txtEa_TextChanged(object sender, EventArgs e)
        {

            txtEa.Text = ErrorAbsoluto().ToString();
        }
        //ESTE ES EL VALOR APROXIMADO TEXTBOX ESTATICO
        private void txtEr_TextChanged(object sender, EventArgs e)
        {
            txtEr.Text = ErrorRelativo().ToString();
        }
    }
}
