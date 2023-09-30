using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    public class Curso
    {
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? CupoMaximo { get; set; }

        public Curso()
        {
        }

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            CupoMaximo = cupoMaximo;
        }
    }
}
