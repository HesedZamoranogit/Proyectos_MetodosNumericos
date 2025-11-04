
namespace Unidad4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            LblTitulo = new Label();
            btnMetodos = new Button();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1060, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.FromArgb(29, 35, 51);
            LblTitulo.Font = new Font("HP Simplified", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.FromArgb(12, 157, 111);
            LblTitulo.Location = new Point(-18, 45);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1231, 67);
            LblTitulo.TabIndex = 40;
            LblTitulo.Text = "PROYECTOS METODOS NUMERICOS\r\nUNIDAD 4";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMetodos
            // 
            btnMetodos.Location = new Point(503, 305);
            btnMetodos.Name = "btnMetodos";
            btnMetodos.Size = new Size(235, 62);
            btnMetodos.TabIndex = 43;
            btnMetodos.Text = "METODOS MINIMOS CUADRADOS";
            btnMetodos.UseVisualStyleBackColor = true;
            btnMetodos.Click += btnMetodos_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(-4, -4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1229, 689);
            panelContenedor.TabIndex = 44;
            panelContenedor.Visible = false;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Form1
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
            Name = "Form1";
            Text = "Unidad4";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label LblTitulo;
        private Button btnMetodos;
        private Panel panelContenedor;
    }
}
