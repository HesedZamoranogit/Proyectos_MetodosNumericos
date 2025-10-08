namespace Proyecto_MetodosNumericos
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            BtnProximamente4 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnProximamente3 = new Button();
            BtnGauss_Jordan = new Button();
            BtnGauss = new Button();
            pictureBox2 = new PictureBox();
            LblTitulo = new Label();
            button1 = new Button();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnProximamente4
            // 
            BtnProximamente4.Enabled = false;
            BtnProximamente4.FlatStyle = FlatStyle.Flat;
            BtnProximamente4.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            BtnProximamente4.ForeColor = Color.FromArgb(12, 157, 111);
            BtnProximamente4.Location = new Point(508, 415);
            BtnProximamente4.Name = "BtnProximamente4";
            BtnProximamente4.Size = new Size(221, 51);
            BtnProximamente4.TabIndex = 40;
            BtnProximamente4.Text = "...";
            BtnProximamente4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1078, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 524);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // BtnProximamente3
            // 
            BtnProximamente3.Enabled = false;
            BtnProximamente3.FlatStyle = FlatStyle.Flat;
            BtnProximamente3.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            BtnProximamente3.ForeColor = Color.FromArgb(12, 157, 111);
            BtnProximamente3.Location = new Point(911, 319);
            BtnProximamente3.Name = "BtnProximamente3";
            BtnProximamente3.Size = new Size(221, 51);
            BtnProximamente3.TabIndex = 37;
            BtnProximamente3.Text = "...";
            BtnProximamente3.UseVisualStyleBackColor = true;
            // 
            // BtnGauss_Jordan
            // 
            BtnGauss_Jordan.Cursor = Cursors.Hand;
            BtnGauss_Jordan.Enabled = false;
            BtnGauss_Jordan.FlatStyle = FlatStyle.Flat;
            BtnGauss_Jordan.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            BtnGauss_Jordan.ForeColor = Color.FromArgb(12, 157, 111);
            BtnGauss_Jordan.Location = new Point(381, 319);
            BtnGauss_Jordan.Name = "BtnGauss_Jordan";
            BtnGauss_Jordan.Size = new Size(240, 51);
            BtnGauss_Jordan.TabIndex = 35;
            BtnGauss_Jordan.Text = "...";
            BtnGauss_Jordan.UseVisualStyleBackColor = true;
            // 
            // BtnGauss
            // 
            BtnGauss.Cursor = Cursors.Hand;
            BtnGauss.FlatStyle = FlatStyle.Flat;
            BtnGauss.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGauss.ForeColor = Color.FromArgb(12, 157, 111);
            BtnGauss.Location = new Point(114, 319);
            BtnGauss.Name = "BtnGauss";
            BtnGauss.Size = new Size(221, 51);
            BtnGauss.TabIndex = 34;
            BtnGauss.Text = "Metodo de Gauss/Jordan";
            BtnGauss.UseVisualStyleBackColor = true;
            BtnGauss.Click += BtnGauss_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.FromArgb(29, 35, 51);
            LblTitulo.Font = new Font("HP Simplified", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.FromArgb(12, 157, 111);
            LblTitulo.Location = new Point(0, 81);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1231, 67);
            LblTitulo.TabIndex = 32;
            LblTitulo.Text = "PROYECTOS METODOS NUMERICOS\r\nUNIDAD 2\r\n";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified Jpan", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(12, 157, 111);
            button1.Location = new Point(659, 319);
            button1.Name = "button1";
            button1.Size = new Size(221, 51);
            button1.TabIndex = 42;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(-9, -5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1240, 687);
            panelContenedor.TabIndex = 43;
            panelContenedor.Visible = false;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 60, 84);
            ClientSize = new Size(1225, 682);
            Controls.Add(panelContenedor);
            Controls.Add(button1);
            Controls.Add(BtnProximamente4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(BtnProximamente3);
            Controls.Add(BtnGauss_Jordan);
            Controls.Add(BtnGauss);
            Controls.Add(pictureBox2);
            Controls.Add(LblTitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto";
            Load += FormMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProximamente4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button BtnProximamente3;
        private Button BtnGauss_Jordan;
        private Button BtnGauss;
        private PictureBox pictureBox2;
        private Label LblTitulo;
        private Button button1;
        private Panel panelContenedor;
    }
}
