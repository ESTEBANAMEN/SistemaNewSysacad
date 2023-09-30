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
using Cursos;

namespace FormSysacad
{
    public partial class FormAdministrador : Form
    {
        private int indiceDeRenglon = 0;
        public FormAdministrador()
        {
            InitializeComponent();

            dataGridCursos.SelectionChanged += new EventHandler(dataGridCursos_SelectionChanged);

            Administrador administrador = new Administrador();

            Curso programacion = new Curso("Programación",
                                           "pyl1",
                                           "Turnos Mañana/Tarde/Noche",
                                           "150");

            administrador.GestionarCurso(programacion);
            RellenarTablaDeCurso();
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
            panelGestionarCursos.Visible = false;
            panelRegistrarEstudiante.Visible = true;
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionAdminYEsconder(buttonGestionarCursos.Text);
            panelRegistrarEstudiante.Visible = false;
            panelGestionarCursos.Visible = true;
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
            VerificarCampo(!string.IsNullOrEmpty(direccion) && accesorios.CorroborarTextoConNumeroConEspacio(direccion), textBoxDireccion, labelFormularioDireccion);
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
            listaDeUsuarios = Administrador.ReadStreamJSON<Usuario>("usuarios.json");

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
            if (Administrador.EnviarMail(textBoxCorreo.Text))
            {
                this.Close();
                FormAdministrador formAdmin = new FormAdministrador();
                formAdmin.Show();
            }
        }

        private void RellenarTablaDeCurso()
        {
            List<Curso> listaDeCursos = new List<Curso>();
            listaDeCursos = Administrador.ReadStreamJSON<Curso>("cursos.json");

            if (listaDeCursos == null)
            {
                listaDeCursos = new List<Curso>();
            }
            dataGridCursos.Columns.Clear();

            dataGridCursos.DataSource = listaDeCursos;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (RegistrarCursoPorFormulario())
            {
                RellenarTablaDeCurso();
                LimpiarCampos();
            }
        }

        private bool CorroborarCamposCorrectosCursos(string nombre, string codigo, string descripcion, string cupo)
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
            VerificarCampo(!string.IsNullOrEmpty(nombre) && accesorios.CorroborarTextoYEspacio(nombre), textBoxNombreCurso, labelNombreCurso);
            VerificarCampo(!string.IsNullOrEmpty(codigo) && accesorios.CorroborarTextoConNumeroSinEspacio(codigo), textBoxCodigoCurso, labelCodigoCurso);
            VerificarCampo(!string.IsNullOrEmpty(descripcion) && accesorios.CorroborarTextoYEspacio(descripcion), textBoxDescripcionCurso, labelDescripcionCurso);
            VerificarCampo(!string.IsNullOrEmpty(cupo) && accesorios.CorroborarNumerico(cupo), textBoxCupoCurso, labelCupoCurso);
            return datosCorrectos;
        }

        private bool RegistrarCursoPorFormulario()
        {
            bool registrado = false;
            Administrador admin = new Administrador();
            Curso curso = new Curso(textBoxNombreCurso.Text,
                                         textBoxCodigoCurso.Text,
                                         textBoxDescripcionCurso.Text,
                                         textBoxCupoCurso.Text);

            if (CorroborarCamposCorrectosCursos(textBoxNombreCurso.Text,
                                               textBoxCodigoCurso.Text,
                                               textBoxDescripcionCurso.Text,
                                               textBoxCupoCurso.Text))
            {
                registrado = admin.GestionarCurso(curso);
                if (!registrado)
                {
                    MessageBox.Show("¡Error! El curso ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return registrado;
        }

        private void dataGridCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCursos.SelectedRows.Count > 0)
            {
                indiceDeRenglon = dataGridCursos.SelectedRows[0].Index;
            }
        }

        private void buttonEditarCurso_Click(object sender, EventArgs e)
        {
            buttonFinalizarEdicion.Visible = true;
            buttonAgregar.Visible = false;


            DataGridViewRow row = dataGridCursos.Rows[indiceDeRenglon];
            textBoxNombreCurso.Text = row.Cells[0].Value.ToString();
            textBoxCodigoCurso.Text = row.Cells[1].Value.ToString();
            textBoxDescripcionCurso.Text = row.Cells[2].Value.ToString();
            textBoxCupoCurso.Text = row.Cells[3].Value.ToString();
        }

        private void buttonFinalizarEdicion_Click(object sender, EventArgs e)
        {
            List<Curso> listaDeCursos = new List<Curso>();
            listaDeCursos = Administrador.ReadStreamJSON<Curso>("cursos.json");
            if (listaDeCursos == null)
            {
                listaDeCursos = new List<Curso>();
            }

            Curso curso = new Curso(textBoxNombreCurso.Text,
                                    textBoxCodigoCurso.Text,
                                    textBoxDescripcionCurso.Text,
                                    textBoxCupoCurso.Text);

            listaDeCursos[indiceDeRenglon] = curso;
            Administrador.WriteStreamJSON<Curso>("cursos.json", listaDeCursos);
            RellenarTablaDeCurso();
            buttonFinalizarEdicion.Visible = false;
            buttonAgregar.Visible = true;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxNombreCurso.Text = "";
            textBoxCodigoCurso.Text = "";
            textBoxDescripcionCurso.Text = "";
            textBoxCupoCurso.Text = "";
        }
    }
}