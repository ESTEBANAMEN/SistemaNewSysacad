namespace FormSysacad
{
    partial class FormAdministrador
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            panelNegro = new Panel();
            imagenUTNFraUno = new PictureBox();
            TituloDelPrograma = new Label();
            panelInferior = new Panel();
            panelNegroIzquierda = new Panel();
            panelNegroDerecha = new Panel();
            labelSeleccionDeOpcionAdministrador = new Label();
            buttonSeleccionDeOpcionAdministrador = new Button();
            panelOpcionesAdministrador = new Panel();
            buttonRegistrarEstudiante = new Button();
            buttonGestionarCursos = new Button();
            panelRegistrarEstudiante = new Panel();
            textBoxTipo = new TextBox();
            labelTipoDeUsuario = new Label();
            labelErrorFormularioRegsitrarEstudiante = new Label();
            buttonFormularioRegistrar = new Button();
            textBoxContraProv = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxNumTel = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            labelFormularioContraseña = new Label();
            labelFormularioCorreo = new Label();
            labelFormularioNumTelefono = new Label();
            labelFormularioDireccion = new Label();
            labelFormularioDNI = new Label();
            labelFormularioNombre = new Label();
            labelTituloFormularioDeRegistro = new Label();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).BeginInit();
            panelOpcionesAdministrador.SuspendLayout();
            panelRegistrarEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // panelNegro
            // 
            panelNegro.BackColor = Color.RoyalBlue;
            panelNegro.Controls.Add(imagenUTNFraUno);
            panelNegro.Controls.Add(TituloDelPrograma);
            panelNegro.Dock = DockStyle.Top;
            panelNegro.Location = new Point(15, 0);
            panelNegro.Name = "panelNegro";
            panelNegro.Size = new Size(1327, 85);
            panelNegro.TabIndex = 12;
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
            // TituloDelPrograma
            // 
            TituloDelPrograma.Anchor = AnchorStyles.None;
            TituloDelPrograma.AutoSize = true;
            TituloDelPrograma.BackColor = Color.White;
            TituloDelPrograma.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            TituloDelPrograma.ForeColor = Color.OrangeRed;
            TituloDelPrograma.Location = new Point(305, 9);
            TituloDelPrograma.Name = "TituloDelPrograma";
            TituloDelPrograma.Size = new Size(814, 59);
            TituloDelPrograma.TabIndex = 0;
            TituloDelPrograma.Text = "NUEVO SISTEMA SYSACAD: ADMINISTRADOR";
            // 
            // panelInferior
            // 
            panelInferior.AutoScroll = true;
            panelInferior.BackColor = Color.RoyalBlue;
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(15, 573);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1327, 15);
            panelInferior.TabIndex = 15;
            // 
            // panelNegroIzquierda
            // 
            panelNegroIzquierda.BackColor = Color.RoyalBlue;
            panelNegroIzquierda.Dock = DockStyle.Left;
            panelNegroIzquierda.Location = new Point(0, 0);
            panelNegroIzquierda.Name = "panelNegroIzquierda";
            panelNegroIzquierda.Size = new Size(15, 588);
            panelNegroIzquierda.TabIndex = 14;
            // 
            // panelNegroDerecha
            // 
            panelNegroDerecha.BackColor = Color.RoyalBlue;
            panelNegroDerecha.Dock = DockStyle.Right;
            panelNegroDerecha.Location = new Point(1342, 0);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 588);
            panelNegroDerecha.TabIndex = 13;
            // 
            // labelSeleccionDeOpcionAdministrador
            // 
            labelSeleccionDeOpcionAdministrador.Anchor = AnchorStyles.None;
            labelSeleccionDeOpcionAdministrador.AutoSize = true;
            labelSeleccionDeOpcionAdministrador.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionDeOpcionAdministrador.Location = new Point(506, 112);
            labelSeleccionDeOpcionAdministrador.Name = "labelSeleccionDeOpcionAdministrador";
            labelSeleccionDeOpcionAdministrador.Size = new Size(346, 24);
            labelSeleccionDeOpcionAdministrador.TabIndex = 16;
            labelSeleccionDeOpcionAdministrador.Text = "Seleccione la opción correspondiente:";
            labelSeleccionDeOpcionAdministrador.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonSeleccionDeOpcionAdministrador
            // 
            buttonSeleccionDeOpcionAdministrador.Anchor = AnchorStyles.None;
            buttonSeleccionDeOpcionAdministrador.AutoSize = true;
            buttonSeleccionDeOpcionAdministrador.BackgroundImageLayout = ImageLayout.None;
            buttonSeleccionDeOpcionAdministrador.Cursor = Cursors.Hand;
            buttonSeleccionDeOpcionAdministrador.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeleccionDeOpcionAdministrador.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeleccionDeOpcionAdministrador.Location = new Point(471, 139);
            buttonSeleccionDeOpcionAdministrador.Name = "buttonSeleccionDeOpcionAdministrador";
            buttonSeleccionDeOpcionAdministrador.Size = new Size(417, 33);
            buttonSeleccionDeOpcionAdministrador.TabIndex = 17;
            buttonSeleccionDeOpcionAdministrador.Text = "Opciones ▼";
            buttonSeleccionDeOpcionAdministrador.UseVisualStyleBackColor = true;
            buttonSeleccionDeOpcionAdministrador.Click += buttonSeleccionDeOpcionadministrador_Click;
            // 
            // panelOpcionesAdministrador
            // 
            panelOpcionesAdministrador.Anchor = AnchorStyles.None;
            panelOpcionesAdministrador.AutoScroll = true;
            panelOpcionesAdministrador.AutoSize = true;
            panelOpcionesAdministrador.Controls.Add(buttonRegistrarEstudiante);
            panelOpcionesAdministrador.Controls.Add(buttonGestionarCursos);
            panelOpcionesAdministrador.Location = new Point(471, 169);
            panelOpcionesAdministrador.Name = "panelOpcionesAdministrador";
            panelOpcionesAdministrador.Size = new Size(417, 71);
            panelOpcionesAdministrador.TabIndex = 18;
            panelOpcionesAdministrador.Visible = false;
            // 
            // buttonRegistrarEstudiante
            // 
            buttonRegistrarEstudiante.Anchor = AnchorStyles.None;
            buttonRegistrarEstudiante.AutoSize = true;
            buttonRegistrarEstudiante.BackgroundImageLayout = ImageLayout.None;
            buttonRegistrarEstudiante.Cursor = Cursors.Hand;
            buttonRegistrarEstudiante.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrarEstudiante.ImageAlign = ContentAlignment.MiddleRight;
            buttonRegistrarEstudiante.Location = new Point(0, 2);
            buttonRegistrarEstudiante.Name = "buttonRegistrarEstudiante";
            buttonRegistrarEstudiante.Size = new Size(417, 33);
            buttonRegistrarEstudiante.TabIndex = 18;
            buttonRegistrarEstudiante.Text = "Registrar Administrador/Estudiante";
            buttonRegistrarEstudiante.UseVisualStyleBackColor = true;
            buttonRegistrarEstudiante.Click += buttonRegistrarEstudiante_Click;
            // 
            // buttonGestionarCursos
            // 
            buttonGestionarCursos.Anchor = AnchorStyles.None;
            buttonGestionarCursos.AutoSize = true;
            buttonGestionarCursos.BackgroundImageLayout = ImageLayout.None;
            buttonGestionarCursos.Cursor = Cursors.Hand;
            buttonGestionarCursos.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestionarCursos.ImageAlign = ContentAlignment.MiddleRight;
            buttonGestionarCursos.Location = new Point(0, 35);
            buttonGestionarCursos.Name = "buttonGestionarCursos";
            buttonGestionarCursos.Size = new Size(417, 33);
            buttonGestionarCursos.TabIndex = 19;
            buttonGestionarCursos.Text = "Gestionar Cursos";
            buttonGestionarCursos.UseVisualStyleBackColor = true;
            buttonGestionarCursos.Click += buttonGestionarCursos_Click;
            // 
            // panelRegistrarEstudiante
            // 
            panelRegistrarEstudiante.Anchor = AnchorStyles.None;
            panelRegistrarEstudiante.AutoScroll = true;
            panelRegistrarEstudiante.AutoSize = true;
            panelRegistrarEstudiante.Controls.Add(textBoxTipo);
            panelRegistrarEstudiante.Controls.Add(labelTipoDeUsuario);
            panelRegistrarEstudiante.Controls.Add(labelErrorFormularioRegsitrarEstudiante);
            panelRegistrarEstudiante.Controls.Add(buttonFormularioRegistrar);
            panelRegistrarEstudiante.Controls.Add(textBoxContraProv);
            panelRegistrarEstudiante.Controls.Add(textBoxCorreo);
            panelRegistrarEstudiante.Controls.Add(textBoxNumTel);
            panelRegistrarEstudiante.Controls.Add(textBoxDireccion);
            panelRegistrarEstudiante.Controls.Add(textBoxDNI);
            panelRegistrarEstudiante.Controls.Add(textBoxNombre);
            panelRegistrarEstudiante.Controls.Add(labelFormularioContraseña);
            panelRegistrarEstudiante.Controls.Add(labelFormularioCorreo);
            panelRegistrarEstudiante.Controls.Add(labelFormularioNumTelefono);
            panelRegistrarEstudiante.Controls.Add(labelFormularioDireccion);
            panelRegistrarEstudiante.Controls.Add(labelFormularioDNI);
            panelRegistrarEstudiante.Controls.Add(labelFormularioNombre);
            panelRegistrarEstudiante.Controls.Add(labelTituloFormularioDeRegistro);
            panelRegistrarEstudiante.Location = new Point(93, 246);
            panelRegistrarEstudiante.Name = "panelRegistrarEstudiante";
            panelRegistrarEstudiante.Size = new Size(1167, 323);
            panelRegistrarEstudiante.TabIndex = 19;
            panelRegistrarEstudiante.Visible = false;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Anchor = AnchorStyles.None;
            textBoxTipo.Location = new Point(208, 240);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(373, 27);
            textBoxTipo.TabIndex = 17;
            // 
            // labelTipoDeUsuario
            // 
            labelTipoDeUsuario.Anchor = AnchorStyles.None;
            labelTipoDeUsuario.AutoSize = true;
            labelTipoDeUsuario.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoDeUsuario.Location = new Point(3, 243);
            labelTipoDeUsuario.Name = "labelTipoDeUsuario";
            labelTipoDeUsuario.Size = new Size(199, 20);
            labelTipoDeUsuario.TabIndex = 16;
            labelTipoDeUsuario.Text = "Tipo (admin-estudiante):";
            // 
            // labelErrorFormularioRegsitrarEstudiante
            // 
            labelErrorFormularioRegsitrarEstudiante.AutoSize = true;
            labelErrorFormularioRegsitrarEstudiante.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelErrorFormularioRegsitrarEstudiante.ForeColor = Color.Red;
            labelErrorFormularioRegsitrarEstudiante.Location = new Point(686, 208);
            labelErrorFormularioRegsitrarEstudiante.Name = "labelErrorFormularioRegsitrarEstudiante";
            labelErrorFormularioRegsitrarEstudiante.Size = new Size(383, 21);
            labelErrorFormularioRegsitrarEstudiante.TabIndex = 15;
            labelErrorFormularioRegsitrarEstudiante.Text = "¡ERROR! No se permiten campos vacíos.";
            labelErrorFormularioRegsitrarEstudiante.Visible = false;
            // 
            // buttonFormularioRegistrar
            // 
            buttonFormularioRegistrar.Anchor = AnchorStyles.None;
            buttonFormularioRegistrar.AutoSize = true;
            buttonFormularioRegistrar.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormularioRegistrar.Location = new Point(669, 232);
            buttonFormularioRegistrar.Name = "buttonFormularioRegistrar";
            buttonFormularioRegistrar.Size = new Size(417, 86);
            buttonFormularioRegistrar.TabIndex = 14;
            buttonFormularioRegistrar.Text = "REGISTRAR ESTUDIANTE";
            buttonFormularioRegistrar.UseVisualStyleBackColor = true;
            buttonFormularioRegistrar.Click += buttonFormularioRegistrar_Click;
            // 
            // textBoxContraProv
            // 
            textBoxContraProv.Anchor = AnchorStyles.None;
            textBoxContraProv.Location = new Point(781, 175);
            textBoxContraProv.Name = "textBoxContraProv";
            textBoxContraProv.Size = new Size(369, 27);
            textBoxContraProv.TabIndex = 13;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.None;
            textBoxCorreo.Location = new Point(164, 175);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(417, 27);
            textBoxCorreo.TabIndex = 12;
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.Anchor = AnchorStyles.None;
            textBoxNumTel.Location = new Point(761, 105);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(389, 27);
            textBoxNumTel.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.None;
            textBoxDireccion.Location = new Point(96, 105);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(485, 27);
            textBoxDireccion.TabIndex = 10;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.None;
            textBoxDNI.Location = new Point(713, 45);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(437, 27);
            textBoxDNI.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.None;
            textBoxNombre.Location = new Point(194, 45);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(387, 27);
            textBoxNombre.TabIndex = 8;
            // 
            // labelFormularioContraseña
            // 
            labelFormularioContraseña.Anchor = AnchorStyles.None;
            labelFormularioContraseña.AutoSize = true;
            labelFormularioContraseña.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioContraseña.Location = new Point(587, 178);
            labelFormularioContraseña.Name = "labelFormularioContraseña";
            labelFormularioContraseña.Size = new Size(180, 20);
            labelFormularioContraseña.TabIndex = 7;
            labelFormularioContraseña.Text = "Contraseña Provisoria:";
            // 
            // labelFormularioCorreo
            // 
            labelFormularioCorreo.Anchor = AnchorStyles.None;
            labelFormularioCorreo.AutoSize = true;
            labelFormularioCorreo.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioCorreo.Location = new Point(3, 178);
            labelFormularioCorreo.Name = "labelFormularioCorreo";
            labelFormularioCorreo.Size = new Size(155, 20);
            labelFormularioCorreo.TabIndex = 6;
            labelFormularioCorreo.Text = "Correo Electrónico:";
            // 
            // labelFormularioNumTelefono
            // 
            labelFormularioNumTelefono.Anchor = AnchorStyles.None;
            labelFormularioNumTelefono.AutoSize = true;
            labelFormularioNumTelefono.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioNumTelefono.Location = new Point(587, 108);
            labelFormularioNumTelefono.Name = "labelFormularioNumTelefono";
            labelFormularioNumTelefono.Size = new Size(168, 20);
            labelFormularioNumTelefono.TabIndex = 5;
            labelFormularioNumTelefono.Text = "Número de Teléfono:";
            // 
            // labelFormularioDireccion
            // 
            labelFormularioDireccion.Anchor = AnchorStyles.None;
            labelFormularioDireccion.AutoSize = true;
            labelFormularioDireccion.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioDireccion.Location = new Point(3, 108);
            labelFormularioDireccion.Name = "labelFormularioDireccion";
            labelFormularioDireccion.Size = new Size(87, 20);
            labelFormularioDireccion.TabIndex = 4;
            labelFormularioDireccion.Text = "Dirección:";
            // 
            // labelFormularioDNI
            // 
            labelFormularioDNI.Anchor = AnchorStyles.None;
            labelFormularioDNI.AutoSize = true;
            labelFormularioDNI.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioDNI.Location = new Point(587, 48);
            labelFormularioDNI.Name = "labelFormularioDNI";
            labelFormularioDNI.Size = new Size(120, 20);
            labelFormularioDNI.TabIndex = 3;
            labelFormularioDNI.Text = "DNI/DU/otro:";
            // 
            // labelFormularioNombre
            // 
            labelFormularioNombre.Anchor = AnchorStyles.None;
            labelFormularioNombre.AutoSize = true;
            labelFormularioNombre.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioNombre.Location = new Point(3, 48);
            labelFormularioNombre.Name = "labelFormularioNombre";
            labelFormularioNombre.Size = new Size(185, 20);
            labelFormularioNombre.TabIndex = 1;
            labelFormularioNombre.Text = "Nombre/s y Apellido/s:";
            // 
            // labelTituloFormularioDeRegistro
            // 
            labelTituloFormularioDeRegistro.Anchor = AnchorStyles.None;
            labelTituloFormularioDeRegistro.AutoSize = true;
            labelTituloFormularioDeRegistro.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelTituloFormularioDeRegistro.Location = new Point(457, 10);
            labelTituloFormularioDeRegistro.Name = "labelTituloFormularioDeRegistro";
            labelTituloFormularioDeRegistro.Size = new Size(250, 24);
            labelTituloFormularioDeRegistro.TabIndex = 0;
            labelTituloFormularioDeRegistro.Text = "Formulario de Registro";
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 588);
            Controls.Add(panelNegro);
            Controls.Add(panelInferior);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(panelOpcionesAdministrador);
            Controls.Add(buttonSeleccionDeOpcionAdministrador);
            Controls.Add(labelSeleccionDeOpcionAdministrador);
            Controls.Add(panelRegistrarEstudiante);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            panelNegro.ResumeLayout(false);
            panelNegro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).EndInit();
            panelOpcionesAdministrador.ResumeLayout(false);
            panelOpcionesAdministrador.PerformLayout();
            panelRegistrarEstudiante.ResumeLayout(false);
            panelRegistrarEstudiante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNegro;
        private PictureBox imagenUTNFraUno;
        private Label TituloDelPrograma;
        private Panel panelInferior;
        private Panel panelNegroIzquierda;
        private Panel panelNegroDerecha;
        private Label labelSeleccionDeOpcionAdministrador;
        private Button buttonSeleccionDeOpcionAdministrador;
        private Panel panelOpcionesAdministrador;
        private Button buttonRegistrarEstudiante;
        private Button buttonGestionarCursos;
        private Panel panelRegistrarEstudiante;
        private Label labelTituloFormularioDeRegistro;
        private Label labelFormularioNombre;
        private Label labelFormularioDNI;
        private Label labelFormularioNumTelefono;
        private Label labelFormularioDireccion;
        private Label labelFormularioContraseña;
        private Label labelFormularioCorreo;
        private TextBox textBoxContraProv;
        private TextBox textBoxCorreo;
        private TextBox textBoxNumTel;
        private TextBox textBoxDireccion;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private Button buttonFormularioRegistrar;
        private Label labelErrorFormularioRegsitrarEstudiante;
        private TextBox textBoxTipo;
        private Label labelTipoDeUsuario;
    }
}