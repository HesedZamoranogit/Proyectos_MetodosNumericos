namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    partial class MetodoSecanteControl
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
            lblValorInicial = new Label();
            txtX1 = new TextBox();
            label1 = new Label();
            LblValorMax = new Label();
            txtEa = new TextBox();
            BtnLimpiar = new Button();
            CmbFuncion = new ComboBox();
            dgvSecante = new DataGridView();
            label2 = new Label();
            BtnResultado = new Button();
            label3 = new Label();
            txtX2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSecante).BeginInit();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(3, 3);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(186, 48);
            BtnRegresar.TabIndex = 1;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            lblValorInicial.ForeColor = Color.FromArgb(12, 157, 111);
            lblValorInicial.Location = new Point(118, 111);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new Size(121, 25);
            lblValorInicial.TabIndex = 17;
            lblValorInicial.Text = "Valor Inicial";
            // 
            // txtX1
            // 
            txtX1.BackColor = Color.FromArgb(29, 35, 51);
            txtX1.BorderStyle = BorderStyle.None;
            txtX1.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtX1.ForeColor = Color.White;
            txtX1.Location = new Point(118, 152);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(260, 20);
            txtX1.TabIndex = 16;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(838, 41);
            label1.Name = "label1";
            label1.Size = new Size(405, 62);
            label1.TabIndex = 19;
            label1.Text = "METODO SECANTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblValorMax
            // 
            LblValorMax.AutoSize = true;
            LblValorMax.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorMax.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorMax.Location = new Point(698, 111);
            LblValorMax.Name = "LblValorMax";
            LblValorMax.Size = new Size(138, 25);
            LblValorMax.TabIndex = 23;
            LblValorMax.Text = "Valor Maximo";
            // 
            // txtEa
            // 
            txtEa.BackColor = Color.FromArgb(29, 35, 51);
            txtEa.BorderStyle = BorderStyle.None;
            txtEa.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEa.ForeColor = Color.White;
            txtEa.Location = new Point(698, 152);
            txtEa.Name = "txtEa";
            txtEa.Size = new Size(184, 20);
            txtEa.TabIndex = 22;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(143, 206);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(130, 50);
            BtnLimpiar.TabIndex = 21;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // CmbFuncion
            // 
            CmbFuncion.BackColor = Color.FromArgb(29, 35, 51);
            CmbFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFuncion.FlatStyle = FlatStyle.Flat;
            CmbFuncion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            CmbFuncion.ForeColor = SystemColors.MenuBar;
            CmbFuncion.FormattingEnabled = true;
            CmbFuncion.Location = new Point(899, 152);
            CmbFuncion.Name = "CmbFuncion";
            CmbFuncion.Size = new Size(327, 33);
            CmbFuncion.TabIndex = 30;
            // 
            // dgvSecante
            // 
            dgvSecante.BackgroundColor = Color.FromArgb(29, 35, 51);
            dgvSecante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecante.Location = new Point(140, 279);
            dgvSecante.Name = "dgvSecante";
            dgvSecante.RowHeadersWidth = 51;
            dgvSecante.Size = new Size(932, 372);
            dgvSecante.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(899, 111);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 32;
            label2.Text = "Funcion";
            // 
            // BtnResultado
            // 
            BtnResultado.BackColor = Color.FromArgb(29, 35, 51);
            BtnResultado.FlatStyle = FlatStyle.Flat;
            BtnResultado.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnResultado.ForeColor = Color.FromArgb(12, 157, 111);
            BtnResultado.Location = new Point(279, 206);
            BtnResultado.Name = "BtnResultado";
            BtnResultado.Size = new Size(208, 50);
            BtnResultado.TabIndex = 33;
            BtnResultado.Text = "Resultado";
            BtnResultado.UseVisualStyleBackColor = false;
            BtnResultado.Click += BtnResultado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 157, 111);
            label3.Location = new Point(404, 111);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 35;
            label3.Text = "Valor Inicial";
            // 
            // txtX2
            // 
            txtX2.BackColor = Color.FromArgb(29, 35, 51);
            txtX2.BorderStyle = BorderStyle.None;
            txtX2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtX2.ForeColor = Color.White;
            txtX2.Location = new Point(404, 152);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(260, 20);
            txtX2.TabIndex = 34;
            // 
            // MetodoSecanteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(label3);
            Controls.Add(txtX2);
            Controls.Add(BtnResultado);
            Controls.Add(label2);
            Controls.Add(dgvSecante);
            Controls.Add(CmbFuncion);
            Controls.Add(LblValorMax);
            Controls.Add(txtEa);
            Controls.Add(BtnLimpiar);
            Controls.Add(label1);
            Controls.Add(lblValorInicial);
            Controls.Add(txtX1);
            Controls.Add(BtnRegresar);
            Name = "MetodoSecanteControl";
            Size = new Size(1243, 729);
            Load += MetodoSecanteControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSecante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private Label lblValorInicial;
        private TextBox txtX1;
        private Label label1;
        private Label LblValorMax;
        private TextBox txtEa;
        private Button BtnLimpiar;
        private ComboBox CmbFuncion;
        private DataGridView dgvSecante;
        private Label label2;
        private Button BtnResultado;
        private Label label3;
        private TextBox txtX2;
    }
}
