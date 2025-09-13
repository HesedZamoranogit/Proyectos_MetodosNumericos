namespace Proyecto_MetodosNumericos.Formularios.Tabulacion
{
    partial class TabulacionControl
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
            label1 = new Label();
            BtnRegresar = new Button();
            BtnFuncionF = new Button();
            BtnFuncionG = new Button();
            dataGridResultados = new DataGridView();
            BtnLimpiar = new Button();
            LblMin = new Label();
            LblMax = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(-3, 83);
            label1.Name = "label1";
            label1.Size = new Size(1096, 62);
            label1.TabIndex = 0;
            label1.Text = "TABULACION DE FUNCIONES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(16, 20);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(117, 48);
            BtnRegresar.TabIndex = 1;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnFuncionF
            // 
            BtnFuncionF.AutoSize = true;
            BtnFuncionF.BackColor = Color.FromArgb(29, 35, 51);
            BtnFuncionF.FlatStyle = FlatStyle.Flat;
            BtnFuncionF.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnFuncionF.ForeColor = Color.FromArgb(12, 157, 111);
            BtnFuncionF.Location = new Point(762, 183);
            BtnFuncionF.Name = "BtnFuncionF";
            BtnFuncionF.Size = new Size(145, 61);
            BtnFuncionF.TabIndex = 2;
            BtnFuncionF.Text = "Funcion-->F";
            BtnFuncionF.UseVisualStyleBackColor = false;
            BtnFuncionF.Click += BtnFuncionF_Click;
            // 
            // BtnFuncionG
            // 
            BtnFuncionG.AutoSize = true;
            BtnFuncionG.BackColor = Color.FromArgb(29, 35, 51);
            BtnFuncionG.FlatStyle = FlatStyle.Flat;
            BtnFuncionG.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnFuncionG.ForeColor = Color.FromArgb(12, 157, 111);
            BtnFuncionG.Location = new Point(913, 183);
            BtnFuncionG.Name = "BtnFuncionG";
            BtnFuncionG.Size = new Size(145, 61);
            BtnFuncionG.TabIndex = 3;
            BtnFuncionG.Text = "Funcion-->G";
            BtnFuncionG.UseVisualStyleBackColor = false;
            BtnFuncionG.Click += BtnFuncionG_Click;
            // 
            // dataGridResultados
            // 
            dataGridResultados.AllowUserToAddRows = false;
            dataGridResultados.AllowUserToDeleteRows = false;
            dataGridResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridResultados.BackgroundColor = Color.FromArgb(29, 35, 51);
            dataGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultados.Location = new Point(82, 334);
            dataGridResultados.MultiSelect = false;
            dataGridResultados.Name = "dataGridResultados";
            dataGridResultados.ReadOnly = true;
            dataGridResultados.RowHeadersVisible = false;
            dataGridResultados.RowHeadersWidth = 51;
            dataGridResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResultados.Size = new Size(808, 249);
            dataGridResultados.TabIndex = 5;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(64, 79, 118);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(611, 201);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(132, 43);
            BtnLimpiar.TabIndex = 6;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            LblMin.ForeColor = Color.FromArgb(12, 157, 111);
            LblMin.Location = new Point(43, 223);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(122, 21);
            LblMin.TabIndex = 7;
            LblMin.Text = "Valor Minimo :";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            LblMax.ForeColor = Color.FromArgb(12, 157, 111);
            LblMax.Location = new Point(43, 187);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(125, 21);
            LblMax.TabIndex = 8;
            LblMax.Text = "Valor Maximo :";
            // 
            // TabulacionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(LblMax);
            Controls.Add(LblMin);
            Controls.Add(BtnLimpiar);
            Controls.Add(dataGridResultados);
            Controls.Add(BtnFuncionG);
            Controls.Add(BtnFuncionF);
            Controls.Add(BtnRegresar);
            Controls.Add(label1);
            Name = "TabulacionControl";
            Size = new Size(1093, 682);
            Load += TabulacionControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnRegresar;
        private Button BtnFuncionF;
        private Button BtnFuncionG;
        private DataGridView dataGridResultados;
        private Button BtnLimpiar;
        private Label LblMin;
        private Label LblMax;
    }
}
