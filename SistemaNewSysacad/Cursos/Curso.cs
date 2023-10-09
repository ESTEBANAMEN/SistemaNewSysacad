using System;
using System.Collections.Generic;

namespace Cursos
{
    public class Curso
    {
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? CupoMaximo { get; set; }
        public string? Dia { get; set; }
        public string? Horario { get; set; }
        public string? Aula { get; set; }

        public Curso()
        {
            Dia = null;
            Horario = null;
            Aula = null;
        }

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            CupoMaximo = cupoMaximo;
            Dia = null;
            Horario = null;
            Aula = null;
        }

 
        public void AsignarInformacionAdicional(string dia, string horario, string aula)
        {
            Dia = dia;
            Horario = horario;
            Aula = aula;
        }
    }
}
