namespace FormSysacad
{
    partial class FormPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrograma));
            buttonSeleccionDeUsuario = new Button();
            panelNegro = new Panel();
            TituloDelPrograma = new Label();
            imagenUTNFraUno = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelNegroDerecha = new Panel();
            panelNegroIzquierda = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelSeleccionDeUsuario = new Label();
            labelLegajo = new Label();
            textBoxLegajo = new TextBox();
            labelContraseña = new Label();
            textBoxContrasenia = new TextBox();
            buttonDeIngreso = new Button();
            panelInferior = new Panel();
            panelMenuDeUsuarios = new Panel();
            buttonEstudiante = new Button();
            buttonAdministrador = new Button();
            buttonProfesor = new Button();
            labelErrorIdContra = new Label();
            pictureBoxUtnavellaneda = new PictureBox();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenuDeUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).BeginInit();
            SuspendLayout();
            // 
            // buttonSeleccionDeUsuario
            // 
            buttonSeleccionDeUsuario.Anchor = AnchorStyles.None;
            buttonSeleccionDeUsuario.AutoSize = true;
            buttonSeleccionDeUsuario.BackgroundImageLayout = ImageLayout.None;
            buttonSeleccionDeUsuario.Cursor = Cursors.Hand;
            buttonSeleccionDeUsuario.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeleccionDeUsuario.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeleccionDeUsuario.Location = new Point(468, 137);
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
            panelNegro.Controls.Add(imagenUTNFraUno);
            panelNegro.Dock = DockStyle.Top;
            panelNegro.Location = new Point(15, 0);
            panelNegro.Name = "panelNegro";
            panelNegro.Size = new Size(1320, 85);
            panelNegro.TabIndex = 1;
            // 
            // TituloDelPrograma
            // 
            TituloDelPrograma.Anchor = AnchorStyles.None;
            TituloDelPrograma.AutoSize = true;
            TituloDelPrograma.BackColor = Color.White;
            TituloDelPrograma.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            TituloDelPrograma.ForeColor = Color.OrangeRed;
            TituloDelPrograma.Location = new Point(411, 9);
            TituloDelPrograma.Name = "TituloDelPrograma";
            TituloDelPrograma.Size = new Size(491, 59);
            TituloDelPrograma.TabIndex = 0;
            TituloDelPrograma.Text = "NUEVO SISTEMA SYSACAD\r\n";
            // 
            // imagenUTNFraUno
            // 
            imagenUTNFraUno.Image = (Image)resources.GetObject("imagenUTNFraUno.Image");
            imagenUTNFraUno.Location = new Point(0, 3);
            imagenUTNFraUno.Name = "imagenUTNFraUno";
            imagenUTNFraUno.Size = new Size(99, 79);
            imagenUTNFraUno.SizeMode = PictureBoxSizeMode.Zoom;
            imagenUTNFraUno.TabIndex = 12;
            imagenUTNFraUno.TabStop = false;
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
            panelNegroDerecha.Location = new Point(1335, 0);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 593);
            panelNegroDerecha.TabIndex = 2;
            // 
            // panelNegroIzquierda
            // 
            panelNegroIzquierda.BackColor = Color.FromArgb(64, 64, 64);
            panelNegroIzquierda.Dock = DockStyle.Left;
            panelNegroIzquierda.Location = new Point(0, 0);
            panelNegroIzquierda.Name = "panelNegroIzquierda";
            panelNegroIzquierda.Size = new Size(15, 593);
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
            labelSeleccionDeUsuario.Anchor = AnchorStyles.None;
            labelSeleccionDeUsuario.AutoSize = true;
            labelSeleccionDeUsuario.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionDeUsuario.Location = new Point(468, 109);
            labelSeleccionDeUsuario.Name = "labelSeleccionDeUsuario";
            labelSeleccionDeUsuario.Size = new Size(420, 24);
            labelSeleccionDeUsuario.TabIndex = 5;
            labelSeleccionDeUsuario.Text = "Seleccione el tipo de usuario correspondiente:";
            labelSeleccionDeUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelLegajo
            // 
            labelLegajo.Anchor = AnchorStyles.None;
            labelLegajo.AutoSize = true;
            labelLegajo.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegajo.Location = new Point(468, 297);
            labelLegajo.Name = "labelLegajo";
            labelLegajo.Size = new Size(75, 24);
            labelLegajo.TabIndex = 6;
            labelLegajo.Text = "Legajo:";
            labelLegajo.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxLegajo
            // 
            textBoxLegajo.Anchor = AnchorStyles.None;
            textBoxLegajo.Location = new Point(468, 324);
            textBoxLegajo.Name = "textBoxLegajo";
            textBoxLegajo.Size = new Size(417, 27);
            textBoxLegajo.TabIndex = 7;
            // 
            // labelContraseña
            // 
            labelContraseña.Anchor = AnchorStyles.None;
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.Location = new Point(468, 370);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(118, 24);
            labelContraseña.TabIndex = 8;
            labelContraseña.Text = "Contraseña:";
            labelContraseña.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Anchor = AnchorStyles.None;
            textBoxContrasenia.Location = new Point(468, 397);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(417, 27);
            textBoxContrasenia.TabIndex = 9;
            // 
            // buttonDeIngreso
            // 
            buttonDeIngreso.Anchor = AnchorStyles.None;
            buttonDeIngreso.AutoSize = true;
            buttonDeIngreso.Cursor = Cursors.Hand;
            buttonDeIngreso.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeIngreso.Location = new Point(468, 480);
            buttonDeIngreso.Name = "buttonDeIngreso";
            buttonDeIngreso.Size = new Size(417, 91);
            buttonDeIngreso.TabIndex = 10;
            buttonDeIngreso.Text = "CORROBORAR DATOS E INGRESAR";
            buttonDeIngreso.UseVisualStyleBackColor = true;
            buttonDeIngreso.Click += buttonDeIngreso_Click;
            // 
            // panelInferior
            // 
            panelInferior.AutoScroll = true;
            panelInferior.BackColor = Color.FromArgb(64, 64, 64);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(15, 578);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1320, 15);
            panelInferior.TabIndex = 11;
            // 
            // panelMenuDeUsuarios
            // 
            panelMenuDeUsuarios.Anchor = AnchorStyles.None;
            panelMenuDeUsuarios.Controls.Add(buttonEstudiante);
            panelMenuDeUsuarios.Controls.Add(buttonAdministrador);
            panelMenuDeUsuarios.Controls.Add(buttonProfesor);
            panelMenuDeUsuarios.Location = new Point(468, 166);
            panelMenuDeUsuarios.Name = "panelMenuDeUsuarios";
            panelMenuDeUsuarios.Size = new Size(417, 99);
            panelMenuDeUsuarios.TabIndex = 12;
            panelMenuDeUsuarios.Visible = false;
            // 
            // buttonEstudiante
            // 
            buttonEstudiante.Anchor = AnchorStyles.None;
            buttonEstudiante.AutoSize = true;
            buttonEstudiante.BackgroundImageLayout = ImageLayout.None;
            buttonEstudiante.Cursor = Cursors.Hand;
            buttonEstudiante.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonEstudiante.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEstudiante.ImageAlign = ContentAlignment.MiddleRight;
            buttonEstudiante.Location = new Point(0, 66);
            buttonEstudiante.Name = "buttonEstudiante";
            buttonEstudiante.Size = new Size(417, 33);
            buttonEstudiante.TabIndex = 13;
            buttonEstudiante.Text = "Estudiante";
            buttonEstudiante.UseVisualStyleBackColor = true;
            buttonEstudiante.Click += buttonEstudiante_Click;
            // 
            // buttonAdministrador
            // 
            buttonAdministrador.Anchor = AnchorStyles.None;
            buttonAdministrador.AutoSize = true;
            buttonAdministrador.BackgroundImageLayout = ImageLayout.None;
            buttonAdministrador.Cursor = Cursors.Hand;
            buttonAdministrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonAdministrador.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdministrador.ImageAlign = ContentAlignment.MiddleRight;
            buttonAdministrador.Location = new Point(0, 0);
            buttonAdministrador.Name = "buttonAdministrador";
            buttonAdministrador.Size = new Size(417, 33);
            buttonAdministrador.TabIndex = 1;
            buttonAdministrador.Text = "Administrador";
            buttonAdministrador.UseVisualStyleBackColor = true;
            buttonAdministrador.Click += buttonAdministrador_Click;
            // 
            // buttonProfesor
            // 
            buttonProfesor.Anchor = AnchorStyles.None;
            buttonProfesor.AutoSize = true;
            buttonProfesor.BackgroundImageLayout = ImageLayout.None;
            buttonProfesor.Cursor = Cursors.Hand;
            buttonProfesor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonProfesor.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProfesor.ImageAlign = ContentAlignment.MiddleRight;
            buttonProfesor.Location = new Point(0, 33);
            buttonProfesor.Name = "buttonProfesor";
            buttonProfesor.Size = new Size(417, 33);
            buttonProfesor.TabIndex = 2;
            buttonProfesor.Text = "Profesor";
            buttonProfesor.UseVisualStyleBackColor = true;
            buttonProfesor.Click += buttonProfesor_Click;
            // 
            // labelErrorIdContra
            // 
            labelErrorIdContra.Anchor = AnchorStyles.None;
            labelErrorIdContra.AutoSize = true;
            labelErrorIdContra.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorIdContra.ForeColor = Color.Red;
            labelErrorIdContra.Location = new Point(468, 436);
            labelErrorIdContra.Name = "labelErrorIdContra";
            labelErrorIdContra.Size = new Size(411, 24);
            labelErrorIdContra.TabIndex = 14;
            labelErrorIdContra.Text = " ¡Se detectó un error en los datos ingresados!";
            labelErrorIdContra.TextAlign = ContentAlignment.TopCenter;
            labelErrorIdContra.Visible = false;
            // 
            // pictureBoxUtnavellaneda
            // 
            pictureBoxUtnavellaneda.Anchor = AnchorStyles.None;
            pictureBoxUtnavellaneda.Image = (Image)resources.GetObject("pictureBoxUtnavellaneda.Image");
            pictureBoxUtnavellaneda.Location = new Point(333, 176);
            pictureBoxUtnavellaneda.Name = "pictureBoxUtnavellaneda";
            pictureBoxUtnavellaneda.Size = new Size(654, 112);
            pictureBoxUtnavellaneda.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUtnavellaneda.TabIndex = 15;
            pictureBoxUtnavellaneda.TabStop = false;
            // 
            // FormPrograma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1350, 593);
            Controls.Add(panelNegro);
            Controls.Add(panelInferior);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(labelSeleccionDeUsuario);
            Controls.Add(panelMenuDeUsuarios);
            Controls.Add(buttonSeleccionDeUsuario);
            Controls.Add(labelLegajo);
            Controls.Add(textBoxLegajo);
            Controls.Add(labelContraseña);
            Controls.Add(textBoxContrasenia);
            Controls.Add(labelErrorIdContra);
            Controls.Add(buttonDeIngreso);
            Controls.Add(pictureBoxUtnavellaneda);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormPrograma";
            Text = "SYSACAD";
            panelNegro.ResumeLayout(false);
            panelNegro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenuDeUsuarios.ResumeLayout(false);
            panelMenuDeUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).EndInit();
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
        private Label labelLegajo;
        private TextBox textBoxLegajo;
        private Label labelContraseña;
        private TextBox textBoxContrasenia;
        private Button buttonDeIngreso;
        private Panel panelInferior;
        private Label TituloDelPrograma;
        private PictureBox imagenUTNFraUno;
        private Panel panelMenuDeUsuarios;
        private Button buttonEstudiante;
        private Button buttonProfesor;
        private Button buttonAdministrador;
        private Label labelErrorIdContra;
        private PictureBox pictureBoxUtnavellaneda;
    }
}