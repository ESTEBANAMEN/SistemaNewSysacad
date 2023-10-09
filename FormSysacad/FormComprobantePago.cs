using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSysacad
{
    public partial class FormComprobantePago : Form
    {
        public FormComprobantePago(string nombre, string total)
        {
            InitializeComponent();
            DateTime fechaActual = DateTime.Now;

            labelNombreComprobante.Text = nombre;
            labelConceptoComprobante.Text = "UTN-Fra";
            labelFechaComprobante.Text = fechaActual.ToString();
            labelTotalPagado.Text = total;
        }

        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su descarga se realizó con exito", "¡Descarga Exitosa!", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
