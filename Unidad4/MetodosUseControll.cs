using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Unidad4.Metodos;

namespace Unidad4
{
    public partial class MetodosUseControll : UserControl
    {
        private readonly Metodos.Metodos impl = new Metodos.Metodos();

        public event EventHandler? RegresarClicked;
        public MetodosUseControll()
        {
            InitializeComponent();

            // Configure DataGridView safely
            dgvRegresion.ReadOnly = false;
            dgvRegresion.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvRegresion.AllowUserToAddRows = false; // we'll manage rows explicitly
            dgvRegresion.AllowUserToDeleteRows = true;
            dgvRegresion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRegresion.MultiSelect = false;

            // Wire events
            cmbMetodos.SelectedIndexChanged += cmbMetodos_SelectedIndexChanged;

            // Initialize UI
            Load += Metodos_Load;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Metodos_Load(object sender, EventArgs e)
        {
            // Populate combo with exact method names used in Metodos.cs
            cmbMetodos.Items.Clear();
            cmbMetodos.Items.AddRange(new object[] { "LinealSimple", "Polinomial", "LinealMultiple" });
            cmbMetodos.SelectedIndex = 0;

            NumeroFIlas.Minimum = 1;
            NumeroFIlas.Maximum = 10;
            NumeroFIlas.Value = 5;

            NumeroVariables.Minimum = 1;
            NumeroVariables.Maximum = 10;
            NumeroVariables.Value = 1;

            NumeroGrado.Minimum = 0;
            NumeroGrado.Maximum = 10;
            NumeroGrado.Value = 2;

            BuildGridColumns();
            EnsureRowCount();
            ClearChart();
        }

        private string GetSelectedMetodo() => cmbMetodos.SelectedItem?.ToString() ?? "LinealSimple";

        private void cmbMetodos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ConfigureUIForMethod();
            BuildGridColumns();
            EnsureRowCount();
            ClearChart();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ConfigureUIForMethod()
        {
            var m = GetSelectedMetodo();
            switch (m)
            {
                case "LinealSimple":
                case "Polinomial":
                    NumeroVariables.Enabled = false;
                    NumeroGrado.Enabled = (m == "Polinomial");
                    break;
                case "LinealMultiple":
                    NumeroVariables.Enabled = true;
                    NumeroGrado.Enabled = false;
                    break;
            }
        }

        private void BuildGridColumns()
        {
            dgvRegresion.Columns.Clear();

            var m = GetSelectedMetodo();
            int xCount = (m == "LinealMultiple") ? (int)NumeroVariables.Value : 1;

            for (int j = 0; j < xCount; j++)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = (xCount == 1 && m != "LinealMultiple") ? "X" : $"X{j + 1}",
                    HeaderText = (xCount == 1 && m != "LinealMultiple") ? "X" : $"X{j + 1}",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dgvRegresion.Columns.Add(col);
            }

            var yCol = new DataGridViewTextBoxColumn
            {
                Name = "Y",
                HeaderText = "Y",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvRegresion.Columns.Add(yCol);
        }

        private void EnsureRowCount()
        {
            int n = (int)NumeroFIlas.Value;
            if (n < 1) n = 1;
            int cols = dgvRegresion.Columns.Count;
            if (cols == 0) return;

            Random rnd = new Random();

            // Set RowCount defensively - DataGridView requires >= 1
            dgvRegresion.RowCount = Math.Max(1, n);

            for (int i = 0; i < dgvRegresion.RowCount; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var cell = dgvRegresion.Rows[i].Cells[j];
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        double val = Math.Round(rnd.NextDouble() * 10, 2);
                        cell.Value = val;
                    }
                }
            }
        }

        private List<DataGridViewRow> GetValidRows()
        {
            return dgvRegresion.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
        }

        private double[] ConstruirVectorY(List<DataGridViewRow> filas)
        {
            int colY = dgvRegresion.Columns.Count - 1;
            var y = new double[filas.Count];
            for (int i = 0; i < filas.Count; i++)
            {
                var v = filas[i].Cells[colY].Value;
                if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                    throw new Exception($"Celda vacía en fila {i + 1}, columna Y");
                y[i] = Convert.ToDouble(v);
            }
            return y;
        }

        private double[] ConstruirVectorXSimple(List<DataGridViewRow> filas)
        {
            var x = new double[filas.Count];
            for (int i = 0; i < filas.Count; i++)
            {
                var v = filas[i].Cells[0].Value;
                if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                    throw new Exception($"Celda vacía en fila {i + 1}, columna X");
                x[i] = Convert.ToDouble(v);
            }
            return x;
        }

        private double[,] ConstruirMatrizX(List<DataGridViewRow> filas, int columnasSinY)
        {
            var X = new double[filas.Count, columnasSinY];
            for (int i = 0; i < filas.Count; i++)
            {
                for (int j = 0; j < columnasSinY; j++)
                {
                    var v = filas[i].Cells[j].Value;
                    if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                        throw new Exception($"Celda vacía en fila {i + 1}, columna X{j + 1}");
                    X[i, j] = Convert.ToDouble(v);
                }
            }
            return X;
        }

        private void ClearChart()
        {
            crtGrafica.Series.Clear();
            crtGrafica.Titles.Clear();
        }

        private static double EvalPoly(double[] c, double x)
        {
            double acc = 0.0;
            for (int i = c.Length - 1; i >= 0; i--)
                acc = acc * x + c[i];
            return acc;
        }

        private static IEnumerable<(double x, double y)> PuntosAjusteOrdenados(double[] x, Func<double, double> f)
        {
            double xmin = x.Min(), xmax = x.Max();
            if (Math.Abs(xmax - xmin) < 1e-12)
            {
                foreach (var xi in x.OrderBy(v => v))
                    yield return (xi, f(xi));
                yield break;
            }

            int n = Math.Clamp(100, 2, 1000);
            double dx = (xmax - xmin) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                double xi = xmin + i * dx;
                yield return (xi, f(xi));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegresion.Columns.Count < 2 || dgvRegresion.Rows.Count == 0)
                {
                    MessageBox.Show("Configura y llena la tabla de datos primero.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var metodo = GetSelectedMetodo();

                var filas = GetValidRows();
                if (filas.Count == 0)
                {
                    MessageBox.Show("La tabla no tiene filas válidas.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int columnasX = (metodo == "LinealMultiple") ? dgvRegresion.Columns.Count - 1 : 1;

                double[] y = ConstruirVectorY(filas);
                double[] xSimple = null!;
                double[,] X = null!;

                if (metodo == "LinealSimple" || metodo == "Polinomial")
                {
                    xSimple = ConstruirVectorXSimple(filas);
                }
                else if (metodo == "LinealMultiple")
                {
                    X = ConstruirMatrizX(filas, columnasX);
                }

                // Prepare chart
                ClearChart();
                var serieDatos = crtGrafica.Series.Add("Datos");
                serieDatos.ChartType = SeriesChartType.Point;
                serieDatos.Color = Color.RoyalBlue;
                serieDatos.MarkerSize = 6;

                if (metodo == "LinealMultiple")
                {
                    for (int i = 0; i < filas.Count; i++)
                        serieDatos.Points.AddXY(Convert.ToDouble(filas[i].Cells[0].Value), y[i]);
                }
                else
                {
                    for (int i = 0; i < filas.Count; i++)
                        serieDatos.Points.AddXY(xSimple[i], y[i]);
                }

                var serieReg = crtGrafica.Series.Add("Regresión");
                serieReg.ChartType = SeriesChartType.Line;
                serieReg.Color = Color.Crimson;
                serieReg.BorderWidth = 2;

                string titulo = "";

                switch (metodo)
                {
                    case "LinealSimple":
                        var (a, b) = impl.LinealSimple(xSimple, y);
                        titulo = $"y = {a:F4} + {b:F4}·x";
                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xSimple, (xx) => a + b * xx))
                            serieReg.Points.AddXY(xs, ys);
                        break;

                    case "Polinomial":
                        int grado = (int)NumeroGrado.Value;
                        var coeffs = impl.Polinomial(xSimple, y, grado);
                        titulo = "y = " + string.Join(" + ", coeffs.Select((c, i) => i == 0 ? $"{c:F4}" : i == 1 ? $"{c:F4}·x" : $"{c:F4}·x^{i}"));
                        foreach (var (xs, ys) in PuntosAjusteOrdenados(xSimple, (xx) => EvalPoly(coeffs, xx)))
                            serieReg.Points.AddXY(xs, ys);
                        break;

                    case "LinealMultiple":
                        var beta = impl.LinealMultiple(X, y);
                        titulo = "y = " + string.Join(" + ", beta.Select((c, i) => i == 0 ? $"{c:F4}" : $"{c:F4}·x{i}"));
                        var xs1 = new double[filas.Count];
                        for (int i = 0; i < filas.Count; i++)
                            xs1[i] = Convert.ToDouble(filas[i].Cells[0].Value);

                        var indicesOrden = Enumerable.Range(0, xs1.Length).OrderBy(i => xs1[i]).ToArray();
                        for (int _, idx = 0; idx < indicesOrden.Length; idx++) { /* no-op to satisfy C# */ }
                        foreach (var idx in indicesOrden)
                        {
                            double yest = beta[0];
                            for (int j = 0; j < X.GetLength(1); j++)
                                yest += beta[j + 1] * X[idx, j];
                            serieReg.Points.AddXY(xs1[idx], yest);
                        }
                        break;
                }

                crtGrafica.Titles.Clear();
                crtGrafica.Titles.Add(titulo);
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos los valores de la tabla deben ser números válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRegresion.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = null;

            ClearChart();
        }

        private void NumeroFIlas_ValueChanged(object sender, EventArgs e)
        {
            if (NumeroFIlas.Value < 1) NumeroFIlas.Value = 1; // minimum 1
            if (NumeroFIlas.Value > 10) NumeroFIlas.Value = 10; // safety cap
            EnsureRowCount();
            ClearChart();
        }

        private void NumeroVariables_ValueChanged(object sender, EventArgs e)
        {
            if (GetSelectedMetodo() == "LinealMultiple")
            {
                if (NumeroVariables.Value > 10) NumeroVariables.Value = 10; // safety cap
                BuildGridColumns();
                EnsureRowCount();
                ClearChart();
            }
        }

        private void NumeroGrado_ValueChanged(object sender, EventArgs e)
        {
            if (NumeroGrado.Value > 10) NumeroGrado.Value = 10; // safety cap
            ClearChart();
        }
    }
}
