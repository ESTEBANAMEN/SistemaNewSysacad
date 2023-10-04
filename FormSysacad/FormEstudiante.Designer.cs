namespace FormSysacad
{
    partial class FormEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiante));
            panelNegro = new Panel();
            imagenUTNFraUno = new PictureBox();
            TituloDelPrograma = new Label();
            panelInferior = new Panel();
            panelNegroIzquierda = new Panel();
            panelNegroDerecha = new Panel();
            labelSeleccionOpcionesEstudiante = new Label();
            panelMenuOpcionesEstudiante = new Panel();
            buttonRealizarPagos = new Button();
            buttonInscripcionDeCursos = new Button();
            buttonConsultarHorario = new Button();
            buttonSeleccionDeOpcionesEstudiante = new Button();
            pictureBoxUtnavellaneda = new PictureBox();
            panelInscripcionDeCursos = new Panel();
            label3 = new Label();
            label2 = new Label();
            panelInfoMaterias = new Panel();
            label1 = new Label();
            labelCupoMateriaAModificar = new Label();
            labelDescripcionMateriaAModificar = new Label();
            labelCodigoMateriaAModificar = new Label();
            labelCupoDisponible = new Label();
            labelDescripcion = new Label();
            labelCodigoMateria = new Label();
            buttonInscribirse = new Button();
            checkedListBoxMaterias = new CheckedListBox();
            panelNegro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).BeginInit();
            panelMenuOpcionesEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).BeginInit();
            panelInscripcionDeCursos.SuspendLayout();
            panelInfoMaterias.SuspendLayout();
            SuspendLayout();
            // 
            // panelNegro
            // 
            panelNegro.BackColor = Color.OrangeRed;
            panelNegro.Controls.Add(imagenUTNFraUno);
            panelNegro.Controls.Add(TituloDelPrograma);
            panelNegro.Dock = DockStyle.Top;
            panelNegro.Location = new Point(15, 0);
            panelNegro.Name = "panelNegro";
            panelNegro.Size = new Size(1413, 85);
            panelNegro.TabIndex = 16;
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
            TituloDelPrograma.Location = new Point(333, 9);
            TituloDelPrograma.Name = "TituloDelPrograma";
            TituloDelPrograma.Size = new Size(730, 59);
            TituloDelPrograma.TabIndex = 0;
            TituloDelPrograma.Text = "NUEVO SISTEMA SYSACAD: ESTUDIANTE";
            // 
            // panelInferior
            // 
            panelInferior.AutoScroll = true;
            panelInferior.BackColor = Color.OrangeRed;
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(15, 553);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1413, 15);
            panelInferior.TabIndex = 19;
            // 
            // panelNegroIzquierda
            // 
            panelNegroIzquierda.BackColor = Color.OrangeRed;
            panelNegroIzquierda.Dock = DockStyle.Left;
            panelNegroIzquierda.Location = new Point(0, 0);
            panelNegroIzquierda.Name = "panelNegroIzquierda";
            panelNegroIzquierda.Size = new Size(15, 568);
            panelNegroIzquierda.TabIndex = 18;
            // 
            // panelNegroDerecha
            // 
            panelNegroDerecha.BackColor = Color.OrangeRed;
            panelNegroDerecha.Dock = DockStyle.Right;
            panelNegroDerecha.Location = new Point(1428, 0);
            panelNegroDerecha.Name = "panelNegroDerecha";
            panelNegroDerecha.Size = new Size(15, 568);
            panelNegroDerecha.TabIndex = 17;
            // 
            // labelSeleccionOpcionesEstudiante
            // 
            labelSeleccionOpcionesEstudiante.Anchor = AnchorStyles.None;
            labelSeleccionOpcionesEstudiante.AutoSize = true;
            labelSeleccionOpcionesEstudiante.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionOpcionesEstudiante.Location = new Point(561, 107);
            labelSeleccionOpcionesEstudiante.Name = "labelSeleccionOpcionesEstudiante";
            labelSeleccionOpcionesEstudiante.Size = new Size(324, 48);
            labelSeleccionOpcionesEstudiante.TabIndex = 21;
            labelSeleccionOpcionesEstudiante.Text = "Bienvenido \"nombreDeEstudiante\"\r\nSeleccione la opción deseada:";
            labelSeleccionOpcionesEstudiante.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMenuOpcionesEstudiante
            // 
            panelMenuOpcionesEstudiante.Anchor = AnchorStyles.None;
            panelMenuOpcionesEstudiante.Controls.Add(buttonRealizarPagos);
            panelMenuOpcionesEstudiante.Controls.Add(buttonInscripcionDeCursos);
            panelMenuOpcionesEstudiante.Controls.Add(buttonConsultarHorario);
            panelMenuOpcionesEstudiante.Location = new Point(515, 187);
            panelMenuOpcionesEstudiante.Name = "panelMenuOpcionesEstudiante";
            panelMenuOpcionesEstudiante.Size = new Size(417, 99);
            panelMenuOpcionesEstudiante.TabIndex = 22;
            panelMenuOpcionesEstudiante.Visible = false;
            // 
            // buttonRealizarPagos
            // 
            buttonRealizarPagos.Anchor = AnchorStyles.None;
            buttonRealizarPagos.AutoSize = true;
            buttonRealizarPagos.BackgroundImageLayout = ImageLayout.None;
            buttonRealizarPagos.Cursor = Cursors.Hand;
            buttonRealizarPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonRealizarPagos.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizarPagos.ImageAlign = ContentAlignment.MiddleRight;
            buttonRealizarPagos.Location = new Point(0, 66);
            buttonRealizarPagos.Name = "buttonRealizarPagos";
            buttonRealizarPagos.Size = new Size(417, 33);
            buttonRealizarPagos.TabIndex = 13;
            buttonRealizarPagos.Text = "Realizar Pagos";
            buttonRealizarPagos.UseVisualStyleBackColor = true;
            buttonRealizarPagos.Click += buttonRealizarPagos_Click;
            // 
            // buttonInscripcionDeCursos
            // 
            buttonInscripcionDeCursos.Anchor = AnchorStyles.None;
            buttonInscripcionDeCursos.AutoSize = true;
            buttonInscripcionDeCursos.BackgroundImageLayout = ImageLayout.None;
            buttonInscripcionDeCursos.Cursor = Cursors.Hand;
            buttonInscripcionDeCursos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonInscripcionDeCursos.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInscripcionDeCursos.ImageAlign = ContentAlignment.MiddleRight;
            buttonInscripcionDeCursos.Location = new Point(0, 0);
            buttonInscripcionDeCursos.Name = "buttonInscripcionDeCursos";
            buttonInscripcionDeCursos.Size = new Size(417, 33);
            buttonInscripcionDeCursos.TabIndex = 1;
            buttonInscripcionDeCursos.Text = "Inscripción De Cursos";
            buttonInscripcionDeCursos.UseVisualStyleBackColor = true;
            buttonInscripcionDeCursos.Click += buttonInscripcionDeCursos_Click;
            // 
            // buttonConsultarHorario
            // 
            buttonConsultarHorario.Anchor = AnchorStyles.None;
            buttonConsultarHorario.AutoSize = true;
            buttonConsultarHorario.BackgroundImageLayout = ImageLayout.None;
            buttonConsultarHorario.Cursor = Cursors.Hand;
            buttonConsultarHorario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            buttonConsultarHorario.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultarHorario.ImageAlign = ContentAlignment.MiddleRight;
            buttonConsultarHorario.Location = new Point(0, 33);
            buttonConsultarHorario.Name = "buttonConsultarHorario";
            buttonConsultarHorario.Size = new Size(417, 33);
            buttonConsultarHorario.TabIndex = 2;
            buttonConsultarHorario.Text = "Consultar Horario:";
            buttonConsultarHorario.UseVisualStyleBackColor = true;
            buttonConsultarHorario.Click += buttonConsultarHorario_Click;
            // 
            // buttonSeleccionDeOpcionesEstudiante
            // 
            buttonSeleccionDeOpcionesEstudiante.Anchor = AnchorStyles.None;
            buttonSeleccionDeOpcionesEstudiante.AutoSize = true;
            buttonSeleccionDeOpcionesEstudiante.BackgroundImageLayout = ImageLayout.None;
            buttonSeleccionDeOpcionesEstudiante.Cursor = Cursors.Hand;
            buttonSeleccionDeOpcionesEstudiante.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeleccionDeOpcionesEstudiante.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeleccionDeOpcionesEstudiante.Location = new Point(515, 155);
            buttonSeleccionDeOpcionesEstudiante.Name = "buttonSeleccionDeOpcionesEstudiante";
            buttonSeleccionDeOpcionesEstudiante.Size = new Size(417, 33);
            buttonSeleccionDeOpcionesEstudiante.TabIndex = 20;
            buttonSeleccionDeOpcionesEstudiante.Text = "Opciones ▼";
            buttonSeleccionDeOpcionesEstudiante.UseVisualStyleBackColor = true;
            buttonSeleccionDeOpcionesEstudiante.Click += buttonSeleccionDeOpcionesEstudiante_Click;
            // 
            // pictureBoxUtnavellaneda
            // 
            pictureBoxUtnavellaneda.Anchor = AnchorStyles.None;
            pictureBoxUtnavellaneda.Image = (Image)resources.GetObject("pictureBoxUtnavellaneda.Image");
            pictureBoxUtnavellaneda.Location = new Point(386, 194);
            pictureBoxUtnavellaneda.Name = "pictureBoxUtnavellaneda";
            pictureBoxUtnavellaneda.Size = new Size(665, 140);
            pictureBoxUtnavellaneda.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUtnavellaneda.TabIndex = 23;
            pictureBoxUtnavellaneda.TabStop = false;
            // 
            // panelInscripcionDeCursos
            // 
            panelInscripcionDeCursos.Anchor = AnchorStyles.None;
            panelInscripcionDeCursos.AutoSize = true;
            panelInscripcionDeCursos.Controls.Add(label3);
            panelInscripcionDeCursos.Controls.Add(label2);
            panelInscripcionDeCursos.Controls.Add(panelInfoMaterias);
            panelInscripcionDeCursos.Controls.Add(buttonInscribirse);
            panelInscripcionDeCursos.Controls.Add(checkedListBoxMaterias);
            panelInscripcionDeCursos.Location = new Point(51, 194);
            panelInscripcionDeCursos.Name = "panelInscripcionDeCursos";
            panelInscripcionDeCursos.Size = new Size(1349, 353);
            panelInscripcionDeCursos.TabIndex = 24;
            panelInscripcionDeCursos.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(848, 2);
            label3.Name = "label3";
            label3.Size = new Size(148, 24);
            label3.TabIndex = 4;
            label3.Text = "Información:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(154, 2);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 3;
            label2.Text = "Materias:";
            // 
            // panelInfoMaterias
            // 
            panelInfoMaterias.Anchor = AnchorStyles.None;
            panelInfoMaterias.AutoSize = true;
            panelInfoMaterias.BackColor = SystemColors.GrayText;
            panelInfoMaterias.Controls.Add(label1);
            panelInfoMaterias.Controls.Add(labelCupoMateriaAModificar);
            panelInfoMaterias.Controls.Add(labelDescripcionMateriaAModificar);
            panelInfoMaterias.Controls.Add(labelCodigoMateriaAModificar);
            panelInfoMaterias.Controls.Add(labelCupoDisponible);
            panelInfoMaterias.Controls.Add(labelDescripcion);
            panelInfoMaterias.Controls.Add(labelCodigoMateria);
            panelInfoMaterias.Location = new Point(480, 27);
            panelInfoMaterias.Name = "panelInfoMaterias";
            panelInfoMaterias.Size = new Size(848, 247);
            panelInfoMaterias.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(531, 2);
            label1.Name = "label1";
            label1.Size = new Size(313, 72);
            label1.TabIndex = 3;
            label1.Text = "¡Por favor corrobore las materias\r\nseleccionadas antes de presionar\r\nel botón de inscripción!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCupoMateriaAModificar
            // 
            labelCupoMateriaAModificar.Anchor = AnchorStyles.None;
            labelCupoMateriaAModificar.AutoSize = true;
            labelCupoMateriaAModificar.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCupoMateriaAModificar.ForeColor = Color.Red;
            labelCupoMateriaAModificar.Location = new Point(263, 196);
            labelCupoMateriaAModificar.Name = "labelCupoMateriaAModificar";
            labelCupoMateriaAModificar.Size = new Size(48, 27);
            labelCupoMateriaAModificar.TabIndex = 5;
            labelCupoMateriaAModificar.Text = "----";
            // 
            // labelDescripcionMateriaAModificar
            // 
            labelDescripcionMateriaAModificar.Anchor = AnchorStyles.None;
            labelDescripcionMateriaAModificar.AutoSize = true;
            labelDescripcionMateriaAModificar.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcionMateriaAModificar.ForeColor = Color.FromArgb(0, 0, 192);
            labelDescripcionMateriaAModificar.Location = new Point(210, 107);
            labelDescripcionMateriaAModificar.Name = "labelDescripcionMateriaAModificar";
            labelDescripcionMateriaAModificar.Size = new Size(48, 27);
            labelDescripcionMateriaAModificar.TabIndex = 4;
            labelDescripcionMateriaAModificar.Text = "----";
            // 
            // labelCodigoMateriaAModificar
            // 
            labelCodigoMateriaAModificar.Anchor = AnchorStyles.None;
            labelCodigoMateriaAModificar.AutoSize = true;
            labelCodigoMateriaAModificar.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoMateriaAModificar.ForeColor = Color.Gold;
            labelCodigoMateriaAModificar.Location = new Point(141, 24);
            labelCodigoMateriaAModificar.Name = "labelCodigoMateriaAModificar";
            labelCodigoMateriaAModificar.Size = new Size(48, 27);
            labelCodigoMateriaAModificar.TabIndex = 3;
            labelCodigoMateriaAModificar.Text = "----";
            // 
            // labelCupoDisponible
            // 
            labelCupoDisponible.Anchor = AnchorStyles.None;
            labelCupoDisponible.AutoSize = true;
            labelCupoDisponible.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCupoDisponible.Location = new Point(18, 196);
            labelCupoDisponible.Name = "labelCupoDisponible";
            labelCupoDisponible.Size = new Size(217, 27);
            labelCupoDisponible.TabIndex = 2;
            labelCupoDisponible.Text = "Cupo Disponible:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.None;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(18, 107);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(162, 27);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripción:";
            // 
            // labelCodigoMateria
            // 
            labelCodigoMateria.Anchor = AnchorStyles.None;
            labelCodigoMateria.AutoSize = true;
            labelCodigoMateria.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoMateria.Location = new Point(18, 24);
            labelCodigoMateria.Name = "labelCodigoMateria";
            labelCodigoMateria.Size = new Size(102, 27);
            labelCodigoMateria.TabIndex = 0;
            labelCodigoMateria.Text = "Código:";
            // 
            // buttonInscribirse
            // 
            buttonInscribirse.Anchor = AnchorStyles.None;
            buttonInscribirse.BackColor = Color.Lime;
            buttonInscribirse.BackgroundImageLayout = ImageLayout.Center;
            buttonInscribirse.Cursor = Cursors.Hand;
            buttonInscribirse.FlatStyle = FlatStyle.Popup;
            buttonInscribirse.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInscribirse.Location = new Point(480, 280);
            buttonInscribirse.Name = "buttonInscribirse";
            buttonInscribirse.Size = new Size(848, 60);
            buttonInscribirse.TabIndex = 2;
            buttonInscribirse.Text = "Inscribirse";
            buttonInscribirse.UseVisualStyleBackColor = false;
            buttonInscribirse.Click += buttonInscribirse_Click;
            // 
            // checkedListBoxMaterias
            // 
            checkedListBoxMaterias.Anchor = AnchorStyles.None;
            checkedListBoxMaterias.BackColor = Color.DarkBlue;
            checkedListBoxMaterias.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxMaterias.CheckOnClick = true;
            checkedListBoxMaterias.Cursor = Cursors.Hand;
            checkedListBoxMaterias.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxMaterias.ForeColor = SystemColors.InactiveBorder;
            checkedListBoxMaterias.FormattingEnabled = true;
            checkedListBoxMaterias.Location = new Point(8, 27);
            checkedListBoxMaterias.Name = "checkedListBoxMaterias";
            checkedListBoxMaterias.Size = new Size(450, 302);
            checkedListBoxMaterias.TabIndex = 0;
            // 
            // FormEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 568);
            Controls.Add(panelNegro);
            Controls.Add(panelInferior);
            Controls.Add(panelNegroIzquierda);
            Controls.Add(panelNegroDerecha);
            Controls.Add(labelSeleccionOpcionesEstudiante);
            Controls.Add(panelMenuOpcionesEstudiante);
            Controls.Add(buttonSeleccionDeOpcionesEstudiante);
            Controls.Add(panelInscripcionDeCursos);
            Controls.Add(pictureBoxUtnavellaneda);
            Name = "FormEstudiante";
            Text = "FormEstudiante";
            panelNegro.ResumeLayout(false);
            panelNegro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenUTNFraUno).EndInit();
            panelMenuOpcionesEstudiante.ResumeLayout(false);
            panelMenuOpcionesEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUtnavellaneda).EndInit();
            panelInscripcionDeCursos.ResumeLayout(false);
            panelInscripcionDeCursos.PerformLayout();
            panelInfoMaterias.ResumeLayout(false);
            panelInfoMaterias.PerformLayout();
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
        private Label labelSeleccionOpcionesEstudiante;
        private Panel panelMenuOpcionesEstudiante;
        private Button buttonRealizarPagos;
        private Button buttonInscripcionDeCursos;
        private Button buttonConsultarHorario;
        private Button buttonSeleccionDeOpcionesEstudiante;
        private PictureBox pictureBoxUtnavellaneda;
        private Panel panelInscripcionDeCursos;
        private CheckedListBox checkedListBoxMaterias;
        private Panel panelInfoMaterias;
        private Label label4;
        private Label labelCodigoMateria;
        private Label labelCupoDisponible;
        private Label labelDescripcion;
        private Label labelCodigoMateriaAModificar;
        private Label labelCupoMateriaAModificar;
        private Label labelDescripcionMateriaAModificar;
        private Label label1;
        private Button buttonInscribirse;
        private Label label3;
        private Label label2;
    }
}