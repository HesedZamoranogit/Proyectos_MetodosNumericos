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
            panelContenedor = new Panel();
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
            BtnRegresar.Size = new Size(117, 48);
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
            label1.Location = new Point(0, 75);
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
            BtnBiseccion.Location = new Point(266, 305);
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
            BtnRFalsa.Location = new Point(736, 305);
            BtnRFalsa.Name = "BtnRFalsa";
            BtnRFalsa.Size = new Size(231, 58);
            BtnRFalsa.TabIndex = 6;
            BtnRFalsa.Text = "Metodo Regla Falsa";
            BtnRFalsa.UseVisualStyleBackColor = false;
            BtnRFalsa.Click += BtnRFalsa_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1243, 729);
            panelContenedor.TabIndex = 7;
            panelContenedor.Visible = false;
            // 
            // RaicesFuncionesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(panelContenedor);
            Controls.Add(BtnRFalsa);
            Controls.Add(BtnBiseccion);
            Controls.Add(label1);
            Controls.Add(BtnRegresar);
            Name = "RaicesFuncionesControl";
            Size = new Size(1243, 729);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegresar;
        private Label label1;
        private Button BtnBiseccion;
        private Button BtnRFalsa;
        private Panel panelContenedor;
    }
}
