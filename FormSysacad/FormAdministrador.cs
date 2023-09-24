using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuario;

namespace FormSysacad
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void buttonSeleccionDeOpcionadministrador_Click(object sender, EventArgs e)
        {
            if (!panelOpcionesAdministrador.Visible)
            {
                panelOpcionesAdministrador.Visible = true;

            }
            else
            {
                panelOpcionesAdministrador.Visible = false;
            }
        }

        private void buttonRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionAdminYEsconder("Registrar Estudiante");
            panelRegistrarEstudiante.Visible = true;
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionAdminYEsconder("Gestionar Cursos");
            panelRegistrarEstudiante.Visible = false;
        }

        private void SeleccionarOpcionAdminYEsconder(string opcion)
        {
            buttonSeleccionDeOpcionAdministrador.Text = opcion;
            panelOpcionesAdministrador.Visible = false;
        }

        private bool CorroborarCamposNoVacios()
        {
            if (!(string.IsNullOrEmpty(textBoxNombre.Text) ||
                  string.IsNullOrEmpty(textBoxCorreo.Text) ||
                  string.IsNullOrEmpty(textBoxNumTel.Text) ||
                  string.IsNullOrEmpty(textBoxDNI.Text) ||
                  string.IsNullOrEmpty(textBoxDireccion.Text) ||
                  string.IsNullOrEmpty(textBoxContraProv.Text) ||
                  string.IsNullOrEmpty(textBoxTipo.Text)))
            {
                return true;
            }
            return false;
        }

        private bool RegistrarPorFormulario()
        {
            Random random = new Random();
            int legajoNumerico = random.Next(110000, 120001);
            string legajoAutomatico = CorroborarExistenciaDeLegajo(legajoNumerico);
            
            Administrador nuevoUsuario = new Administrador(
                                                textBoxNombre.Text,
                                                textBoxDNI.Text,
                                                textBoxDireccion.Text,
                                                textBoxNumTel.Text,
                                                textBoxCorreo.Text,
                                                legajoAutomatico,
                                                textBoxContraProv.Text,
                                                textBoxTipo.Text);
            bool registrado = nuevoUsuario.RegistrarAdministradorOEstudiante(nuevoUsuario);

            if (!registrado)
            {
                return false;
            }
            return true;
        }

        private void buttonFormularioRegistrar_Click(object sender, EventArgs e)
        {
            if (!(CorroborarCamposNoVacios()))
            {
                labelErrorFormularioRegsitrarEstudiante.Visible = true;
            }
            else if (!(RegistrarPorFormulario()))
            {
                labelErrorFormularioRegsitrarEstudiante.Text = "¡ERROR! Documento o correo ya utilizado";
                labelErrorFormularioRegsitrarEstudiante.Visible = true;
            }
            else
            {
                labelErrorFormularioRegsitrarEstudiante.Visible = false;
            }
        }

        private string CorroborarExistenciaDeLegajo(int legajo)
        {
            string legajoParseado = legajo.ToString();
            List<Usuario> listaDeUsuarios = new List<Usuario>();
            listaDeUsuarios = Administrador.ReadStreamJSON("usuarios.json");

            if (listaDeUsuarios == null)
            {
                listaDeUsuarios = new List<Usuario>();
            }

            foreach (Usuario user in listaDeUsuarios)
            {
                if (legajoParseado == user.Legajo)
                {
                    Random random = new Random();
                    int legajoNumerico = random.Next(110000, 120001);
                    string legajoAutomatico = legajoNumerico.ToString();
                    return legajoAutomatico;
                }
            }
            return legajoParseado;
        }
    }
}
