namespace Unidad_5
{
    public partial class Principal : Form
    {
        private Interpolacion_Larange? _larange;

        public Principal()
        {
            InitializeComponent();

            btnMetodos.Click += BtnMetodos_Click;
        }

        private void BtnMetodos_Click(object? sender, EventArgs e)
        {
            // Lazy create user control
            if (_larange == null)
            {
                _larange = new Interpolacion_Larange();
                _larange.Dock = DockStyle.Fill;
                _larange.RegresarClicked += (s, _) => MostrarHome();
                panelContenedor.Controls.Clear();
                panelContenedor.Controls.Add(_larange);
            }

            // Show UC and hide home widgets
            panelContenedor.Visible = true;
            _larange.BringToFront();
            ToggleHome(false);
        }

        private void MostrarHome()
        {
            panelContenedor.Visible = false;
            ToggleHome(true);
        }

        private void ToggleHome(bool visible)
        {
            btnMetodos.Visible = visible;
            pictureBox2.Visible = visible;
            pictureBox3.Visible = visible;
            LblTitulo.Visible = visible;
        }
    }
}
