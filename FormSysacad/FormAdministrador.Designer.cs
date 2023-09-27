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
            labelFormularioTipoDeUsuario = new Label();
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
            labelFormularioNumTel = new Label();
            labelFormularioDireccion = new Label();
            labelFormularioDNI = new Label();
            labelFormularioNombre = new Label();
            labelTituloFormularioDeRegistro = new Label();
            panelExitoAlGenerar = new Panel();
            pictureBoxUtnavellaneda = new PictureBox();
            buttonenviarAlMailYSalir = new Button();
            labelMensajePanelExitoAlGenerar = new Label();
            pictureBoxGrande = new PictureBox();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).BeginInit();
            panelOpcionesAdministrador.SuspendLayout();
            panelRegistrarEstudiante.SuspendLayout();
            panelExitoAlGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrande).BeginInit();
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
            panelNegro.Size = new Size(1280, 85);
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
            TituloDelPrograma.Location = new Point(282, 9);
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
            panelInferior.Size = new Size(1280, 15);
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
            panelNegroDerecha.Location = new Point(1295, 0);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 588);
            panelNegroDerecha.TabIndex = 13;
            // 
            // labelSeleccionDeOpcionAdministrador
            // 
            labelSeleccionDeOpcionAdministrador.Anchor = AnchorStyles.None;
            labelSeleccionDeOpcionAdministrador.AutoSize = true;
            labelSeleccionDeOpcionAdministrador.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionDeOpcionAdministrador.Location = new Point(483, 112);
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
            buttonSeleccionDeOpcionAdministrador.Location = new Point(448, 139);
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
            panelOpcionesAdministrador.Location = new Point(448, 169);
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
            panelRegistrarEstudiante.Controls.Add(labelFormularioTipoDeUsuario);
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
            panelRegistrarEstudiante.Controls.Add(labelFormularioNumTel);
            panelRegistrarEstudiante.Controls.Add(labelFormularioDireccion);
            panelRegistrarEstudiante.Controls.Add(labelFormularioDNI);
            panelRegistrarEstudiante.Controls.Add(labelFormularioNombre);
            panelRegistrarEstudiante.Controls.Add(labelTituloFormularioDeRegistro);
            panelRegistrarEstudiante.Location = new Point(70, 246);
            panelRegistrarEstudiante.Name = "panelRegistrarEstudiante";
            panelRegistrarEstudiante.Size = new Size(1174, 323);
            panelRegistrarEstudiante.TabIndex = 19;
            panelRegistrarEstudiante.Visible = false;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Anchor = AnchorStyles.None;
            textBoxTipo.Location = new Point(212, 240);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(373, 27);
            textBoxTipo.TabIndex = 17;
            // 
            // labelFormularioTipoDeUsuario
            // 
            labelFormularioTipoDeUsuario.Anchor = AnchorStyles.None;
            labelFormularioTipoDeUsuario.AutoSize = true;
            labelFormularioTipoDeUsuario.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioTipoDeUsuario.Location = new Point(7, 243);
            labelFormularioTipoDeUsuario.Name = "labelFormularioTipoDeUsuario";
            labelFormularioTipoDeUsuario.Size = new Size(199, 20);
            labelFormularioTipoDeUsuario.TabIndex = 16;
            labelFormularioTipoDeUsuario.Text = "Tipo (admin-estudiante):";
            // 
            // labelErrorFormularioRegsitrarEstudiante
            // 
            labelErrorFormularioRegsitrarEstudiante.AutoSize = true;
            labelErrorFormularioRegsitrarEstudiante.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelErrorFormularioRegsitrarEstudiante.ForeColor = Color.Red;
            labelErrorFormularioRegsitrarEstudiante.Location = new Point(741, 208);
            labelErrorFormularioRegsitrarEstudiante.Name = "labelErrorFormularioRegsitrarEstudiante";
            labelErrorFormularioRegsitrarEstudiante.Size = new Size(271, 21);
            labelErrorFormularioRegsitrarEstudiante.TabIndex = 15;
            labelErrorFormularioRegsitrarEstudiante.Text = "¡ERROR! Revise los campos.";
            labelErrorFormularioRegsitrarEstudiante.Visible = false;
            // 
            // buttonFormularioRegistrar
            // 
            buttonFormularioRegistrar.Anchor = AnchorStyles.None;
            buttonFormularioRegistrar.AutoSize = true;
            buttonFormularioRegistrar.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormularioRegistrar.Location = new Point(673, 232);
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
            textBoxContraProv.Location = new Point(785, 175);
            textBoxContraProv.Name = "textBoxContraProv";
            textBoxContraProv.Size = new Size(369, 27);
            textBoxContraProv.TabIndex = 13;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.None;
            textBoxCorreo.Location = new Point(168, 175);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(417, 27);
            textBoxCorreo.TabIndex = 12;
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.Anchor = AnchorStyles.None;
            textBoxNumTel.Location = new Point(765, 105);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(389, 27);
            textBoxNumTel.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.None;
            textBoxDireccion.Location = new Point(177, 105);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(408, 27);
            textBoxDireccion.TabIndex = 10;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.None;
            textBoxDNI.Location = new Point(717, 45);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(437, 27);
            textBoxDNI.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.None;
            textBoxNombre.Location = new Point(198, 45);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(387, 27);
            textBoxNombre.TabIndex = 8;
            // 
            // labelFormularioContraseña
            // 
            labelFormularioContraseña.Anchor = AnchorStyles.None;
            labelFormularioContraseña.AutoSize = true;
            labelFormularioContraseña.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioContraseña.Location = new Point(591, 178);
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
            labelFormularioCorreo.Location = new Point(7, 178);
            labelFormularioCorreo.Name = "labelFormularioCorreo";
            labelFormularioCorreo.Size = new Size(155, 20);
            labelFormularioCorreo.TabIndex = 6;
            labelFormularioCorreo.Text = "Correo Electrónico:";
            // 
            // labelFormularioNumTel
            // 
            labelFormularioNumTel.Anchor = AnchorStyles.None;
            labelFormularioNumTel.AutoSize = true;
            labelFormularioNumTel.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioNumTel.Location = new Point(591, 108);
            labelFormularioNumTel.Name = "labelFormularioNumTel";
            labelFormularioNumTel.Size = new Size(168, 20);
            labelFormularioNumTel.TabIndex = 5;
            labelFormularioNumTel.Text = "Número de Teléfono:";
            // 
            // labelFormularioDireccion
            // 
            labelFormularioDireccion.Anchor = AnchorStyles.None;
            labelFormularioDireccion.AutoSize = true;
            labelFormularioDireccion.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioDireccion.Location = new Point(7, 108);
            labelFormularioDireccion.Name = "labelFormularioDireccion";
            labelFormularioDireccion.Size = new Size(164, 20);
            labelFormularioDireccion.TabIndex = 4;
            labelFormularioDireccion.Text = "Dirección Completa:";
            // 
            // labelFormularioDNI
            // 
            labelFormularioDNI.Anchor = AnchorStyles.None;
            labelFormularioDNI.AutoSize = true;
            labelFormularioDNI.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormularioDNI.Location = new Point(591, 48);
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
            labelFormularioNombre.Location = new Point(7, 48);
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
            labelTituloFormularioDeRegistro.Location = new Point(461, 10);
            labelTituloFormularioDeRegistro.Name = "labelTituloFormularioDeRegistro";
            labelTituloFormularioDeRegistro.Size = new Size(250, 24);
            labelTituloFormularioDeRegistro.TabIndex = 0;
            labelTituloFormularioDeRegistro.Text = "Formulario de Registro";
            // 
            // panelExitoAlGenerar
            // 
            panelExitoAlGenerar.Anchor = AnchorStyles.None;
            panelExitoAlGenerar.AutoScroll = true;
            panelExitoAlGenerar.AutoSize = true;
            panelExitoAlGenerar.Controls.Add(pictureBoxUtnavellaneda);
            panelExitoAlGenerar.Controls.Add(buttonenviarAlMailYSalir);
            panelExitoAlGenerar.Controls.Add(labelMensajePanelExitoAlGenerar);
            panelExitoAlGenerar.Location = new Point(70, 96);
            panelExitoAlGenerar.Name = "panelExitoAlGenerar";
            panelExitoAlGenerar.Size = new Size(1174, 473);
            panelExitoAlGenerar.TabIndex = 20;
            panelExitoAlGenerar.Visible = false;
            // 
            // pictureBoxUtnavellaneda
            // 
            pictureBoxUtnavellaneda.Anchor = AnchorStyles.None;
            pictureBoxUtnavellaneda.Image = (Image)resources.GetObject("pictureBoxUtnavellaneda.Image");
            pictureBoxUtnavellaneda.Location = new Point(238, 281);
            pictureBoxUtnavellaneda.Name = "pictureBoxUtnavellaneda";
            pictureBoxUtnavellaneda.Size = new Size(696, 151);
            pictureBoxUtnavellaneda.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUtnavellaneda.TabIndex = 2;
            pictureBoxUtnavellaneda.TabStop = false;
            // 
            // buttonenviarAlMailYSalir
            // 
            buttonenviarAlMailYSalir.Anchor = AnchorStyles.None;
            buttonenviarAlMailYSalir.AutoSize = true;
            buttonenviarAlMailYSalir.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonenviarAlMailYSalir.Location = new Point(238, 120);
            buttonenviarAlMailYSalir.Name = "buttonenviarAlMailYSalir";
            buttonenviarAlMailYSalir.Size = new Size(696, 129);
            buttonenviarAlMailYSalir.TabIndex = 1;
            buttonenviarAlMailYSalir.Text = "Enviar al CorreoElectronico y Cerrar Form";
            buttonenviarAlMailYSalir.UseVisualStyleBackColor = true;
            buttonenviarAlMailYSalir.Click += buttonenviarAlMailYSalir_Click;
            // 
            // labelMensajePanelExitoAlGenerar
            // 
            labelMensajePanelExitoAlGenerar.Anchor = AnchorStyles.None;
            labelMensajePanelExitoAlGenerar.AutoSize = true;
            labelMensajePanelExitoAlGenerar.BackColor = SystemColors.ActiveBorder;
            labelMensajePanelExitoAlGenerar.BorderStyle = BorderStyle.Fixed3D;
            labelMensajePanelExitoAlGenerar.Font = new Font("Georgia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelMensajePanelExitoAlGenerar.ForeColor = Color.OrangeRed;
            labelMensajePanelExitoAlGenerar.Location = new Point(238, 57);
            labelMensajePanelExitoAlGenerar.Name = "labelMensajePanelExitoAlGenerar";
            labelMensajePanelExitoAlGenerar.Size = new Size(696, 53);
            labelMensajePanelExitoAlGenerar.TabIndex = 0;
            labelMensajePanelExitoAlGenerar.Text = "¡Usuario Generado con Éxito!";
            // 
            // pictureBoxGrande
            // 
            pictureBoxGrande.Image = (Image)resources.GetObject("pictureBoxGrande.Image");
            pictureBoxGrande.Location = new Point(272, 236);
            pictureBoxGrande.Name = "pictureBoxGrande";
            pictureBoxGrande.Size = new Size(814, 314);
            pictureBoxGrande.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGrande.TabIndex = 21;
            pictureBoxGrande.TabStop = false;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 588);
            Controls.Add(panelNegro);
            Controls.Add(panelInferior);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(panelOpcionesAdministrador);
            Controls.Add(buttonSeleccionDeOpcionAdministrador);
            Controls.Add(labelSeleccionDeOpcionAdministrador);
            Controls.Add(panelRegistrarEstudiante);
            Controls.Add(panelExitoAlGenerar);
            Controls.Add(pictureBoxGrande);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            panelNegro.ResumeLayout(false);
            panelNegro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).EndInit();
            panelOpcionesAdministrador.ResumeLayout(false);
            panelOpcionesAdministrador.PerformLayout();
            panelRegistrarEstudiante.ResumeLayout(false);
            panelRegistrarEstudiante.PerformLayout();
            panelExitoAlGenerar.ResumeLayout(false);
            panelExitoAlGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrande).EndInit();
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
        private Label labelFormularioNumTel;
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
        private Label labelFormularioTipoDeUsuario;
        private Panel panelExitoAlGenerar;
        private Label labelMensajePanelExitoAlGenerar;
        private Button buttonenviarAlMailYSalir;
        private PictureBox pictureBoxUtnavellaneda;
        private PictureBox pictureBoxGrande;
    }
}