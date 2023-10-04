using Cursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuario;

namespace FormSysacad
{
    public partial class FormEstudiante : Form
    {
        private List<Curso> listaDeCursos;

        public FormEstudiante()
        {
            InitializeComponent();

            listaDeCursos = LeerCursosDesdeArchivo();

            RellenarLabels();

            checkedListBoxMaterias.ItemCheck += checkedListBoxMaterias_ItemCheck;
        }

        private void buttonSeleccionDeOpcionesEstudiante_Click(object sender, EventArgs e)
        {
            if (!panelMenuOpcionesEstudiante.Visible)
            {
                panelMenuOpcionesEstudiante.Visible = true;
            }
            else
            {
                panelMenuOpcionesEstudiante.Visible = false;
            }
        }

        private void buttonInscripcionDeCursos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionEstudianteYEsconder(buttonInscripcionDeCursos.Text);
            panelInscripcionDeCursos.Visible = true;
        }

        private void buttonConsultarHorario_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionEstudianteYEsconder(buttonConsultarHorario.Text);
            panelInscripcionDeCursos.Visible = false;
        }

        private void buttonRealizarPagos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionEstudianteYEsconder(buttonRealizarPagos.Text);
            panelInscripcionDeCursos.Visible = false;
        }

        private void SeleccionarOpcionEstudianteYEsconder(string opcion)
        {
            buttonSeleccionDeOpcionesEstudiante.Text = opcion;
            panelMenuOpcionesEstudiante.Visible = false;
        }

        private void RellenarLabels()
        {
            foreach (Curso curso in listaDeCursos)
            {
                checkedListBoxMaterias.Items.Add(curso.Nombre);
            }
        }

        private void checkedListBoxMaterias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indice = e.Index;

            if (indice != -1)
            {
                labelCodigoMateriaAModificar.Text = listaDeCursos[indice].Codigo;
                labelDescripcionMateriaAModificar.Text = listaDeCursos[indice].Descripcion;
                labelCupoMateriaAModificar.Text = listaDeCursos[indice].CupoMaximo;
                if (int.Parse(labelCupoMateriaAModificar.Text) > 50)
                {
                    labelCupoMateriaAModificar.ForeColor = Color.Lime;
                }
                else if (int.Parse(labelCupoMateriaAModificar.Text) > 20)
                {
                    labelCupoMateriaAModificar.ForeColor = Color.Yellow;
                }
                else
                {
                    labelCupoMateriaAModificar.ForeColor = Color.Red;
                }
            }
        }

        private List<Curso> LeerCursosDesdeArchivo()
        {
            List<Curso> listaDeCursos = Administrador.ReadStreamJSON<Curso>("cursos.json");
            if (listaDeCursos == null)
            {
                listaDeCursos = new List<Curso>();
            }
            return listaDeCursos;
        }

        private void buttonInscribirse_Click(object sender, EventArgs e)
        {
            if (!CorroborarCupoDisponible())
            {
                MessageBox.Show("¡Error! Corrobore los cupos disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormPrograma programaForm = new FormPrograma();
                Estudiante estudiante = (Estudiante)programaForm.RetornarEstudiante();

                List<Usuario> listaDeUsuarios = Administrador.ReadStreamJSON<Usuario>("usuarios.json");

                if (listaDeUsuarios == null)
                {
                    listaDeUsuarios = new List<Usuario>();
                }

                List<string> cursosSeleccionados = new List<string>();
                for (int i = 0; i < checkedListBoxMaterias.Items.Count; i++)
                {
                    if (checkedListBoxMaterias.GetItemChecked(i))
                    {
                        cursosSeleccionados.Add(checkedListBoxMaterias.Items[i].ToString());
                    }
                }

                foreach (Usuario usuario in listaDeUsuarios)
                {
                    if (usuario.Legajo == estudiante.Legajo)
                    {
                        List<Curso> cursosParaInscribir = new List<Curso>();

                        foreach (string nombreCurso in cursosSeleccionados)
                        {
                            Curso cursoEncontrado = null;

                            foreach (Curso curso in listaDeCursos)
                            {
                                if (curso.Nombre == nombreCurso)
                                {
                                    cursoEncontrado = curso;
                                    break; 
                                }
                            }

                            if (cursoEncontrado != null)
                            {
                                cursosParaInscribir.Add(cursoEncontrado);
                            }
                        }
                        estudiante.CursosInscritos.AddRange(cursosParaInscribir);
                    }
                }
            }
        }


        private bool CorroborarCupoDisponible()
        {
            listaDeCursos = LeerCursosDesdeArchivo();
            bool hayCupo = true;

            for (int i = 0; i < listaDeCursos.Count; i++)
            {
                if (checkedListBoxMaterias.GetItemChecked(i))
                {
                    if (int.Parse(listaDeCursos[i].CupoMaximo) == 0)
                    {
                        hayCupo = false;
                        break;
                    }
                }
            }

            if (hayCupo)
            {
                for (int i = 0; i < listaDeCursos.Count; i++)
                {
                    if (checkedListBoxMaterias.GetItemChecked(i))
                    {
                        int nuevoCupo = int.Parse(listaDeCursos[i].CupoMaximo) - 1;
                        listaDeCursos[i].CupoMaximo = nuevoCupo.ToString();
                    }
                }
                Administrador.WriteStreamJSON("cursos.json", listaDeCursos);
            }
            return hayCupo;
        }
    }
}
