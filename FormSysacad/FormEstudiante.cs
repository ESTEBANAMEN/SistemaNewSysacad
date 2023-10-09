using AccesoriosUtils;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormSysacad
{
    public partial class FormEstudiante : Form
    {
        private List<Curso> listaDeCursos;
        private FormPrograma programaForm;
        int totalAPagar = 0;
        bool banderaDePago = false;
        public FormEstudiante(FormPrograma programaForm)
        {
            InitializeComponent();

            this.programaForm = programaForm;

            listaDeCursos = LeerCursosDesdeArchivo();

            RellenarLabels();
            RellenarComboBoxMateriasYLabels();
            AsignarDiaHorarioAula();

            checkedListBoxMaterias.ItemCheck += checkedListBoxMaterias_ItemCheck;

            Estudiante estudianteActual = programaForm.RetornarEstudiante();
            labelSeleccionOpcionesEstudiante.Text = $"Bienvenido {estudianteActual.NombreCompleto}{Environment.NewLine}Seleccione la opción deseada:";
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
            panelConsultarHorario.Visible = false;
            panelRealizarPagos.Visible = false;
        }

        private void buttonConsultarHorario_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionEstudianteYEsconder(buttonConsultarHorario.Text);
            panelInscripcionDeCursos.Visible = false;
            panelConsultarHorario.Visible = true;
            panelRealizarPagos.Visible = false;
        }

        private void buttonRealizarPagos_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionEstudianteYEsconder(buttonRealizarPagos.Text);
            panelInscripcionDeCursos.Visible = false;
            panelConsultarHorario.Visible = false;
            panelRealizarPagos.Visible = true;
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
            List<int> cursosSeleccionados = new List<int>();

            for (int i = 0; i < checkedListBoxMaterias.Items.Count; i++)
            {
                if (checkedListBoxMaterias.GetItemChecked(i))
                {
                    cursosSeleccionados.Add(i);
                }
            }

            if (!CorroborarCupoDisponible(cursosSeleccionados))
            {
                MessageBox.Show("¡Error! Corrobore los cupos disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CorroborarExistenciaDeCursos(cursosSeleccionados))
            {
                MessageBox.Show("¡Error! Usted ya está inscrito en alguno de los cursos seleccionados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cursosSeleccionados.Count == 0)
            {
                MessageBox.Show("¡Error! Usted no seleccionó ningún curso.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Estudiante estudianteActual = programaForm.RetornarEstudiante();
                List<string> listaDeNombres = new List<string>();

                foreach (int indice in cursosSeleccionados)
                {
                    string nombreCurso = listaDeCursos[indice].Nombre;

                    if (!estudianteActual.CursosInscritos.Contains(nombreCurso))
                    {
                        listaDeNombres.Add(nombreCurso);
                    }
                    else
                    {
                        MessageBox.Show($"¡Error! Ya está inscrito en el curso {nombreCurso}.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                estudianteActual.CursosInscritos.AddRange(listaDeNombres);

                List<Estudiante> listaDeEstudiantes = Administrador.ReadStreamJSON<Estudiante>("estudiantes.json");

                if (listaDeEstudiantes == null)
                {
                    listaDeEstudiantes = new List<Estudiante>();
                }

                int contador = 0;
                int index = 0;
                foreach (Estudiante estudiante in listaDeEstudiantes)
                {
                    if (estudiante.Legajo == estudianteActual.Legajo)
                    {
                        index = contador;
                        break;
                    }
                    contador++;
                }

                listaDeEstudiantes[index] = estudianteActual;

                for (int i = 0; i < listaDeCursos.Count; i++)
                {
                    if (cursosSeleccionados.Contains(i))
                    {
                        int nuevoCupo = int.Parse(listaDeCursos[i].CupoMaximo) - 1;
                        listaDeCursos[i].CupoMaximo = nuevoCupo.ToString();
                    }
                }

                Administrador.WriteStreamJSON("cursos.json", listaDeCursos);
                Administrador.WriteStreamJSON("estudiantes.json", listaDeEstudiantes);
                MessageBox.Show("¡Felicidades! Usted ha sido inscrito exitosamente en los cursos seleccionados.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormEstudiante formEstudiante = new FormEstudiante(programaForm);
                formEstudiante.Show();
            }
        }


        private bool CorroborarCupoDisponible(List<int> cursosSeleccionados)
        {
            foreach (int indice in cursosSeleccionados)
            {
                int cupo = int.Parse(listaDeCursos[indice].CupoMaximo);
                if (cupo == 0)
                {
                    return false;
                }
            }
            return true;
        }


        private bool CorroborarExistenciaDeCursos(List<int> cursosSeleccionados)
        {
            Estudiante estudianteActual = programaForm.RetornarEstudiante();

            if (estudianteActual.CursosInscritos == null)
            {
                return true;
            }

            foreach (int indice in cursosSeleccionados)
            {
                string cursoSeleccionado = listaDeCursos[indice].Nombre;
                if (estudianteActual.CursosInscritos.Contains(cursoSeleccionado))
                {
                    return false;
                }
            }
            return true;
        }

        private void comboBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cursoSeleccionado = comboBoxMaterias.SelectedItem.ToString();

            foreach (Curso curso in listaDeCursos)
            {
                if (curso.Nombre == cursoSeleccionado)
                {
                    labelAulaHorarios.Text = curso.Aula;
                    labelDiaHorarios.Text = curso.Dia;
                    labelHorario.Text = curso.Horario;
                }
            }
        }

        private void RellenarComboBoxMateriasYLabels()
        {
            Estudiante estudianteActual = programaForm.RetornarEstudiante();
            foreach (string curso in estudianteActual.CursosInscritos)
            {
                comboBoxMaterias.Items.Add(curso);
            }

            labelNombreHorarios.Text = estudianteActual.NombreCompleto;
            labelLegajoHorarios.Text = estudianteActual.Legajo;
        }

        private void AsignarDiaHorarioAula()
        {
            Random random = new Random();

            foreach (Curso curso in listaDeCursos)
            {
                curso.Dia = GenerarDiaAlAzar();
                curso.Horario = GenerarHorarioAlAzar();
                curso.Aula = GenerarAulaAlAzar();
            }
            Administrador.WriteStreamJSON<Curso>("cursos.json", listaDeCursos);
        }

        public static string GenerarDiaAlAzar()
        {
            Random random = new Random();

            List<string> diasSemana = new List<string>
            {
                "Lunes", "Martes", "Miercoles", "Jueves", "Viernes"
            };

            int indiceAleatorio = random.Next(0, diasSemana.Count);

            string diaAlAzar = diasSemana[indiceAleatorio];

            return diaAlAzar;
        }

        public static string GenerarHorarioAlAzar()
        {
            Random random = new Random();

            List<string> horarios = new List<string>
            {
                "18:30 a 20:30", "20:30 a 22:30"
            };

            int indiceAleatorio = random.Next(0, horarios.Count);

            string horarioAlAzar = horarios[indiceAleatorio];

            return horarioAlAzar;
        }

        public static string GenerarAulaAlAzar()
        {
            Random random = new Random();

            List<string> aulas = new List<string>();

            for (int i = 100; i <= 109; i++)
            {
                aulas.Add(i.ToString());
            }

            for (int i = 200; i <= 209; i++)
            {
                aulas.Add(i.ToString());
            }

            for (int i = 300; i <= 309; i++)
            {
                aulas.Add(i.ToString());
            }

            int indiceAleatorio = random.Next(0, aulas.Count);

            string aulaAlAzar = aulas[indiceAleatorio];

            return aulaAlAzar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panelSeleccionarMetodo.Visible)
            {
                panelSeleccionarMetodo.Visible = true;
            }
            else
            {
                panelSeleccionarMetodo.Visible = false;
            }
        }

        private void buttonTarjetas_Click(object sender, EventArgs e)
        {
            SeleccionarMetodoYEsconder(buttonTarjetas.Text);
            panelTarjetas.Visible = true;
            panelDatosCuenta.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionarMetodoYEsconder(buttonTransferencia.Text);
            panelTarjetas.Visible = false;
            panelDatosCuenta.Visible = true;
        }

        private void SeleccionarMetodoYEsconder(string opcion)
        {
            buttonSeleccionarMetodo.Text = opcion;
            panelSeleccionarMetodo.Visible = false;
        }

        private void SumarTotalYMostrar()
        {
            int pagoUno;
            int pagoDos;
            int pagoTres;
            int pagoCuatro;

            int.TryParse(textBoxValorMatricula.Text, out pagoUno);
            int.TryParse(textBoxValorCargosAdmin.Text, out pagoDos);
            int.TryParse(textBoxValorLibros.Text, out pagoTres);
            int.TryParse(textBoxValorCuota.Text, out pagoCuatro);

            Estudiante estudianteActual = programaForm.RetornarEstudiante();

            bool matriculaPagada = estudianteActual.PagosRealizados["matricula"] == 1;
            bool cargosPagados = estudianteActual.PagosRealizados["cargos"] == 1;
            bool librosPagados = estudianteActual.PagosRealizados["libros"] == 1;
            bool cuotaPagada = estudianteActual.PagosRealizados["cuota"] == 1;

            if (matriculaPagada)
            {
                textBoxValorMatricula.Text = "Usted ya lo pagó";
            }
            else if (pagoUno > 0)
            {
                totalAPagar += pagoUno;
            }

            if (cargosPagados)
            {
                textBoxValorCargosAdmin.Text = "Usted ya lo pagó";
            }
            else if (pagoDos > 0)
            {
                totalAPagar += pagoDos;
            }

            if (librosPagados)
            {
                textBoxValorLibros.Text = "Usted ya lo pagó";
            }
            else if (pagoTres > 0)
            {
                totalAPagar += pagoTres;
            }

            if (cuotaPagada)
            {
                textBoxValorCuota.Text = "Usted ya lo pagó";
            }
            else if (pagoCuatro > 0)
            {
                totalAPagar += pagoCuatro;
            }

            labelValorTotal.Text = $"${totalAPagar}";
        }



        private bool CorroborarValorDePago(string valor, Label label)
        {
            Accesorios accesorios = new Accesorios();

            if (!(!string.IsNullOrEmpty(valor) && accesorios.CorroborarNumerico(valor)))
            {
                label.ForeColor = Color.Red;
                return false;
            }

            label.ForeColor = Color.Black;
            return true;
        }

        private void buttonCalcularValorTotal_Click(object sender, EventArgs e)
        {
            if (!(CorroborarValorDePago(textBoxValorMatricula.Text, labelMatricula) &
                  CorroborarValorDePago(textBoxValorCargosAdmin.Text, labelCargosAdmin) &
                  CorroborarValorDePago(textBoxValorLibros.Text, labelLibros) &
                  CorroborarValorDePago(textBoxValorCuota.Text, labelCuota)))
            {
                MessageBox.Show("¡Error! Revise los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SumarTotalYMostrar();
                banderaDePago = true;
            }
        }

        private bool ValidarDatosDeTarjeta(string numero, string nombre, string vencimiento, string cvc)
        {
            Accesorios accesorios = new Accesorios();
            bool retorno = true;

            if (!(accesorios.CorroborarNumerico(numero) && numero.Length == 16))
            {
                labelNumeroTarjeta.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelNumeroTarjeta.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(nombre) && !accesorios.CorroborarTextoYEspacio(nombre))
            {
                labelNombreTarjeta.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelNombreTarjeta.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(vencimiento) && !accesorios.CorroborarFechaMmYy(vencimiento))
            {
                labelVenciminetoTarjeta.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelVenciminetoTarjeta.ForeColor = Color.Black;
            }

            if (!(accesorios.CorroborarNumerico(cvc) & cvc.Length == 3))
            {
                labelCvvCvc.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelCvvCvc.ForeColor = Color.Black;
            }
            return retorno;
        }

        private bool ValidarDatosCuentaDelBanco(string nombre, string numero, string razon)
        {
            Accesorios accesorios = new Accesorios();
            bool retorno = true;

            if (string.IsNullOrEmpty(nombre) && !accesorios.CorroborarTextoYEspacio(nombre))
            {
                labelNombreDeBanco.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelNombreDeBanco.ForeColor = Color.Black;
            }

            if (!(accesorios.CorroborarNumerico(numero) && numero.Length == 22))
            {
                labelNumeroDeCuenta.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelNumeroDeCuenta.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(razon) && !accesorios.CorroborarTextoYEspacio(razon))
            {
                labelRazon.ForeColor = Color.Red;
                retorno = false;
            }
            else
            {
                labelRazon.ForeColor = Color.Black;
            }

            return retorno;
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (!(ValidarDatosDeTarjeta(textBoxNumeroTarjeta.Text, textBoxNombreTarjeta.Text, textBoxVencimientoTarjeta.Text, textBoxCVVCVC.Text) ||
                  ValidarDatosCuentaDelBanco(textBoxNombreDeBanco.Text, textBoxNumeroDeCuenta.Text, textBoxRazon.Text)))
            {
                MessageBox.Show("¡Error! Revise los campos del medio de pago.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (banderaDePago)
                {
                    MessageBox.Show("Pago realizado con exito.", "Felicidades", MessageBoxButtons.OK);
                    Estudiante estudianteActual = programaForm.RetornarEstudiante();
                    estudianteActual.PagosRealizados["matricula"] = 1;
                    estudianteActual.PagosRealizados["cargos"] = 1;
                    estudianteActual.PagosRealizados["libros"] = 1;
                    estudianteActual.PagosRealizados["cuota"] = 1;

                    List<Estudiante> listaDeEstudiantes = Administrador.ReadStreamJSON<Estudiante>("estudiantes.json");

                    if (listaDeEstudiantes == null)
                    {
                        listaDeEstudiantes = new List<Estudiante>();
                    }

                    int contador = 0;
                    int index = 0;
                    foreach (Estudiante estudiante in listaDeEstudiantes)
                    {
                        if (estudiante.Legajo == estudianteActual.Legajo)
                        {
                            index = contador;
                            break;
                        }
                        contador++;
                    }

                    listaDeEstudiantes[index] = estudianteActual;
                    Administrador.WriteStreamJSON("estudiantes.json", listaDeEstudiantes);
                    this.Close();
                    FormEstudiante formEstudiante = new FormEstudiante(programaForm);
                    formEstudiante.Show();
                    FormComprobantePago formComprobanteDePago = new FormComprobantePago(estudianteActual.NombreCompleto, $"${totalAPagar}");
                    formComprobanteDePago.Show();
                }
                else
                {
                    MessageBox.Show("¡Error! corrobore si tiene que pagar algun concepto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
