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
using Unidad2_MetodosNumericos.Implementacioness;

namespace Unidad2_MetodosNumericos.Formularios
{
    public partial class Metodo_Gauss : UserControl
    {

        public event EventHandler? RegresarClicked;
        public Metodo_Gauss()
        {
            InitializeComponent();

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



        private void Metodo_Gauss_Load(object sender, EventArgs e)
        {
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
        }


        private void BtnResultados_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] campos = {
                    txtX1_1, txtX1_2, txtX1_3, txtRx1,
                    txtX2_1, txtX2_2, txtX2_3, txtRx2,
                    txtX3_1, txtX3_2, txtX3_3, txtRx3
                };
                double[] valores = new double[campos.Length];

                for (int i = 0; i < campos.Length; i++)
                {

                    if (!double.TryParse(campos[i].Text, out valores[i]))
                    {
                        MessageBox.Show(
                            $"El campo #{i + 1} está vacío o no es un número válido.",
                            "Atención",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                }

                var metodos = new Implementacioness.Metodos();
                double[,] matriz = new double[3, 4]
                {
            { valores[0], valores[1], valores[2], valores[3] },
            { valores[4], valores[5], valores[6], valores[7] },
            { valores[8], valores[9], valores[10], valores[11] }
                };

                string seleccion = CmbFuncion.SelectedItem?.ToString() ?? "";
                double[] respuesta = null;

                if (seleccion == "METODO_GAUSS")
                {
                    respuesta = metodos.EliminacionGauss(matriz);
                }
                else if (seleccion == "METODO_GAUSS-JORDAN")
                {
                    respuesta = metodos.GaussJordan(matriz);
                }
                else
                    throw new Exception("Selecciona un método válido.");

                Rx1.Text = respuesta[0].ToString("F4");
                Rx2.Text = respuesta[1].ToString("F4");
                Rx3.Text = respuesta[2].ToString("F4");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            txtX1_1.Clear();
            txtX1_2.Clear();
            txtX1_3.Clear();
            txtRx1.Clear();

            txtX2_1.Clear();
            txtX2_2.Clear();
            txtX2_3.Clear();
            txtRx2.Clear();

            txtX3_1.Clear();
            txtX3_2.Clear();
            txtX3_3.Clear();
            txtRx3.Clear();

            // Limpiar los resultados
            Rx1.Clear();
            Rx2.Clear();
            Rx3.Clear();
            // Reiniciar el ComboBox
            CmbFuncion.SelectedIndex = -1;
        }
    }
}

