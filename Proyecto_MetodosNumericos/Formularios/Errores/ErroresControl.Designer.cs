namespace Proyecto_MetodosNumericos.Formularios.Errores
{
    partial class ErroresControl
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
            label2 = new Label();
            label3 = new Label();
            txtVr = new TextBox();
            txtVa = new TextBox();
            txtEa = new TextBox();
            txtEr = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panelFondo = new Panel();
            BtnLimpiar = new Button();
            BtnResultados = new Button();
            panelFondo.SuspendLayout();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(29, 35, 51);
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnRegresar.Location = new Point(3, 3);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(117, 48);
            BtnRegresar.TabIndex = 2;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 35, 51);
            label1.Font = new Font("HP Simplified Jpan", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 157, 111);
            label1.Location = new Point(3, 66);
            label1.Name = "label1";
            label1.Size = new Size(1222, 62);
            label1.TabIndex = 3;
            label1.Text = "PROYECTO ERRORES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 157, 111);
            label2.Location = new Point(133, 40);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 4;
            label2.Text = "Valor Real";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 157, 111);
            label3.Location = new Point(133, 128);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Valor Aproximado";
            // 
            // txtVr
            // 
            txtVr.BorderStyle = BorderStyle.None;
            txtVr.Cursor = Cursors.IBeam;
            txtVr.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtVr.Location = new Point(133, 84);
            txtVr.Multiline = true;
            txtVr.Name = "txtVr";
            txtVr.Size = new Size(268, 27);
            txtVr.TabIndex = 6;
            txtVr.TextChanged += txtVr_TextChanged;
            // 
            // txtVa
            // 
            txtVa.BorderStyle = BorderStyle.None;
            txtVa.Cursor = Cursors.IBeam;
            txtVa.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtVa.Location = new Point(133, 172);
            txtVa.Multiline = true;
            txtVa.Name = "txtVa";
            txtVa.Size = new Size(268, 27);
            txtVa.TabIndex = 7;
            txtVa.TextChanged += txtVa_TextChanged;
            // 
            // txtEa
            // 
            txtEa.BorderStyle = BorderStyle.None;
            txtEa.Enabled = false;
            txtEa.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtEa.Location = new Point(133, 308);
            txtEa.Multiline = true;
            txtEa.Name = "txtEa";
            txtEa.Size = new Size(268, 27);
            txtEa.TabIndex = 8;
            // 
            // txtEr
            // 
            txtEr.BorderStyle = BorderStyle.None;
            txtEr.Enabled = false;
            txtEr.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtEr.Location = new Point(471, 308);
            txtEr.Multiline = true;
            txtEr.Name = "txtEr";
            txtEr.Size = new Size(268, 27);
            txtEr.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(110, 79, 148);
            label4.Location = new Point(471, 257);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 11;
            label4.Text = "Error Relativo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(110, 79, 148);
            label5.Location = new Point(133, 257);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 10;
            label5.Text = "Error Absoluto";
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(29, 35, 51);
            panelFondo.Controls.Add(BtnLimpiar);
            panelFondo.Controls.Add(BtnResultados);
            panelFondo.Controls.Add(label2);
            panelFondo.Controls.Add(label4);
            panelFondo.Controls.Add(label3);
            panelFondo.Controls.Add(label5);
            panelFondo.Controls.Add(txtVr);
            panelFondo.Controls.Add(txtEr);
            panelFondo.Controls.Add(txtVa);
            panelFondo.Controls.Add(txtEa);
            panelFondo.Location = new Point(174, 180);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(871, 469);
            panelFondo.TabIndex = 12;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(29, 35, 51);
            BtnLimpiar.Cursor = Cursors.Hand;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.FromArgb(12, 157, 111);
            BtnLimpiar.Location = new Point(641, 128);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(132, 43);
            BtnLimpiar.TabIndex = 13;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnResultados
            // 
            BtnResultados.AutoSize = true;
            BtnResultados.BackColor = Color.FromArgb(29, 35, 51);
            BtnResultados.Cursor = Cursors.Hand;
            BtnResultados.FlatStyle = FlatStyle.Flat;
            BtnResultados.Font = new Font("HP Simplified Jpan", 12F, FontStyle.Bold);
            BtnResultados.ForeColor = Color.FromArgb(12, 157, 111);
            BtnResultados.Location = new Point(628, 50);
            BtnResultados.Name = "BtnResultados";
            BtnResultados.Size = new Size(145, 61);
            BtnResultados.TabIndex = 12;
            BtnResultados.Text = "Resultados";
            BtnResultados.UseVisualStyleBackColor = false;
            BtnResultados.Click += BtnResultados_Click;
            // 
            // ErroresControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(panelFondo);
            Controls.Add(label1);
            Controls.Add(BtnRegresar);
            Name = "ErroresControl";
            Size = new Size(1225, 686);
            Load += ErroresControl_Load;
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVr;
        private TextBox txtVa;
        private TextBox txtEa;
        private TextBox txtEr;
        private Label label4;
        private Label label5;
        private Panel panelFondo;
        private Button BtnResultados;
        private Button BtnLimpiar;
    }
}
