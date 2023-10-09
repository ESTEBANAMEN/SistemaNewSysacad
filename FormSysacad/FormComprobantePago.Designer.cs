namespace FormSysacad
{
    partial class FormComprobantePago
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
            labelTituloComprobanteDePago = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelNombreComprobante = new Label();
            labelFechaComprobante = new Label();
            labelConceptoComprobante = new Label();
            labelTotalPagado = new Label();
            buttonDescargar = new Button();
            SuspendLayout();
            // 
            // labelTituloComprobanteDePago
            // 
            labelTituloComprobanteDePago.Anchor = AnchorStyles.None;
            labelTituloComprobanteDePago.AutoSize = true;
            labelTituloComprobanteDePago.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTituloComprobanteDePago.Location = new Point(69, 9);
            labelTituloComprobanteDePago.Name = "labelTituloComprobanteDePago";
            labelTituloComprobanteDePago.Size = new Size(178, 24);
            labelTituloComprobanteDePago.TabIndex = 0;
            labelTituloComprobanteDePago.Text = "Comprobante de Pago";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 3;
            label3.Text = "Concepto:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
            label4.TabIndex = 4;
            label4.Text = "Total Pagado:";
            // 
            // labelNombreComprobante
            // 
            labelNombreComprobante.Anchor = AnchorStyles.None;
            labelNombreComprobante.AutoSize = true;
            labelNombreComprobante.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreComprobante.Location = new Point(92, 88);
            labelNombreComprobante.Name = "labelNombreComprobante";
            labelNombreComprobante.Size = new Size(74, 24);
            labelNombreComprobante.TabIndex = 5;
            labelNombreComprobante.Text = "Nombre:";
            // 
            // labelFechaComprobante
            // 
            labelFechaComprobante.Anchor = AnchorStyles.None;
            labelFechaComprobante.AutoSize = true;
            labelFechaComprobante.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFechaComprobante.Location = new Point(92, 146);
            labelFechaComprobante.Name = "labelFechaComprobante";
            labelFechaComprobante.Size = new Size(74, 24);
            labelFechaComprobante.TabIndex = 6;
            labelFechaComprobante.Text = "Nombre:";
            // 
            // labelConceptoComprobante
            // 
            labelConceptoComprobante.Anchor = AnchorStyles.None;
            labelConceptoComprobante.AutoSize = true;
            labelConceptoComprobante.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelConceptoComprobante.Location = new Point(103, 205);
            labelConceptoComprobante.Name = "labelConceptoComprobante";
            labelConceptoComprobante.Size = new Size(74, 24);
            labelConceptoComprobante.TabIndex = 7;
            labelConceptoComprobante.Text = "Nombre:";
            // 
            // labelTotalPagado
            // 
            labelTotalPagado.Anchor = AnchorStyles.None;
            labelTotalPagado.AutoSize = true;
            labelTotalPagado.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPagado.Location = new Point(129, 268);
            labelTotalPagado.Name = "labelTotalPagado";
            labelTotalPagado.Size = new Size(74, 24);
            labelTotalPagado.TabIndex = 8;
            labelTotalPagado.Text = "Nombre:";
            // 
            // buttonDescargar
            // 
            buttonDescargar.Anchor = AnchorStyles.None;
            buttonDescargar.AutoSize = true;
            buttonDescargar.Location = new Point(12, 322);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(305, 30);
            buttonDescargar.TabIndex = 9;
            buttonDescargar.Text = "Descargar Comprobante y Salir";
            buttonDescargar.UseVisualStyleBackColor = true;
            buttonDescargar.Click += buttonDescargar_Click;
            // 
            // FormComprobantePago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(341, 363);
            Controls.Add(buttonDescargar);
            Controls.Add(labelTotalPagado);
            Controls.Add(labelConceptoComprobante);
            Controls.Add(labelFechaComprobante);
            Controls.Add(labelNombreComprobante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTituloComprobanteDePago);
            Name = "FormComprobantePago";
            Text = "FormComprobantePago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTituloComprobanteDePago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelNombreComprobante;
        private Label labelFechaComprobante;
        private Label labelConceptoComprobante;
        private Label labelTotalPagado;
        private Button buttonDescargar;
    }
}