using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuario;
using AccesoriosUtils;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private void SeleccionarOpcionAdminYEsconder(string opcion)
        {
            buttonSeleccionDeOpcionAdministrador.Text = opcion;
            panelOpcionesAdministrador.Visible = false;
        }
        private void buttonRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionAdminYEsconder(buttonRegistrarEstudiante.Text);
            panelRegistrarEstudiante.Visible = true;
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionAdminYEsconder("Gestionar Cursos");
            panelRegistrarEstudiante.Visible = false;
        }

        private bool CorroborarDatos(string nombre, string documento, string direccion,
                                     string numero, string correo, string contra, string tipo)
        {
            bool datosCorrectos = true;
            Accesorios accesorios = new Accesorios();

            void VerificarCampo(bool esValido, TextBox campo, Label etiqueta)
            {
                if (!esValido)
                {
                    campo.ForeColor = Color.Red;
                    etiqueta.ForeColor = Color.Red;
                    datosCorrectos = false;
                }
                else
                {
                    campo.ForeColor = Color.Black;
                    etiqueta.ForeColor = Color.Black;
                }
            }

            VerificarCampo(!string.IsNullOrEmpty(nombre) && accesorios.CorroborarTextoYEspacio(nombre), textBoxNombre, labelFormularioNombre);
            VerificarCampo(!string.IsNullOrEmpty(documento) && accesorios.CorroborarNumerico(documento), textBoxDNI, labelFormularioDNI);
            VerificarCampo(!string.IsNullOrEmpty(direccion) && accesorios.CorroborarTextoConNumero(direccion), textBoxDireccion, labelFormularioDireccion);
            VerificarCampo(!string.IsNullOrEmpty(numero) && accesorios.CorroborarNumerico(numero), textBoxNumTel, labelFormularioNumTel);
            VerificarCampo(!string.IsNullOrEmpty(correo) && accesorios.CorroborarCorreoElectronico(correo), textBoxCorreo, labelFormularioCorreo);
            VerificarCampo(!string.IsNullOrEmpty(contra), textBoxContraProv, labelFormularioContraseña);
            VerificarCampo(tipo == "Administrador" || tipo == "Estudiante", textBoxTipo, labelFormularioTipoDeUsuario);
            return datosCorrectos;
        }


        private bool RegistrarPorFormulario()
        {
            Random random = new Random();
            int legajoNumerico = random.Next(110000, 120001);
            string legajoAutomatico = CorroborarExistenciaDeLegajo(legajoNumerico);
            bool registrado = false;

            Administrador nuevoUsuario = new Administrador(textBoxNombre.Text,
                                                           textBoxDNI.Text,
                                                           textBoxDireccion.Text,
                                                           textBoxNumTel.Text,
                                                           textBoxCorreo.Text,
                                                           legajoAutomatico,
                                                           textBoxContraProv.Text,
                                                           textBoxTipo.Text);
            if (CorroborarDatos(textBoxNombre.Text,
                                textBoxDNI.Text,
                                textBoxDireccion.Text,
                                textBoxNumTel.Text,
                                textBoxCorreo.Text,
                                textBoxContraProv.Text,
                                textBoxTipo.Text))
            {
                registrado = nuevoUsuario.RegistrarAdministradorOEstudiante(nuevoUsuario);
                if (!registrado)
                {
                    labelErrorFormularioRegsitrarEstudiante.Text = "¡Usuario existente!";
                }
            }

            return registrado;
        }

        private void buttonFormularioRegistrar_Click(object sender, EventArgs e)
        {
            if ((!(RegistrarPorFormulario())))
            {
                labelErrorFormularioRegsitrarEstudiante.Visible = true;
            }
            else
            {
                labelErrorFormularioRegsitrarEstudiante.Visible = false;
                panelRegistrarEstudiante.Visible = false;
                labelSeleccionDeOpcionAdministrador.Visible = false;
                buttonSeleccionDeOpcionAdministrador.Visible = false;
                panelExitoAlGenerar.Visible = true;
                buttonenviarAlMailYSalir.Text = $"Enviar datos al correo {textBoxCorreo.Text} y cerrar";                
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

        private void buttonenviarAlMailYSalir_Click(object sender, EventArgs e)
        {
            if(Administrador.EnviarMail(textBoxCorreo.Text))
            {
                this.Close();
                FormAdministrador formAdmin = new FormAdministrador();
                formAdmin.Show();
            }
        }
    }
}
