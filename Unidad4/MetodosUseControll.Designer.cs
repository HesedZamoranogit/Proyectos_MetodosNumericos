namespace Unidad4
{
    partial class MetodosUseControll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnRegresar = new Button();
            cmbMetodos = new ComboBox();
            dgvRegresion = new DataGridView();
            NumeroFIlas = new NumericUpDown();
            NumeroGrado = new NumericUpDown();
            NumeroVariables = new NumericUpDown();
            btnCalcular = new Button();
            crtGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLimpiar = new Button();
            lblResultados = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroFIlas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroGrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroVariables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crtGrafica).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            btnRegresar.Location = new Point(27, 18);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(202, 42);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // cmbMetodos
            // 
            cmbMetodos.ForeColor = Color.Teal;
            cmbMetodos.FormattingEnabled = true;
            cmbMetodos.Items.AddRange(new object[] { "Lineal simple", "Polinomial", "Lineal Multiple" });
            cmbMetodos.Location = new Point(27, 97);
            cmbMetodos.Margin = new Padding(3, 2, 3, 2);
            cmbMetodos.Name = "cmbMetodos";
            cmbMetodos.Size = new Size(309, 27);
            cmbMetodos.TabIndex = 1;
            // 
            // dgvRegresion
            // 
            dgvRegresion.BackgroundColor = Color.FromArgb(29, 35, 51);
            dgvRegresion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegresion.Location = new Point(43, 365);
            dgvRegresion.Margin = new Padding(3, 2, 3, 2);
            dgvRegresion.Name = "dgvRegresion";
            dgvRegresion.RowHeadersWidth = 51;
            dgvRegresion.Size = new Size(685, 309);
            dgvRegresion.TabIndex = 2;
            // 
            // NumeroFIlas
            // 
            NumeroFIlas.ForeColor = Color.Teal;
            NumeroFIlas.Location = new Point(27, 188);
            NumeroFIlas.Margin = new Padding(3, 2, 3, 2);
            NumeroFIlas.Name = "NumeroFIlas";
            NumeroFIlas.Size = new Size(310, 27);
            NumeroFIlas.TabIndex = 3;
            NumeroFIlas.ValueChanged += NumeroFIlas_ValueChanged;
            // 
            // NumeroGrado
            // 
            NumeroGrado.ForeColor = Color.Teal;
            NumeroGrado.Location = new Point(402, 188);
            NumeroGrado.Margin = new Padding(3, 2, 3, 2);
            NumeroGrado.Name = "NumeroGrado";
            NumeroGrado.Size = new Size(310, 27);
            NumeroGrado.TabIndex = 4;
            NumeroGrado.ValueChanged += NumeroGrado_ValueChanged;
            // 
            // NumeroVariables
            // 
            NumeroVariables.ForeColor = Color.Teal;
            NumeroVariables.Location = new Point(402, 98);
            NumeroVariables.Margin = new Padding(2);
            NumeroVariables.Name = "NumeroVariables";
            NumeroVariables.Size = new Size(258, 27);
            NumeroVariables.TabIndex = 5;
            NumeroVariables.ValueChanged += NumeroVariables_ValueChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(29, 35, 51);
            btnCalcular.Location = new Point(42, 267);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(180, 65);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // crtGrafica
            // 
            chartArea1.Name = "ChartArea1";
            crtGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            crtGrafica.Legends.Add(legend1);
            crtGrafica.Location = new Point(749, 318);
            crtGrafica.Margin = new Padding(3, 2, 3, 2);
            crtGrafica.Name = "crtGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            crtGrafica.Series.Add(series1);
            crtGrafica.Size = new Size(499, 356);
            crtGrafica.TabIndex = 8;
            crtGrafica.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(402, 66);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 9;
            label1.Text = "Numero Variables";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(27, 152);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 10;
            label2.Text = "Numero Filas";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 157, 111);
            label3.Location = new Point(402, 152);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 11;
            label3.Text = "Grado Polinomio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(12, 157, 111);
            label4.Location = new Point(27, 76);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 12;
            label4.Text = "Metodos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            btnLimpiar.Location = new Point(230, 267);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(178, 65);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            lblResultados.ForeColor = Color.FromArgb(12, 157, 111);
            lblResultados.Location = new Point(817, 267);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(101, 19);
            lblResultados.TabIndex = 15;
            lblResultados.Text = "Resultados";
            // 
            // MetodosUseControll
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(lblResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(crtGrafica);
            Controls.Add(btnCalcular);
            Controls.Add(NumeroVariables);
            Controls.Add(NumeroGrado);
            Controls.Add(NumeroFIlas);
            Controls.Add(dgvRegresion);
            Controls.Add(cmbMetodos);
            Controls.Add(btnRegresar);
            Font = new Font("HP Simplified Hans", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.FromArgb(12, 157, 111);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MetodosUseControll";
            Size = new Size(1263, 692);
            Load += Metodos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroFIlas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroGrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroVariables).EndInit();
            ((System.ComponentModel.ISupportInitialize)crtGrafica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private ComboBox cmbMetodos;
        private DataGridView dgvRegresion;
        private NumericUpDown NumeroFIlas;
        private NumericUpDown NumeroGrado;
        private NumericUpDown NumeroVariables;
        private Button btnCalcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGrafica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLimpiar;
        private Label lblResultados;
    }
}
