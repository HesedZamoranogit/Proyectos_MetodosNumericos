namespace Proyecto_MetodosNumericos.Formularios.RaicesFunciones
{
    partial class MetodoReglaFalsaControl
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
            BtnResultados = new Button();
            panel1 = new Panel();
            dataGridResultados = new DataGridView();
            lblValorInicial = new Label();
            LblValorFinal = new Label();
            txtXi = new TextBox();
            txtXf = new TextBox();
            label2 = new Label();
            txtFuncion = new TextBox();
            txtEjemplo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(13, 14);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(186, 48);
            BtnRegresar.TabIndex = 0;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(838, 25);
            label1.Name = "label1";
            label1.Size = new Size(405, 62);
            label1.TabIndex = 21;
            label1.Text = "METODO REGLA FALSA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblValorMax
            // 
            LblValorMax.AutoSize = true;
            LblValorMax.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorMax.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorMax.Location = new Point(393, 128);
            LblValorMax.Name = "LblValorMax";
            LblValorMax.Size = new Size(138, 25);
            LblValorMax.TabIndex = 20;
            LblValorMax.Text = "Valor Maximo";
            // 
            // txtEa
            // 
            txtEa.BackColor = Color.FromArgb(29, 35, 51);
            txtEa.BorderStyle = BorderStyle.None;
            txtEa.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEa.ForeColor = Color.White;
            txtEa.Location = new Point(393, 156);
            txtEa.Name = "txtEa";
            txtEa.Size = new Size(184, 20);
            txtEa.TabIndex = 19;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(464, 205);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(130, 50);
            BtnLimpiar.TabIndex = 18;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnResultados
            // 
            BtnResultados.BackColor = Color.FromArgb(29, 35, 51);
            BtnResultados.FlatStyle = FlatStyle.Flat;
            BtnResultados.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnResultados.ForeColor = Color.FromArgb(12, 157, 111);
            BtnResultados.Location = new Point(630, 205);
            BtnResultados.Name = "BtnResultados";
            BtnResultados.Size = new Size(192, 50);
            BtnResultados.TabIndex = 17;
            BtnResultados.Text = "Resultados";
            BtnResultados.UseVisualStyleBackColor = false;
            BtnResultados.Click += BtnResultados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 35, 51);
            panel1.Controls.Add(dataGridResultados);
            panel1.Location = new Point(39, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 435);
            panel1.TabIndex = 16;
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
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            lblValorInicial.ForeColor = Color.FromArgb(12, 157, 111);
            lblValorInicial.Location = new Point(40, 123);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new Size(121, 25);
            lblValorInicial.TabIndex = 15;
            lblValorInicial.Text = "Valor Inicial";
            // 
            // LblValorFinal
            // 
            LblValorFinal.AutoSize = true;
            LblValorFinal.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            LblValorFinal.ForeColor = Color.FromArgb(12, 157, 111);
            LblValorFinal.Location = new Point(39, 190);
            LblValorFinal.Name = "LblValorFinal";
            LblValorFinal.Size = new Size(111, 25);
            LblValorFinal.TabIndex = 14;
            LblValorFinal.Text = "Valor Final";
            // 
            // txtXi
            // 
            txtXi.BackColor = Color.FromArgb(29, 35, 51);
            txtXi.BorderStyle = BorderStyle.None;
            txtXi.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtXi.ForeColor = Color.White;
            txtXi.Location = new Point(39, 151);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(260, 20);
            txtXi.TabIndex = 13;
            // 
            // txtXf
            // 
            txtXf.BackColor = Color.FromArgb(29, 35, 51);
            txtXf.BorderStyle = BorderStyle.None;
            txtXf.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtXf.ForeColor = Color.White;
            txtXf.Location = new Point(40, 218);
            txtXf.Name = "txtXf";
            txtXf.Size = new Size(259, 20);
            txtXf.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(695, 128);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 23;
            label2.Text = "Funcion";
            // 
            // txtFuncion
            // 
            txtFuncion.BackColor = Color.FromArgb(29, 35, 51);
            txtFuncion.BorderStyle = BorderStyle.None;
            txtFuncion.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtFuncion.ForeColor = Color.White;
            txtFuncion.Location = new Point(695, 156);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(393, 20);
            txtFuncion.TabIndex = 22;
            // 
            // txtEjemplo
            // 
            txtEjemplo.BackColor = Color.FromArgb(29, 35, 51);
            txtEjemplo.BorderStyle = BorderStyle.None;
            txtEjemplo.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtEjemplo.ForeColor = Color.Red;
            txtEjemplo.Location = new Point(805, 123);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(329, 20);
            txtEjemplo.TabIndex = 24;
            txtEjemplo.Text = "Ejemplo: x^2*Sqrt(Abs(Cos(x)))-5";
            // 
            // MetodoReglaFalsaControl
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
            Name = "MetodoReglaFalsaControl";
            Size = new Size(1243, 729);
            Load += MetodoReglaFalsaControl_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private Label label1;
        private Label LblValorMax;
        private TextBox textBox3;
        private Button BtnLimpiar;
        private Button BtnResultados;
        private Panel panel1;
        private DataGridView dataGridResultados;
        private Label lblValorInicial;
        private Label LblValorFinal;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtEa;
        private TextBox txtXi;
        private TextBox txtXf;
        private Label label2;
        private TextBox txtFuncion;
        private TextBox txtEjemplo;
    }
}
