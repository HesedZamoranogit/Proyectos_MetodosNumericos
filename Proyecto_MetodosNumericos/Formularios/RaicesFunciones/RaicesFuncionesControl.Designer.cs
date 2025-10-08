namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    partial class RaicesFuncionesControl
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
            BtnRegresar = new Button();
            label1 = new Label();
            BtnBiseccion = new Button();
            BtnRFalsa = new Button();
            BtnSecante = new Button();
            BtnNewton = new Button();
            dgvComparacion = new DataGridView();
            BtnComparacion = new Button();
            label2 = new Label();
            LblMejorMetodo = new Label();
            BtnLimpiar = new Button();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvComparacion).BeginInit();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(3, 0);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(173, 49);
            BtnRegresar.TabIndex = 3;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(1243, 62);
            label1.TabIndex = 4;
            label1.Text = "PROYECTO RAICES FUNCIONES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnBiseccion
            // 
            BtnBiseccion.BackColor = Color.FromArgb(29, 35, 51);
            BtnBiseccion.Cursor = Cursors.Hand;
            BtnBiseccion.FlatStyle = FlatStyle.Flat;
            BtnBiseccion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnBiseccion.ForeColor = Color.FromArgb(12, 157, 111);
            BtnBiseccion.Location = new Point(266, 151);
            BtnBiseccion.Name = "BtnBiseccion";
            BtnBiseccion.Size = new Size(231, 58);
            BtnBiseccion.TabIndex = 5;
            BtnBiseccion.Text = "Metodo Biseccion";
            BtnBiseccion.UseVisualStyleBackColor = false;
            BtnBiseccion.Click += BtnBiseccion_Click;
            // 
            // BtnRFalsa
            // 
            BtnRFalsa.BackColor = Color.FromArgb(29, 35, 51);
            BtnRFalsa.Cursor = Cursors.Hand;
            BtnRFalsa.FlatStyle = FlatStyle.Flat;
            BtnRFalsa.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnRFalsa.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRFalsa.Location = new Point(736, 151);
            BtnRFalsa.Name = "BtnRFalsa";
            BtnRFalsa.Size = new Size(231, 58);
            BtnRFalsa.TabIndex = 6;
            BtnRFalsa.Text = "Metodo Regla Falsa";
            BtnRFalsa.UseVisualStyleBackColor = false;
            BtnRFalsa.Click += BtnRFalsa_Click;
            // 
            // BtnSecante
            // 
            BtnSecante.BackColor = Color.FromArgb(29, 35, 51);
            BtnSecante.Cursor = Cursors.Hand;
            BtnSecante.FlatStyle = FlatStyle.Flat;
            BtnSecante.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnSecante.ForeColor = Color.FromArgb(12, 157, 111);
            BtnSecante.Location = new Point(736, 244);
            BtnSecante.Name = "BtnSecante";
            BtnSecante.Size = new Size(231, 58);
            BtnSecante.TabIndex = 9;
            BtnSecante.Text = "Metodo Secante";
            BtnSecante.UseVisualStyleBackColor = false;
            BtnSecante.Click += BtnSecante_Click;
            // 
            // BtnNewton
            // 
            BtnNewton.BackColor = Color.FromArgb(29, 35, 51);
            BtnNewton.Cursor = Cursors.Hand;
            BtnNewton.FlatStyle = FlatStyle.Flat;
            BtnNewton.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnNewton.ForeColor = Color.FromArgb(12, 157, 111);
            BtnNewton.Location = new Point(266, 244);
            BtnNewton.Name = "BtnNewton";
            BtnNewton.Size = new Size(231, 58);
            BtnNewton.TabIndex = 8;
            BtnNewton.Text = "Metodo Newton";
            BtnNewton.UseVisualStyleBackColor = false;
            BtnNewton.Click += BtnNewton_Click;
            // 
            // dgvComparacion
            // 
            dgvComparacion.BackgroundColor = Color.FromArgb(29, 35, 51);
            dgvComparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComparacion.Location = new Point(34, 363);
            dgvComparacion.Name = "dgvComparacion";
            dgvComparacion.RowHeadersWidth = 51;
            dgvComparacion.Size = new Size(761, 314);
            dgvComparacion.TabIndex = 10;
            // 
            // BtnComparacion
            // 
            BtnComparacion.BackColor = Color.FromArgb(29, 35, 51);
            BtnComparacion.FlatStyle = FlatStyle.Flat;
            BtnComparacion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnComparacion.ForeColor = Color.FromArgb(12, 157, 111);
            BtnComparacion.Location = new Point(1059, 358);
            BtnComparacion.Name = "BtnComparacion";
            BtnComparacion.Size = new Size(162, 47);
            BtnComparacion.TabIndex = 11;
            BtnComparacion.Text = "Comparar";
            BtnComparacion.UseVisualStyleBackColor = false;
            BtnComparacion.Click += BtnComparacion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(839, 369);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 12;
            label2.Text = "Mejor Metodo";
            // 
            // LblMejorMetodo
            // 
            LblMejorMetodo.AutoSize = true;
            LblMejorMetodo.BackColor = Color.FromArgb(12, 157, 111);
            LblMejorMetodo.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblMejorMetodo.ForeColor = Color.FromArgb(29, 35, 51);
            LblMejorMetodo.Location = new Point(839, 406);
            LblMejorMetodo.Name = "LblMejorMetodo";
            LblMejorMetodo.Size = new Size(0, 25);
            LblMejorMetodo.TabIndex = 13;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(1059, 424);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(162, 47);
            BtnLimpiar.TabIndex = 15;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1243, 729);
            panelContenedor.TabIndex = 16;
            panelContenedor.Visible = false;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // RaicesFuncionesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(panelContenedor);
            Controls.Add(BtnLimpiar);
            Controls.Add(LblMejorMetodo);
            Controls.Add(label2);
            Controls.Add(BtnComparacion);
            Controls.Add(dgvComparacion);
            Controls.Add(BtnSecante);
            Controls.Add(BtnNewton);
            Controls.Add(BtnRFalsa);
            Controls.Add(BtnBiseccion);
            Controls.Add(label1);
            Controls.Add(BtnRegresar);
            Name = "RaicesFuncionesControl";
            Size = new Size(1243, 729);
            Load += RaicesFuncionesControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComparacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private Label label1;
        private Button BtnBiseccion;
        private Button BtnRFalsa;
        private Button BtnSecante;
        private Button BtnNewton;
        private DataGridView dgvComparacion;
        private Button BtnComparacion;
        private Label label2;
        private Label LblMejorMetodo;
        private Button BtnLimpiar;
        private Panel panelContenedor;
    }
}
