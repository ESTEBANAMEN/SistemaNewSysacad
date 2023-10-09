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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelGestionarCursos = new Panel();
            buttonFinalizarEdicion = new Button();
            buttonEditarCurso = new Button();
            labelCupoCurso = new Label();
            labelDescripcionCurso = new Label();
            labelCodigoCurso = new Label();
            labelNombreCurso = new Label();
            buttonBorrar = new Button();
            buttonAgregar = new Button();
            textBoxCupoCurso = new TextBox();
            textBoxDescripcionCurso = new TextBox();
            textBoxCodigoCurso = new TextBox();
            textBoxNombreCurso = new TextBox();
            dataGridCursos = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnCodigo = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnCupo = new DataGridViewTextBoxColumn();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).BeginInit();
            panelOpcionesAdministrador.SuspendLayout();
            panelRegistrarEstudiante.SuspendLayout();
            panelExitoAlGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrande).BeginInit();
            panelGestionarCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCursos).BeginInit();
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
            panelNegro.Size = new Size(1341, 85);
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
            TituloDelPrograma.BackColor = SystemColors.InactiveCaption;
            TituloDelPrograma.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            TituloDelPrograma.ForeColor = Color.OrangeRed;
            TituloDelPrograma.Location = new Point(283, 9);
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
            panelInferior.Size = new Size(1341, 15);
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
            panelNegroDerecha.Location = new Point(1356, 0);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 588);
            panelNegroDerecha.TabIndex = 13;
            // 
            // labelSeleccionDeOpcionAdministrador
            // 
            labelSeleccionDeOpcionAdministrador.Anchor = AnchorStyles.None;
            labelSeleccionDeOpcionAdministrador.AutoSize = true;
            labelSeleccionDeOpcionAdministrador.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionDeOpcionAdministrador.Location = new Point(513, 112);
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
            buttonSeleccionDeOpcionAdministrador.Location = new Point(478, 139);
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
            panelOpcionesAdministrador.Location = new Point(478, 169);
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
            panelRegistrarEstudiante.Location = new Point(100, 246);
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
            panelExitoAlGenerar.Controls.Add(pictureBoxGrande);
            panelExitoAlGenerar.Location = new Point(100, 96);
            panelExitoAlGenerar.Name = "panelExitoAlGenerar";
            panelExitoAlGenerar.Size = new Size(1174, 473);
            panelExitoAlGenerar.TabIndex = 20;
            panelExitoAlGenerar.Visible = false;
            // 
            // pictureBoxUtnavellaneda
            // 
            pictureBoxUtnavellaneda.Anchor = AnchorStyles.None;
            pictureBoxUtnavellaneda.Image = (Image)resources.GetObject("pictureBoxUtnavellaneda.Image");
            pictureBoxUtnavellaneda.Location = new Point(238, 276);
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
            buttonenviarAlMailYSalir.Location = new Point(238, 115);
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
            labelMensajePanelExitoAlGenerar.Location = new Point(238, 52);
            labelMensajePanelExitoAlGenerar.Name = "labelMensajePanelExitoAlGenerar";
            labelMensajePanelExitoAlGenerar.Size = new Size(696, 53);
            labelMensajePanelExitoAlGenerar.TabIndex = 0;
            labelMensajePanelExitoAlGenerar.Text = "¡Usuario Generado con Éxito!";
            // 
            // pictureBoxGrande
            // 
            pictureBoxGrande.Anchor = AnchorStyles.None;
            pictureBoxGrande.Image = (Image)resources.GetObject("pictureBoxGrande.Image");
            pictureBoxGrande.Location = new Point(195, 115);
            pictureBoxGrande.Name = "pictureBoxGrande";
            pictureBoxGrande.Size = new Size(814, 314);
            pictureBoxGrande.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGrande.TabIndex = 21;
            pictureBoxGrande.TabStop = false;
            // 
            // panelGestionarCursos
            // 
            panelGestionarCursos.Anchor = AnchorStyles.None;
            panelGestionarCursos.AutoScroll = true;
            panelGestionarCursos.AutoSize = true;
            panelGestionarCursos.Controls.Add(buttonFinalizarEdicion);
            panelGestionarCursos.Controls.Add(buttonEditarCurso);
            panelGestionarCursos.Controls.Add(labelCupoCurso);
            panelGestionarCursos.Controls.Add(labelDescripcionCurso);
            panelGestionarCursos.Controls.Add(labelCodigoCurso);
            panelGestionarCursos.Controls.Add(labelNombreCurso);
            panelGestionarCursos.Controls.Add(buttonBorrar);
            panelGestionarCursos.Controls.Add(buttonAgregar);
            panelGestionarCursos.Controls.Add(textBoxCupoCurso);
            panelGestionarCursos.Controls.Add(textBoxDescripcionCurso);
            panelGestionarCursos.Controls.Add(textBoxCodigoCurso);
            panelGestionarCursos.Controls.Add(textBoxNombreCurso);
            panelGestionarCursos.Controls.Add(dataGridCursos);
            panelGestionarCursos.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelGestionarCursos.Location = new Point(100, 246);
            panelGestionarCursos.Name = "panelGestionarCursos";
            panelGestionarCursos.Size = new Size(1173, 323);
            panelGestionarCursos.TabIndex = 3;
            panelGestionarCursos.Visible = false;
            // 
            // buttonFinalizarEdicion
            // 
            buttonFinalizarEdicion.Anchor = AnchorStyles.None;
            buttonFinalizarEdicion.AutoSize = true;
            buttonFinalizarEdicion.BackColor = Color.FromArgb(128, 128, 255);
            buttonFinalizarEdicion.Cursor = Cursors.Hand;
            buttonFinalizarEdicion.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizarEdicion.Location = new Point(885, 196);
            buttonFinalizarEdicion.Name = "buttonFinalizarEdicion";
            buttonFinalizarEdicion.Size = new Size(149, 119);
            buttonFinalizarEdicion.TabIndex = 12;
            buttonFinalizarEdicion.Text = "Finalizar Edición";
            buttonFinalizarEdicion.UseVisualStyleBackColor = false;
            buttonFinalizarEdicion.Visible = false;
            buttonFinalizarEdicion.Click += buttonFinalizarEdicion_Click;
            // 
            // buttonEditarCurso
            // 
            buttonEditarCurso.Anchor = AnchorStyles.None;
            buttonEditarCurso.AutoSize = true;
            buttonEditarCurso.BackColor = Color.FromArgb(255, 255, 128);
            buttonEditarCurso.Cursor = Cursors.Hand;
            buttonEditarCurso.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarCurso.Location = new Point(748, 196);
            buttonEditarCurso.Name = "buttonEditarCurso";
            buttonEditarCurso.Size = new Size(127, 119);
            buttonEditarCurso.TabIndex = 11;
            buttonEditarCurso.Text = "Editar Curso";
            buttonEditarCurso.UseVisualStyleBackColor = false;
            buttonEditarCurso.Click += buttonEditarCurso_Click;
            // 
            // labelCupoCurso
            // 
            labelCupoCurso.Anchor = AnchorStyles.None;
            labelCupoCurso.AutoSize = true;
            labelCupoCurso.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCupoCurso.Location = new Point(7, 293);
            labelCupoCurso.Name = "labelCupoCurso";
            labelCupoCurso.Size = new Size(121, 20);
            labelCupoCurso.TabIndex = 10;
            labelCupoCurso.Text = "Cupo Maximo:";
            // 
            // labelDescripcionCurso
            // 
            labelDescripcionCurso.Anchor = AnchorStyles.None;
            labelDescripcionCurso.AutoSize = true;
            labelDescripcionCurso.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcionCurso.Location = new Point(7, 261);
            labelDescripcionCurso.Name = "labelDescripcionCurso";
            labelDescripcionCurso.Size = new Size(179, 20);
            labelDescripcionCurso.TabIndex = 9;
            labelDescripcionCurso.Text = "Descripción del Curso:";
            // 
            // labelCodigoCurso
            // 
            labelCodigoCurso.Anchor = AnchorStyles.None;
            labelCodigoCurso.AutoSize = true;
            labelCodigoCurso.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCodigoCurso.Location = new Point(7, 231);
            labelCodigoCurso.Name = "labelCodigoCurso";
            labelCodigoCurso.Size = new Size(142, 20);
            labelCodigoCurso.TabIndex = 8;
            labelCodigoCurso.Text = "Codigo del Curso:";
            // 
            // labelNombreCurso
            // 
            labelNombreCurso.Anchor = AnchorStyles.None;
            labelNombreCurso.AutoSize = true;
            labelNombreCurso.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreCurso.Location = new Point(7, 201);
            labelNombreCurso.Name = "labelNombreCurso";
            labelNombreCurso.Size = new Size(151, 20);
            labelNombreCurso.TabIndex = 7;
            labelNombreCurso.Text = "Nombre del Curso:";
            // 
            // buttonBorrar
            // 
            buttonBorrar.Anchor = AnchorStyles.None;
            buttonBorrar.AutoSize = true;
            buttonBorrar.BackColor = Color.FromArgb(255, 128, 128);
            buttonBorrar.Cursor = Cursors.Hand;
            buttonBorrar.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBorrar.Location = new Point(1040, 195);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(127, 119);
            buttonBorrar.TabIndex = 6;
            buttonBorrar.Text = "Borrar Curso";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.None;
            buttonAgregar.AutoSize = true;
            buttonAgregar.BackColor = Color.FromArgb(128, 255, 128);
            buttonAgregar.Cursor = Cursors.Hand;
            buttonAgregar.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(615, 196);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(127, 119);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar Curso";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // textBoxCupoCurso
            // 
            textBoxCupoCurso.Anchor = AnchorStyles.None;
            textBoxCupoCurso.Cursor = Cursors.IBeam;
            textBoxCupoCurso.Location = new Point(134, 287);
            textBoxCupoCurso.Name = "textBoxCupoCurso";
            textBoxCupoCurso.Size = new Size(460, 25);
            textBoxCupoCurso.TabIndex = 4;
            // 
            // textBoxDescripcionCurso
            // 
            textBoxDescripcionCurso.Anchor = AnchorStyles.None;
            textBoxDescripcionCurso.Cursor = Cursors.IBeam;
            textBoxDescripcionCurso.Location = new Point(192, 256);
            textBoxDescripcionCurso.Name = "textBoxDescripcionCurso";
            textBoxDescripcionCurso.Size = new Size(402, 25);
            textBoxDescripcionCurso.TabIndex = 3;
            // 
            // textBoxCodigoCurso
            // 
            textBoxCodigoCurso.Anchor = AnchorStyles.None;
            textBoxCodigoCurso.Cursor = Cursors.IBeam;
            textBoxCodigoCurso.Location = new Point(164, 226);
            textBoxCodigoCurso.Name = "textBoxCodigoCurso";
            textBoxCodigoCurso.Size = new Size(430, 25);
            textBoxCodigoCurso.TabIndex = 2;
            // 
            // textBoxNombreCurso
            // 
            textBoxNombreCurso.Anchor = AnchorStyles.None;
            textBoxNombreCurso.Cursor = Cursors.IBeam;
            textBoxNombreCurso.Location = new Point(164, 196);
            textBoxNombreCurso.Name = "textBoxNombreCurso";
            textBoxNombreCurso.Size = new Size(430, 25);
            textBoxNombreCurso.TabIndex = 1;
            // 
            // dataGridCursos
            // 
            dataGridCursos.AllowUserToAddRows = false;
            dataGridCursos.AllowUserToDeleteRows = false;
            dataGridCursos.Anchor = AnchorStyles.None;
            dataGridCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridCursos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridCursos.BorderStyle = BorderStyle.Fixed3D;
            dataGridCursos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCursos.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnCodigo, ColumnDescripcion, ColumnCupo });
            dataGridCursos.EnableHeadersVisualStyles = false;
            dataGridCursos.GridColor = Color.SteelBlue;
            dataGridCursos.Location = new Point(0, 0);
            dataGridCursos.Name = "dataGridCursos";
            dataGridCursos.ReadOnly = true;
            dataGridCursos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCursos.RowHeadersVisible = false;
            dataGridCursos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridCursos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCursos.RowTemplate.Height = 29;
            dataGridCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCursos.Size = new Size(1174, 188);
            dataGridCursos.TabIndex = 0;
            // 
            // ColumnNombre
            // 
            ColumnNombre.FillWeight = 129.862076F;
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.MinimumWidth = 15;
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.FillWeight = 28.7630768F;
            ColumnCodigo.HeaderText = "Codigo";
            ColumnCodigo.MinimumWidth = 14;
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.FillWeight = 190.037964F;
            ColumnDescripcion.HeaderText = "Descripción";
            ColumnDescripcion.MinimumWidth = 6;
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnCupo
            // 
            ColumnCupo.FillWeight = 51.3369F;
            ColumnCupo.HeaderText = "Cupo Maximo";
            ColumnCupo.MinimumWidth = 6;
            ColumnCupo.Name = "ColumnCupo";
            ColumnCupo.ReadOnly = true;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1371, 588);
            Controls.Add(panelNegro);
            Controls.Add(panelInferior);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(panelGestionarCursos);
            Controls.Add(panelOpcionesAdministrador);
            Controls.Add(buttonSeleccionDeOpcionAdministrador);
            Controls.Add(labelSeleccionDeOpcionAdministrador);
            Controls.Add(panelRegistrarEstudiante);
            Controls.Add(panelExitoAlGenerar);
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
            panelGestionarCursos.ResumeLayout(false);
            panelGestionarCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCursos).EndInit();
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
        private Panel panelGestionarCursos;
        private DataGridView dataGridCursos;
        private TextBox textBoxCupoCurso;
        private TextBox textBoxDescripcionCurso;
        private TextBox textBoxCodigoCurso;
        private TextBox textBoxNombreCurso;
        private Button buttonBorrar;
        private Button buttonAgregar;
        private Label labelCupoCurso;
        private Label labelDescripcionCurso;
        private Label labelCodigoCurso;
        private Label labelNombreCurso;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnCupo;
        private Button buttonEditarCurso;
        private Button buttonFinalizarEdicion;
    }
}