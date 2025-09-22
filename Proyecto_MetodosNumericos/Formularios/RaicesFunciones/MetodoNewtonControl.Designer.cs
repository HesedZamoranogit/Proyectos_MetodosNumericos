namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    partial class MetodoNewtonControl
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
            LblValorMax = new Label();
            txtEa = new TextBox();
            BtnLimpiar = new Button();
            label2 = new Label();
            txtXi = new TextBox();
            CmbFuncion = new ComboBox();
            dgvNewton = new DataGridView();
            BtnResultado = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNewton).BeginInit();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(3, 0);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(186, 48);
            BtnRegresar.TabIndex = 1;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(838, 35);
            label1.Name = "label1";
            label1.Size = new Size(405, 62);
            label1.TabIndex = 18;
            label1.Text = "METODO NEWTON";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblValorMax
            // 
            LblValorMax.AutoSize = true;
            LblValorMax.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorMax.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorMax.Location = new Point(350, 91);
            LblValorMax.Name = "LblValorMax";
            LblValorMax.Size = new Size(138, 25);
            LblValorMax.TabIndex = 28;
            LblValorMax.Text = "Valor Maximo";
            // 
            // txtEa
            // 
            txtEa.BackColor = Color.FromArgb(29, 35, 51);
            txtEa.BorderStyle = BorderStyle.None;
            txtEa.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEa.ForeColor = Color.White;
            txtEa.Location = new Point(350, 119);
            txtEa.Name = "txtEa";
            txtEa.Size = new Size(184, 20);
            txtEa.TabIndex = 27;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(56, 167);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(130, 50);
            BtnLimpiar.TabIndex = 26;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 25;
            label2.Text = "Valor Inicial";
            // 
            // txtXi
            // 
            txtXi.BackColor = Color.FromArgb(29, 35, 51);
            txtXi.BorderStyle = BorderStyle.None;
            txtXi.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtXi.ForeColor = Color.White;
            txtXi.Location = new Point(56, 119);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(260, 20);
            txtXi.TabIndex = 24;
            // 
            // CmbFuncion
            // 
            CmbFuncion.BackColor = Color.FromArgb(29, 35, 51);
            CmbFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFuncion.FlatStyle = FlatStyle.Flat;
            CmbFuncion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            CmbFuncion.ForeColor = SystemColors.MenuBar;
            CmbFuncion.FormattingEnabled = true;
            CmbFuncion.Location = new Point(568, 119);
            CmbFuncion.Name = "CmbFuncion";
            CmbFuncion.Size = new Size(327, 33);
            CmbFuncion.TabIndex = 29;
            // 
            // dgvNewton
            // 
            dgvNewton.BackgroundColor = Color.FromArgb(29, 35, 51);
            dgvNewton.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNewton.Location = new Point(148, 250);
            dgvNewton.Name = "dgvNewton";
            dgvNewton.RowHeadersWidth = 51;
            dgvNewton.Size = new Size(936, 454);
            dgvNewton.TabIndex = 30;
            // 
            // BtnResultado
            // 
            BtnResultado.BackColor = Color.FromArgb(29, 35, 51);
            BtnResultado.FlatStyle = FlatStyle.Flat;
            BtnResultado.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnResultado.ForeColor = Color.FromArgb(12, 157, 111);
            BtnResultado.Location = new Point(192, 167);
            BtnResultado.Name = "BtnResultado";
            BtnResultado.Size = new Size(208, 50);
            BtnResultado.TabIndex = 34;
            BtnResultado.Text = "Resultado";
            BtnResultado.UseVisualStyleBackColor = false;
            BtnResultado.Click += BtnResultado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 157, 111);
            label3.Location = new Point(568, 82);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 35;
            label3.Text = "Funcion";
            // 
            // MetodoNewtonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(label3);
            Controls.Add(BtnResultado);
            Controls.Add(dgvNewton);
            Controls.Add(CmbFuncion);
            Controls.Add(LblValorMax);
            Controls.Add(txtEa);
            Controls.Add(BtnLimpiar);
            Controls.Add(label2);
            Controls.Add(txtXi);
            Controls.Add(label1);
            Controls.Add(BtnRegresar);
            Name = "MetodoNewtonControl";
            Size = new Size(1243, 729);
            Load += MetodoNewtonControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNewton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private Label label1;
        private Label LblValorMax;
        private TextBox txtEa;
        private Button BtnLimpiar;
        private Label label2;
        private TextBox txtXi;
        private ComboBox CmbFuncion;
        private DataGridView dgvNewton;
        private Button BtnResultado;
        private Label label3;
    }
}
