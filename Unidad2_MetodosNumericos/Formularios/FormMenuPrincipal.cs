using System.Drawing;               // Color
using System.Drawing.Drawing2D;



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

        //EVENTOS DE LOS BOTONES GRADENTE
        private void Proyectos_Load(object sender, EventArgs e)
        {
            var gradenDesign = new GradenDesign();
            gradenDesign.AplicarGradiente(
                boton: BtnGauss,
                colorSuperior: Color.FromArgb(110, 79, 148),
                colorInferior: Color.FromArgb(29, 35, 51),
                direccion: LinearGradientMode.Vertical
            );
        }





        private void BtnTabulacion_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            TabulacionControl tabulacionControl = new TabulacionControl();
            tabulacionControl.Dock = DockStyle.Fill;

            // Suscribe al evento RegresarClicked
            tabulacionControl.RegresarClicked += TabulacionControl_RegresarClicked;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(tabulacionControl);
        }

        // Maneja el evento de regresar
        private void TabulacionControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }


        private void ErroresControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }

        private void RaicesFuncionesControl_RegresarClicked(object? sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            // Aquí puedes cargar otro UserControl, mostrar el menú, etc.
            // Por ejemplo, para ocultar el panel:
            panelContenedor.Visible = false;
        }



        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
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

        }

        private void BtnGauss_Click(object sender, EventArgs e)
        {

        }

        private void BtnGauss_Jordan_Click(object sender, EventArgs e)
        {

        }
    }
}
