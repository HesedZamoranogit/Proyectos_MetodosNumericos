namespace Unidad_5
{
    partial class Interpolacion_Larange
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dvgLarange = new DataGridView();
            label1P = new Label();
            txtFx = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            name = new Label();
            label3 = new Label();
            lblCubicaResultado = new Label();
            lblCuadraticaResultado = new Label();
            lblLinealResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgLarange).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 35, 51);
            button1.ForeColor = Color.FromArgb(12, 157, 111);
            button1.Location = new Point(33, 15);
            button1.Name = "button1";
            button1.Size = new Size(154, 48);
            button1.TabIndex = 0;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dvgLarange
            // 
            dvgLarange.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgLarange.Location = new Point(336, 279);
            dvgLarange.Name = "dvgLarange";
            dvgLarange.RowHeadersWidth = 51;
            dvgLarange.Size = new Size(564, 371);
            dvgLarange.TabIndex = 1;
            // 
            // label1P
            // 
            label1P.AutoSize = true;
            label1P.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1P.ForeColor = SystemColors.ButtonFace;
            label1P.Location = new Point(336, 161);
            label1P.Name = "label1P";
            label1P.Size = new Size(53, 31);
            label1P.TabIndex = 2;
            label1P.Text = "F(X)";
            // 
            // txtFx
            // 
            txtFx.Location = new Point(395, 167);
            txtFx.Name = "txtFx";
            txtFx.Size = new Size(200, 27);
            txtFx.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(117, 370);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(138, 56);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(117, 534);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 56);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(943, 279);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 6;
            label1.Text = "Lineal";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 13.8F);
            name.ForeColor = SystemColors.ButtonFace;
            name.Location = new Point(943, 370);
            name.Name = "name";
            name.Size = new Size(124, 31);
            name.TabIndex = 7;
            name.Text = "Cuadratica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(943, 468);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 8;
            label3.Text = "Cubica";
            // 
            // lblCubicaResultado
            // 
            lblCubicaResultado.AutoSize = true;
            lblCubicaResultado.Font = new Font("Segoe UI", 13.8F);
            lblCubicaResultado.ForeColor = SystemColors.ButtonFace;
            lblCubicaResultado.Location = new Point(1100, 468);
            lblCubicaResultado.Name = "lblCubicaResultado";
            lblCubicaResultado.Size = new Size(0, 31);
            lblCubicaResultado.TabIndex = 11;
            // 
            // lblCuadraticaResultado
            // 
            lblCuadraticaResultado.AutoSize = true;
            lblCuadraticaResultado.Font = new Font("Segoe UI", 13.8F);
            lblCuadraticaResultado.ForeColor = SystemColors.ButtonFace;
            lblCuadraticaResultado.Location = new Point(1100, 370);
            lblCuadraticaResultado.Name = "lblCuadraticaResultado";
            lblCuadraticaResultado.Size = new Size(0, 31);
            lblCuadraticaResultado.TabIndex = 10;
            // 
            // lblLinealResultado
            // 
            lblLinealResultado.AutoSize = true;
            lblLinealResultado.Font = new Font("Segoe UI", 13.8F);
            lblLinealResultado.ForeColor = SystemColors.ButtonFace;
            lblLinealResultado.Location = new Point(1100, 279);
            lblLinealResultado.Name = "lblLinealResultado";
            lblLinealResultado.Size = new Size(0, 31);
            lblLinealResultado.TabIndex = 9;
            // 
            // Interpolacion_Larange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(lblCubicaResultado);
            Controls.Add(lblCuadraticaResultado);
            Controls.Add(lblLinealResultado);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtFx);
            Controls.Add(label1P);
            Controls.Add(dvgLarange);
            Controls.Add(button1);
            Name = "Interpolacion_Larange";
            Size = new Size(1243, 729);
            ((System.ComponentModel.ISupportInitialize)dvgLarange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dvgLarange;
        private Label label1P;
        private TextBox txtFx;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label1;
        private Label name;
        private Label label3;
        private Label lblCubicaResultado;
        private Label lblCuadraticaResultado;
        private Label lblLinealResultado;
    }
}
