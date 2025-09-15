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
            txtValorMax = new TextBox();
            BtnLimpiar = new Button();
            BtnResultados = new Button();
            panel1 = new Panel();
            dataGridResultados = new DataGridView();
            lblValorInicial = new Label();
            LblValorFinal = new Label();
            txtValor_i = new TextBox();
            txtValor_f = new TextBox();
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
            // txtValorMax
            // 
            txtValorMax.BackColor = Color.FromArgb(29, 35, 51);
            txtValorMax.BorderStyle = BorderStyle.None;
            txtValorMax.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValorMax.ForeColor = Color.White;
            txtValorMax.Location = new Point(393, 156);
            txtValorMax.Name = "txtValorMax";
            txtValorMax.Size = new Size(184, 20);
            txtValorMax.TabIndex = 19;
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
            // txtValor_i
            // 
            txtValor_i.BackColor = Color.FromArgb(29, 35, 51);
            txtValor_i.BorderStyle = BorderStyle.None;
            txtValor_i.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValor_i.ForeColor = Color.White;
            txtValor_i.Location = new Point(39, 151);
            txtValor_i.Name = "txtValor_i";
            txtValor_i.Size = new Size(260, 20);
            txtValor_i.TabIndex = 13;
            // 
            // txtValor_f
            // 
            txtValor_f.BackColor = Color.FromArgb(29, 35, 51);
            txtValor_f.BorderStyle = BorderStyle.None;
            txtValor_f.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            txtValor_f.ForeColor = Color.White;
            txtValor_f.Location = new Point(40, 218);
            txtValor_f.Name = "txtValor_f";
            txtValor_f.Size = new Size(259, 20);
            txtValor_f.TabIndex = 12;
            // 
            // MetodoReglaFalsaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(label1);
            Controls.Add(LblValorMax);
            Controls.Add(txtValorMax);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnResultados);
            Controls.Add(panel1);
            Controls.Add(lblValorInicial);
            Controls.Add(LblValorFinal);
            Controls.Add(txtValor_i);
            Controls.Add(txtValor_f);
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
        private TextBox txtValorMax;
        private TextBox txtValor_i;
        private TextBox txtValor_f;
    }
}
