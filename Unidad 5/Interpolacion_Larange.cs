using System;
using System.Linq;
using System.Windows.Forms;
using Unidad_5.Metodos;

namespace Unidad_5
{
    public partial class Interpolacion_Larange : UserControl
    {
        private readonly Metodos.Metodos met = new Metodos.Metodos();
        public event EventHandler? RegresarClicked;

        public Interpolacion_Larange()
        {
            InitializeComponent();

            // Configure grid: 2 columns (X, F(X)), 4 rows X0..X3
            dvgLarange.AllowUserToAddRows = false;
            dvgLarange.AllowUserToDeleteRows = true;
            dvgLarange.ReadOnly = false;
            dvgLarange.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dvgLarange.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dvgLarange.Columns.Clear();
            dvgLarange.Columns.Add(new DataGridViewTextBoxColumn { Name = "X", HeaderText = "X", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dvgLarange.Columns.Add(new DataGridViewTextBoxColumn { Name = "FX", HeaderText = "F(X)", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dvgLarange.RowHeadersVisible = true;
            dvgLarange.RowCount = 4; // X0..X3
            dvgLarange.Rows[0].HeaderCell.Value = "X0";
            dvgLarange.Rows[1].HeaderCell.Value = "X1";
            dvgLarange.Rows[2].HeaderCell.Value = "X2";
            dvgLarange.Rows[3].HeaderCell.Value = "X3";

            btnCalcular.Click += BtnCalcular_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            button1.Click += (s, e) => RegresarClicked?.Invoke(this, EventArgs.Empty);
        }

        private ((double x, double y)[] pts, double xq) LeerDatos()
        {
            // lee hasta 4 filas con ambos valores numéricos
            var list = dvgLarange.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => (
                    xObj: r.Cells[0].Value, yObj: r.Cells[1].Value,
                    xStr: r.Cells[0].Value?.ToString(), yStr: r.Cells[1].Value?.ToString()))
                .Where(t => !string.IsNullOrWhiteSpace(t.xStr) && !string.IsNullOrWhiteSpace(t.yStr))
                .Select(t => (x: double.Parse(t.xStr!), y: double.Parse(t.yStr!)))
                .Take(4)
                .ToArray();

            if (list.Length < 2)
                throw new Exception("Debes proporcionar al menos 2 pares (X, F(X)).");

            if (!double.TryParse(txtFx.Text, out double xq))
                throw new Exception("Ingresa un valor numérico para X en F(X).");

            return (list, xq);
        }

        private void BtnCalcular_Click(object? sender, EventArgs e)
        {
            try
            {
                var (pts, xq) = LeerDatos();

                // Reset labels
                lblLinealResultado.Text = string.Empty;
                lblCuadraticaResultado.Text = string.Empty;
                lblCubicaResultado.Text = string.Empty;

                if (pts.Length >= 2)
                {
                    var l = met.InterpolacionLineal(pts, xq);
                    lblLinealResultado.Text = l.ToString("G6");
                }
                if (pts.Length >= 3)
                {
                    var q = met.InterpolacionCuadratica(pts, xq);
                    lblCuadraticaResultado.Text = q.ToString("G6");
                }
                if (pts.Length >= 4)
                {
                    var c = met.InterpolacionCubica(pts, xq);
                    lblCubicaResultado.Text = c.ToString("G6");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos los valores deben ser numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object? sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dvgLarange.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells) cell.Value = null;
            }
            txtFx.Clear();
            lblLinealResultado.Text = string.Empty;
            lblCuadraticaResultado.Text = string.Empty;
            lblCubicaResultado.Text = string.Empty;
        }
    }
}
