namespace Unidad2_MetodosNumericos.Formularios.MetodoGauss__Jordan
{
    partial class Metodo_Gauss_Seidel
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
            LblTitulo = new Label();
            BtnCalcular = new Button();
            comboTamaño = new ComboBox();
            tablePanel = new TableLayoutPanel();
            dataGridResultado = new DataGridView();
            BtnRegresar = new Button();
            BtnLlenarAleatorio = new Button();
            BtnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.FromArgb(29, 35, 51);
            LblTitulo.Font = new Font("HP Simplified", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.FromArgb(12, 157, 111);
            LblTitulo.Location = new Point(763, 12);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(480, 67);
            LblTitulo.TabIndex = 34;
            LblTitulo.Text = "METODO DE GAUSS SEIDEL";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(12, 157, 111);
            BtnCalcular.FlatStyle = FlatStyle.Flat;
            BtnCalcular.Location = new Point(12, 246);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(154, 44);
            BtnCalcular.TabIndex = 37;
            BtnCalcular.Text = "RESULTADOS";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // comboTamaño
            // 
            comboTamaño.BackColor = Color.FromArgb(29, 35, 51);
            comboTamaño.ForeColor = SystemColors.InactiveBorder;
            comboTamaño.FormattingEnabled = true;
            comboTamaño.Items.AddRange(new object[] { "3x3", "4x4", "8x8", "10x10" });
            comboTamaño.Location = new Point(12, 124);
            comboTamaño.Name = "comboTamaño";
            comboTamaño.Size = new Size(174, 28);
            comboTamaño.TabIndex = 38;
            // 
            // tablePanel
            // 
            tablePanel.BackColor = Color.FromArgb(29, 35, 51);
            tablePanel.ColumnCount = 2;
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePanel.Location = new Point(272, 93);
            tablePanel.Name = "tablePanel";
            tablePanel.RowCount = 2;
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanel.Size = new Size(948, 315);
            tablePanel.TabIndex = 39;
            // 
            // dataGridResultado
            // 
            dataGridResultado.BackgroundColor = Color.FromArgb(29, 35, 51);
            dataGridResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultado.Location = new Point(136, 414);
            dataGridResultado.Name = "dataGridResultado";
            dataGridResultado.RowHeadersWidth = 51;
            dataGridResultado.Size = new Size(1007, 289);
            dataGridResultado.TabIndex = 40;
            dataGridResultado.CellContentClick += dataGridResultado_CellContentClick;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(3, 3);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(183, 57);
            BtnRegresar.TabIndex = 42;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            // 
            // BtnLlenarAleatorio
            // 
            BtnLlenarAleatorio.BackColor = Color.FromArgb(29, 35, 51);
            BtnLlenarAleatorio.FlatStyle = FlatStyle.Flat;
            BtnLlenarAleatorio.ForeColor = SystemColors.ButtonFace;
            BtnLlenarAleatorio.Location = new Point(12, 177);
            BtnLlenarAleatorio.Name = "BtnLlenarAleatorio";
            BtnLlenarAleatorio.Size = new Size(154, 45);
            BtnLlenarAleatorio.TabIndex = 43;
            BtnLlenarAleatorio.Text = "LLenar Campos";
            BtnLlenarAleatorio.UseVisualStyleBackColor = false;
            BtnLlenarAleatorio.Click += BtnLlenarAleatorio_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.ForeColor = SystemColors.ButtonFace;
            BtnLimpiar.Location = new Point(12, 316);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(154, 48);
            BtnLimpiar.TabIndex = 44;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Metodo_Gauss_Seidel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnLlenarAleatorio);
            Controls.Add(BtnRegresar);
            Controls.Add(dataGridResultado);
            Controls.Add(tablePanel);
            Controls.Add(comboTamaño);
            Controls.Add(BtnCalcular);
            Controls.Add(LblTitulo);
            Name = "Metodo_Gauss_Seidel";
            Size = new Size(1243, 729);
            Load += Metodo_Gauss_Seidel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LblTitulo;
        private Button BtnCalcular;
        private ComboBox comboTamaño;
        private TableLayoutPanel tablePanel;
        private DataGridView dataGridResultado;
        private Button BtnRegresar;
        private Button BtnLlenarAleatorio;
        private Button BtnLimpiar;
    }
}
