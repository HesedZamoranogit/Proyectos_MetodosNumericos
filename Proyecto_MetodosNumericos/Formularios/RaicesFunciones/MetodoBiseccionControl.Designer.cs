namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    partial class MetodoBiseccionControl
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
            txtValor_f = new TextBox();
            txtValor_i = new TextBox();
            LblValorFinal = new Label();
            lblValorInicial = new Label();
            dataGridResultados = new DataGridView();
            panel1 = new Panel();
            BtnResultados = new Button();
            BtnLimpiar = new Button();
            txtValorMx = new TextBox();
            LblValorMax = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            panel1.SuspendLayout();
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
            BtnRegresar.Size = new Size(183, 57);
            BtnRegresar.TabIndex = 0;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // txtValor_f
            // 
            txtValor_f.BackColor = Color.FromArgb(29, 35, 51);
            txtValor_f.BorderStyle = BorderStyle.None;
            txtValor_f.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValor_f.ForeColor = Color.White;
            txtValor_f.Location = new Point(40, 226);
            txtValor_f.Name = "txtValor_f";
            txtValor_f.Size = new Size(259, 20);
            txtValor_f.TabIndex = 1;
            // 
            // txtValor_i
            // 
            txtValor_i.BackColor = Color.FromArgb(29, 35, 51);
            txtValor_i.BorderStyle = BorderStyle.None;
            txtValor_i.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValor_i.ForeColor = Color.White;
            txtValor_i.Location = new Point(39, 159);
            txtValor_i.Name = "txtValor_i";
            txtValor_i.Size = new Size(260, 20);
            txtValor_i.TabIndex = 2;
            // 
            // LblValorFinal
            // 
            LblValorFinal.AutoSize = true;
            LblValorFinal.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorFinal.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorFinal.Location = new Point(39, 198);
            LblValorFinal.Name = "LblValorFinal";
            LblValorFinal.Size = new Size(111, 25);
            LblValorFinal.TabIndex = 3;
            LblValorFinal.Text = "Valor Final";
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            lblValorInicial.ForeColor = Color.FromArgb(12, 157, 111);
            lblValorInicial.Location = new Point(40, 131);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new Size(121, 25);
            lblValorInicial.TabIndex = 4;
            lblValorInicial.Text = "Valor Inicial";
            // 
            // dataGridResultados
            // 
            dataGridResultados.BackgroundColor = Color.FromArgb(46, 60, 84);
            dataGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultados.Location = new Point(19, 24);
            dataGridResultados.Name = "dataGridResultados";
            dataGridResultados.RowHeadersWidth = 51;
            dataGridResultados.Size = new Size(1122, 384);
            dataGridResultados.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 35, 51);
            panel1.Controls.Add(dataGridResultados);
            panel1.Location = new Point(39, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 435);
            panel1.TabIndex = 6;
            // 
            // BtnResultados
            // 
            BtnResultados.BackColor = Color.FromArgb(29, 35, 51);
            BtnResultados.FlatStyle = FlatStyle.Flat;
            BtnResultados.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnResultados.ForeColor = Color.FromArgb(12, 157, 111);
            BtnResultados.Location = new Point(647, 213);
            BtnResultados.Name = "BtnResultados";
            BtnResultados.Size = new Size(192, 50);
            BtnResultados.TabIndex = 7;
            BtnResultados.Text = "Resultados";
            BtnResultados.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(464, 213);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(130, 50);
            BtnLimpiar.TabIndex = 8;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtValorMx
            // 
            txtValorMx.BackColor = Color.FromArgb(29, 35, 51);
            txtValorMx.BorderStyle = BorderStyle.None;
            txtValorMx.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValorMx.ForeColor = Color.White;
            txtValorMx.Location = new Point(393, 164);
            txtValorMx.Name = "txtValorMx";
            txtValorMx.Size = new Size(184, 20);
            txtValorMx.TabIndex = 9;
            // 
            // LblValorMax
            // 
            LblValorMax.AutoSize = true;
            LblValorMax.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorMax.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorMax.Location = new Point(393, 136);
            LblValorMax.Name = "LblValorMax";
            LblValorMax.Size = new Size(138, 25);
            LblValorMax.TabIndex = 10;
            LblValorMax.Text = "Valor Maximo";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(838, 33);
            label1.Name = "label1";
            label1.Size = new Size(405, 62);
            label1.TabIndex = 11;
            label1.Text = "METODO BISECCION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MetodoBiseccionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(label1);
            Controls.Add(LblValorMax);
            Controls.Add(txtValorMx);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnResultados);
            Controls.Add(panel1);
            Controls.Add(lblValorInicial);
            Controls.Add(LblValorFinal);
            Controls.Add(txtValor_i);
            Controls.Add(txtValor_f);
            Controls.Add(BtnRegresar);
            Name = "MetodoBiseccionControl";
            Size = new Size(1243, 729);
            Load += MetodoBiseccionControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LblValorFinal;
        private Label lblValorInicial;
        private DataGridView dataGridResultados;
        private Panel panel1;
        private Button BtnResultados;
        private Button BtnLimpiar;
        private TextBox textBox3;
        private Label LblValorMax;
        private Label label1;
        private TextBox txtValorMx;
        private TextBox txtValor_f;
        private TextBox txtValor_i;
    }
}
