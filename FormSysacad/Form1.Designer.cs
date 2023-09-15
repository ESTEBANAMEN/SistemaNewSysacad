namespace FormSysacad
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSeleccionDeUsuario = new Button();
            panelNegro = new Panel();
            TituloDelPrograma = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelNegroDerecha = new Panel();
            panelNegroIzquierda = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelSeleccionDeUsuario = new Label();
            labelDeIdentificador = new Label();
            textBoxIdentificador = new TextBox();
            labelContraseña = new Label();
            textBoxContraseña = new TextBox();
            buttonDeIngreso = new Button();
            panelInferior = new Panel();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSeleccionDeUsuario
            // 
            buttonSeleccionDeUsuario.Anchor = AnchorStyles.Top;
            buttonSeleccionDeUsuario.AutoSize = true;
            buttonSeleccionDeUsuario.BackgroundImageLayout = ImageLayout.None;
            buttonSeleccionDeUsuario.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeleccionDeUsuario.Location = new Point(377, 149);
            buttonSeleccionDeUsuario.Name = "buttonSeleccionDeUsuario";
            buttonSeleccionDeUsuario.Size = new Size(417, 33);
            buttonSeleccionDeUsuario.TabIndex = 0;
            buttonSeleccionDeUsuario.Text = "Usuario ▼";
            buttonSeleccionDeUsuario.UseVisualStyleBackColor = true;
            buttonSeleccionDeUsuario.Click += button1_Click;
            // 
            // panelNegro
            // 
            panelNegro.BackColor = Color.FromArgb(64, 64, 64);
            panelNegro.Controls.Add(TituloDelPrograma);
            panelNegro.Dock = DockStyle.Top;
            panelNegro.Location = new Point(0, 0);
            panelNegro.Name = "panelNegro";
            panelNegro.Size = new Size(1217, 85);
            panelNegro.TabIndex = 1;
            panelNegro.Paint += panelNegro_Paint;
            // 
            // TituloDelPrograma
            // 
            TituloDelPrograma.Anchor = AnchorStyles.None;
            TituloDelPrograma.AutoSize = true;
            TituloDelPrograma.BackColor = Color.White;
            TituloDelPrograma.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            TituloDelPrograma.ForeColor = Color.OrangeRed;
            TituloDelPrograma.Location = new Point(351, 9);
            TituloDelPrograma.Name = "TituloDelPrograma";
            TituloDelPrograma.Size = new Size(491, 59);
            TituloDelPrograma.TabIndex = 0;
            TituloDelPrograma.Text = "NUEVO SISTEMA SYSACAD\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(801, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelNegroDerecha
            // 
            panelNegroDerecha.BackColor = Color.FromArgb(64, 64, 64);
            panelNegroDerecha.Dock = DockStyle.Right;
            panelNegroDerecha.Location = new Point(1202, 85);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 499);
            panelNegroDerecha.TabIndex = 2;
            // 
            // panelNegroIzquierda
            // 
            panelNegroIzquierda.BackColor = Color.FromArgb(64, 64, 64);
            panelNegroIzquierda.Dock = DockStyle.Left;
            panelNegroIzquierda.Location = new Point(0, 85);
            panelNegroIzquierda.Name = "panelNegroIzquierda";
            panelNegroIzquierda.Size = new Size(15, 499);
            panelNegroIzquierda.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelSeleccionDeUsuario
            // 
            labelSeleccionDeUsuario.Anchor = AnchorStyles.Top;
            labelSeleccionDeUsuario.AutoSize = true;
            labelSeleccionDeUsuario.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionDeUsuario.Location = new Point(377, 108);
            labelSeleccionDeUsuario.Name = "labelSeleccionDeUsuario";
            labelSeleccionDeUsuario.Size = new Size(420, 24);
            labelSeleccionDeUsuario.TabIndex = 5;
            labelSeleccionDeUsuario.Text = "Seleccione el tipo de usuario correspondiente:";
            labelSeleccionDeUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelDeIdentificador
            // 
            labelDeIdentificador.Anchor = AnchorStyles.Top;
            labelDeIdentificador.AutoSize = true;
            labelDeIdentificador.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeIdentificador.Location = new Point(377, 272);
            labelDeIdentificador.Name = "labelDeIdentificador";
            labelDeIdentificador.Size = new Size(132, 24);
            labelDeIdentificador.TabIndex = 6;
            labelDeIdentificador.Text = "Identificador:";
            labelDeIdentificador.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxIdentificador
            // 
            textBoxIdentificador.Anchor = AnchorStyles.None;
            textBoxIdentificador.Location = new Point(377, 315);
            textBoxIdentificador.Name = "textBoxIdentificador";
            textBoxIdentificador.Size = new Size(417, 27);
            textBoxIdentificador.TabIndex = 7;
            // 
            // labelContraseña
            // 
            labelContraseña.Anchor = AnchorStyles.Top;
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.Location = new Point(377, 351);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(118, 24);
            labelContraseña.TabIndex = 8;
            labelContraseña.Text = "Contraseña:";
            labelContraseña.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Anchor = AnchorStyles.None;
            textBoxContraseña.Location = new Point(377, 393);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(417, 27);
            textBoxContraseña.TabIndex = 9;
            // 
            // buttonDeIngreso
            // 
            buttonDeIngreso.Anchor = AnchorStyles.None;
            buttonDeIngreso.AutoSize = true;
            buttonDeIngreso.Location = new Point(377, 450);
            buttonDeIngreso.Name = "buttonDeIngreso";
            buttonDeIngreso.Size = new Size(417, 86);
            buttonDeIngreso.TabIndex = 10;
            buttonDeIngreso.Text = "Corroborar datos e ingresar";
            buttonDeIngreso.UseVisualStyleBackColor = true;
            // 
            // panelInferior
            // 
            panelInferior.AutoScroll = true;
            panelInferior.BackColor = Color.FromArgb(64, 64, 64);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(15, 569);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1187, 15);
            panelInferior.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1217, 584);
            Controls.Add(panelInferior);
            Controls.Add(buttonDeIngreso);
            Controls.Add(textBoxContraseña);
            Controls.Add(labelContraseña);
            Controls.Add(textBoxIdentificador);
            Controls.Add(labelDeIdentificador);
            Controls.Add(labelSeleccionDeUsuario);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(panelNegro);
            Controls.Add(buttonSeleccionDeUsuario);
            Name = "Form1";
            Text = "Form1";
            panelNegro.ResumeLayout(false);
            panelNegro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSeleccionDeUsuario;
        private Panel panelNegro;
        private Panel panelNegroDerecha;
        private Panel panelNegroIzquierda;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox2;
        private Label labelSeleccionDeUsuario;
        private Label labelDeIdentificador;
        private TextBox textBoxIdentificador;
        private Label labelContraseña;
        private TextBox textBoxContraseña;
        private Button buttonDeIngreso;
        private Panel panelInferior;
        private Label TituloDelPrograma;
    }
}