using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_MetodosNumericos.Implementacioness;

namespace Unidad2_MetodosNumericos.Formularios.MetodoGauss__Jordan
{
    public partial class Metodo_Gauss_Seidel : UserControl
    {

        public event EventHandler? RegresarClicked;
        public Metodo_Gauss_Seidel()
        {
            InitializeComponent();
        }
        void CrearMatriz(int n)
        {
            tablePanel.Controls.Clear();
            tablePanel.RowStyles.Clear();
            tablePanel.ColumnStyles.Clear();
            tablePanel.RowCount = n;
            tablePanel.ColumnCount = n + 1; // +1 para el vector de resultados

            for (int i = 0; i < n; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / n));
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == 0)
                        tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / (n + 1)));

                    var txt = new TextBox();
                    txt.Text = "1"; // Valor por defecto
                    txt.Dock = DockStyle.Fill;
                    tablePanel.Controls.Add(txt, j, i);
                }
            }
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Metodo_Gauss_Seidel_Load(object sender, EventArgs e)
        {
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            comboTamaño.SelectedIndexChanged += comboTamaño_SelectedIndexChanged;
        }
        (double[,] matriz, double[] vector) LeerMatrizYVector()
        {
            int n = tablePanel.RowCount;
            double[,] matriz = new double[n, n];
            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    var txt = tablePanel.GetControlFromPosition(j, i) as TextBox;
                    double valor = 1;
                    double.TryParse(txt.Text, out valor);

                    if (j < n)
                        matriz[i, j] = valor;
                    else
                        vector[i] = valor;
                }
            }
            return (matriz, vector);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            var (matriz, vector) = LeerMatrizYVector();
            int n = matriz.GetLength(0);

            var metodos = new Unidad2_MetodosNumericos.Implementacioness.Metodos();
            var iteraciones = metodos.GaussSeidelIterativo(matriz, vector, 100, 0.1); // 0.1% de tolerancia

            // Configura columnas
            dataGridResultado.Columns.Clear();
            for (int i = 0; i < n; i++)
                dataGridResultado.Columns.Add($"x{i + 1}", $"x{i + 1}");
            for (int i = 0; i < n; i++)
                dataGridResultado.Columns.Add($"ea{i + 1}", $"εa{i + 1}");

            // Llena filas
            dataGridResultado.Rows.Clear();
            foreach (var it in iteraciones)
            {
                var row = new List<object>();
                row.AddRange(it.X.Select(x => x.ToString("F4")));
                row.AddRange(it.Ea.Select(ea => ea.ToString("F4")));
                dataGridResultado.Rows.Add(row.ToArray());
            }
        }

        private void comboTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = comboTamaño.SelectedItem.ToString();
            int n = int.Parse(texto.Split('x')[0]);
            CrearMatriz(n);
        }

        private void BtnLlenarAleatorio_Click(object sender, EventArgs e)
        {
            int n = tablePanel.RowCount;
            // Genera la matriz aumentada aleatoria
            double[,] Ab = Metodos.RandomDiagonallyDominantAugmented(n);

            // Llena los TextBox del TableLayoutPanel
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    var txt = tablePanel.GetControlFromPosition(j, i) as TextBox;
                    if (txt != null)
                        txt.Text = Ab[i, j].ToString();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            tablePanel.Controls.Clear();
            dataGridResultado.Rows.Clear();
            comboTamaño.SelectedIndex = 0;


        }

        private void dataGridResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
