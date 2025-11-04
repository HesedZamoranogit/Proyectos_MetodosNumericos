using System.Drawing.Drawing2D;


namespace Unidad4
{
    public partial class Form1 : Form
    {
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
  
        }



        private void Metodos_RegresarClicked(object sender, EventArgs e)
        {
            // Aquí defines qué pasa al regresar, por ejemplo:
            panelContenedor.Controls.Clear();
            panelContenedor.Visible = false;
        }


        private void btnMetodos_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            MetodosUseControll metodosControl = new MetodosUseControll();
            metodosControl.Dock = DockStyle.Fill;
            metodosControl.RegresarClicked += Metodos_RegresarClicked;
            panelContenedor.Controls.Add(metodosControl);
            panelContenedor.Visible = true;
        }





    }
}
