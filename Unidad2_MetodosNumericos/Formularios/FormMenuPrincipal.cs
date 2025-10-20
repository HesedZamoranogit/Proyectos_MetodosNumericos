using System.Drawing;               // Color
using System.Drawing.Drawing2D;
using Unidad2_MetodosNumericos.Formularios;
using Unidad2_MetodosNumericos.Formularios.MetodoGauss__Jordan;



namespace Proyecto_MetodosNumericos
{
    public partial class FormMenuPrincipal : Form
    {


        public FormMenuPrincipal()
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


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void MetodoGaussSeidel_RegresarClicked(object sender, EventArgs e)
        {
            // Aquí defines qué pasa al regresar, por ejemplo:
            panelContenedor.Controls.Clear();
            panelContenedor.Visible = false;
        }

        private void MetodoGauss_RegresarClicked(object sender, EventArgs e)
        {
            // Aquí defines qué pasa al regresar, por ejemplo:
            panelContenedor.Controls.Clear();
            panelContenedor.Visible = false;
        }

        /*
        private void BtnErrores_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            ErroresControl Errores = new ErroresControl();
            Errores.Dock = DockStyle.Fill;

            // Suscribe al evento RegresarClicked
            Errores.RegresarClicked += ErroresControl_RegresarClicked;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Errores);
        }

        private void BtnRaicesFunciones_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            RaicesFuncionesControl RaicesFunciones = new RaicesFuncionesControl();
            RaicesFunciones.Dock = DockStyle.Fill;

            RaicesFunciones.RegresarClicked += RaicesFuncionesControl_RegresarClicked;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(RaicesFunciones);

        }*/

        private void BtnGauss_Click(object sender, EventArgs e)
        {

            panelContenedor.Visible = true;
            Metodo_Gauss G_J = new Metodo_Gauss();
            G_J.Dock = DockStyle.Fill;

            G_J.RegresarClicked += MetodoGauss_RegresarClicked;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(G_J);

        }

        private void BtnGauss_Seidel_Click(object sender, EventArgs e)
        {

            panelContenedor.Visible = true;
            Metodo_Gauss_Seidel G_J = new Metodo_Gauss_Seidel();
            G_J.Dock = DockStyle.Fill;

            G_J.RegresarClicked += MetodoGaussSeidel_RegresarClicked;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(G_J);
        }
    }
}
