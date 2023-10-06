using System.Drawing.Text;
using System.Security.Cryptography.Xml;
using TiposDeUsuario;
using static TiposDeUsuario.Administrador;

namespace FormSysacad
{   
    public partial class FormPrograma : Form
    {
        private string? _usuario;
        private Estudiante estudianteRetorno;

        public FormPrograma()
        {
            InitializeComponent();
            Administrador superAdmin = new Administrador(
                                                "Esteban Amen",
                                                "38837906",
                                                "Murature 3925",
                                                "1157587325",
                                                "stebanamen@gmail.com",
                                                "114389",
                                                "1234",
                                                "Administrador");
            superAdmin.RegistrarAdministrador(superAdmin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panelMenuDeUsuarios.Visible)
            {
                panelMenuDeUsuarios.Visible = true;
            }
            else
            {
                panelMenuDeUsuarios.Visible = false;
            }
        }

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            _usuario = SeleccionarUsuarioYEsconder("Administrador");
        }

        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            _usuario = SeleccionarUsuarioYEsconder("Profesor");
        }

        private void buttonEstudiante_Click(object sender, EventArgs e)
        {
            _usuario = SeleccionarUsuarioYEsconder("Estudiante");
        }

        private string SeleccionarUsuarioYEsconder(string usuario)
        {
            buttonSeleccionDeUsuario.Text = usuario;
            panelMenuDeUsuarios.Visible = false;
            return usuario;
        }


        private void buttonDeIngreso_Click(object sender, EventArgs e)
        {
            string legajo = textBoxLegajo.Text;
            string contra = textBoxContrasenia.Text;

            List<Usuario> listaDeAdministradores = ReadStreamJSON<Usuario>("administradores.json");
            List<Estudiante> listaDeEstudiantes = ReadStreamJSON<Estudiante>("estudiantes.json");

            if (listaDeAdministradores == null || listaDeEstudiantes == null)
            {
                listaDeAdministradores = new List<Usuario>();
                listaDeEstudiantes = new List<Estudiante>();
            }

            bool usuarioEncontrado = false;

            switch (_usuario)
            {
                case "Administrador":
                    foreach (Usuario usuario in listaDeAdministradores)
                    {
                        if (usuario.Legajo == legajo && usuario.Contrasenia == contra && usuario.TipoDeUsuario == "Administrador")
                        {
                            usuarioEncontrado = true;
                            labelErrorIdContra.Visible = false;
                            FormAdministrador formAdmin = new FormAdministrador();
                            formAdmin.Show();
                            break;
                        }
                    }
                    break;
                case "Profesor":
                    break;
                case "Estudiante":
                    foreach (Estudiante estudiante in listaDeEstudiantes)
                    {
                        if (estudiante.Legajo == legajo && estudiante.Contrasenia == contra && estudiante.TipoDeUsuario == "Estudiante")
                        {
                            estudianteRetorno = estudiante;
                            usuarioEncontrado = true;
                            labelErrorIdContra.Visible = false;
                            FormEstudiante formEstudiante = new FormEstudiante(this);
                            formEstudiante.Show();
                        }
                    }
                    break;
                default:
                    break;
            }

            if (!usuarioEncontrado)
            {
                MostrarMensajeError();
            }
        }


        private void MostrarMensajeError()
        {
            MessageBox.Show("¡Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            labelErrorIdContra.Visible = true;
        }

        public Estudiante RetornarEstudiante()
        {
            return estudianteRetorno;
        }

    }
}