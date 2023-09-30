using System.Drawing.Text;
using System.Security.Cryptography.Xml;
using TiposDeUsuario;
using static TiposDeUsuario.Administrador;

namespace FormSysacad
{
    public partial class FormPrograma : Form
    {
        private string? _usuario;

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
            superAdmin.RegistrarAdministradorOEstudiante(superAdmin);
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

            List<Usuario> listaDeUsuarios = ReadStreamJSON<Usuario>("usuarios.json");

            if (listaDeUsuarios == null)
            {
                listaDeUsuarios = new List<Usuario>();
            }

            switch (_usuario)
            {
                case "Administrador":
                    foreach (Usuario usuario in listaDeUsuarios)
                    {
                        if (usuario.Legajo == legajo && usuario.Contrasenia == contra)
                        {
                            labelErrorIdContra.Visible = false;
                            FormAdministrador formAdmin = new FormAdministrador();
                            formAdmin.Show();
                            break;
                        }
                        else
                        {
                            labelErrorIdContra.Visible = true;
                        }
                    }
                    break;
                case "Profesor":
                    break;
                case "Estudiante":
                    break;
                default:
                    labelErrorIdContra.Visible = true;
                    break;
            }
        }
    }
}