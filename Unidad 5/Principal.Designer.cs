namespace Unidad_5
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnMetodos = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            LblTitulo = new Label();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMetodos
            // 
            btnMetodos.BackColor = Color.FromArgb(29, 35, 51);
            btnMetodos.ForeColor = Color.FromArgb(12, 157, 111);
            btnMetodos.Location = new Point(515, 314);
            btnMetodos.Name = "btnMetodos";
            btnMetodos.Size = new Size(235, 62);
            btnMetodos.TabIndex = 47;
            btnMetodos.Text = "Interpolacion de Larange";
            btnMetodos.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1072, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.FromArgb(29, 35, 51);
            LblTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.FromArgb(12, 157, 111);
            LblTitulo.Location = new Point(-6, 54);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1231, 67);
            LblTitulo.TabIndex = 44;
            LblTitulo.Text = "PROYECTOS METODOS NUMERICOS\r\nUNIDAD 5";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(-6, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1237, 683);
            panelContenedor.TabIndex = 48;
            panelContenedor.Visible = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            ClientSize = new Size(1225, 682);
            Controls.Add(panelContenedor);
            Controls.Add(btnMetodos);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(LblTitulo);
            Name = "Principal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMetodos;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label LblTitulo;
        private Panel panelContenedor;
    }
}
