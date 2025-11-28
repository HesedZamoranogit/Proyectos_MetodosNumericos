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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 15);
            button1.Name = "button1";
            button1.Size = new Size(154, 48);
            button1.TabIndex = 0;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Interpolacion_Larange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            Controls.Add(button1);
            Name = "Interpolacion_Larange";
            Size = new Size(1243, 729);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
