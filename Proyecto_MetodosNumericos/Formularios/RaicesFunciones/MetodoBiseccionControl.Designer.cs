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
            txtXf = new TextBox();
            txtXi = new TextBox();
            LblValorFinal = new Label();
            lblValorInicial = new Label();
            dataGridResultados = new DataGridView();
            panel1 = new Panel();
            BtnResultados = new Button();
            BtnLimpiar = new Button();
            txtEa = new TextBox();
            LblValorMax = new Label();
            label1 = new Label();
            label2 = new Label();
            txtFuncion = new TextBox();
            txtEjemplo = new TextBox();
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
            // txtXf
            // 
            txtXf.BackColor = Color.FromArgb(29, 35, 51);
            txtXf.BorderStyle = BorderStyle.None;
            txtXf.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtXf.ForeColor = Color.White;
            txtXf.Location = new Point(40, 226);
            txtXf.Name = "txtXf";
            txtXf.Size = new Size(259, 20);
            txtXf.TabIndex = 1;
            // 
            // txtXi
            // 
            txtXi.BackColor = Color.FromArgb(29, 35, 51);
            txtXi.BorderStyle = BorderStyle.None;
            txtXi.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtXi.ForeColor = Color.White;
            txtXi.Location = new Point(39, 159);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(260, 20);
            txtXi.TabIndex = 2;
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
            BtnResultados.Click += BtnResultados_Click;
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
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // txtEa
            // 
            txtEa.BackColor = Color.FromArgb(29, 35, 51);
            txtEa.BorderStyle = BorderStyle.None;
            txtEa.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEa.ForeColor = Color.White;
            txtEa.Location = new Point(393, 164);
            txtEa.Name = "txtEa";
            txtEa.Size = new Size(184, 20);
            txtEa.TabIndex = 9;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(696, 136);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 13;
            label2.Text = "Funcion";
            // 
            // txtFuncion
            // 
            txtFuncion.BackColor = Color.FromArgb(29, 35, 51);
            txtFuncion.BorderStyle = BorderStyle.None;
            txtFuncion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtFuncion.ForeColor = Color.White;
            txtFuncion.Location = new Point(696, 164);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(404, 20);
            txtFuncion.TabIndex = 12;
            // 
            // txtEjemplo
            // 
            txtEjemplo.BackColor = Color.FromArgb(46, 60, 84);
            txtEjemplo.BorderStyle = BorderStyle.None;
            txtEjemplo.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEjemplo.ForeColor = Color.Crimson;
            txtEjemplo.Location = new Point(799, 136);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(314, 20);
            txtEjemplo.TabIndex = 15;
            txtEjemplo.Text = "Ejemplo: 4x^3 - 6x^2 + 7x - 2.3";
            // 
            // MetodoBiseccionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(txtEjemplo);
            Controls.Add(label2);
            Controls.Add(txtFuncion);
            Controls.Add(label1);
            Controls.Add(LblValorMax);
            Controls.Add(txtEa);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnResultados);
            Controls.Add(panel1);
            Controls.Add(lblValorInicial);
            Controls.Add(LblValorFinal);
            Controls.Add(txtXi);
            Controls.Add(txtXf);
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
        private TextBox txtEa;
        private TextBox txtXf;
        private TextBox txtXi;
        private Label label2;
        private TextBox txtFuncion;
        private TextBox txtEjemplo;
    }
}
